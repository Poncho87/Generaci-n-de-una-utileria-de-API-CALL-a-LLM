using System;
using System.ComponentModel;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotNetEnv;

namespace PruebaConexionGemini
{
    public partial class Form1 : Form
    {
        // Clases auxiliares para manejar el historial del chat
        public class ChatMessage
        {
            
            public string Remitente { get; set; }
            public string Mensaje { get; set; }
            public string Hora { get; set; }
        }

        // Variables para manejar el historial del chat y la conexión HTTP
        private BindingList<ChatMessage> chatHistory;
        private readonly HttpClient _httpClient;
        private string _apiKey;
        private readonly string _baseUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent";

        public Form1()
        {
            InitializeComponent();

            // Vinculamos la lista al DataGridView para que se actualice sola
            chatHistory = new BindingList<ChatMessage>();
            dgvChat.DataSource = chatHistory;
            dgvChat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Las columnas llenan el espacio
            dgvChat.RowHeadersVisible = false;

            // Cargamos la configuración de Gemini
            Env.Load();
            _apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY") ?? "";
            _httpClient = new HttpClient();

            if (string.IsNullOrEmpty(_apiKey))
            {
                MessageBox.Show("No se encontró la GEMINI_API_KEY en el archivo .env", "Error");
                btnEnviar.Enabled = false;
            }
        }

        // Configuramos el evento click del botón para enviar el mensaje a Gemini
        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            // Tomamos el texto del usuario
            string prompt = txtInput.Text.Trim();
            if (string.IsNullOrEmpty(prompt)) return;

            // Bloqueamos la UI para que el usuario no envíe 2 veces seguidas
            btnEnviar.Enabled = false;
            AgregarMensajeAlGrid("Tú", prompt);
            txtInput.Clear();

            // Llamamos a Gemini (esperamos sin congelar la pantalla)
            string respuesta = await LlamarApiGemini(prompt);

            // Mostramos respuesta y desbloqueamos UI
            AgregarMensajeAlGrid("Gemini", respuesta);
            btnEnviar.Enabled = true;
            txtInput.Focus();

            // Mostramos la respuesta completa y bonita en el cuadro de texto 
            txtRespuestaCompleta.Text = respuesta;

            // Limpiamos la caja de texto del usuario para su siguiente pregunta
            txtInput.Clear();
            btnEnviar.Enabled = true;
        }

        // Funcion para agregar mensajes al DataGridView de forma ordenada y con formato
        private void AgregarMensajeAlGrid(string remitente, string mensaje)
        {
            chatHistory.Add(new ChatMessage
            {
                Remitente = remitente,
                Mensaje = mensaje,
                Hora = DateTime.Now.ToString("HH:mm:ss")
            });

            // EXTRA Hacer scroll automático hacia abajo
            if (dgvChat.Rows.Count > 0)
            {
                dgvChat.FirstDisplayedScrollingRowIndex = dgvChat.Rows.Count - 1;
            }
        }

        // Conexion a la API de Gemini usando HttpClient, con manejo de errores y parsing de la respuesta
        private async Task<string> LlamarApiGemini(string prompt)
        {
            // Limpiamos la llave por si las dudas
            _apiKey = _apiKey?.Trim();

            // Conectamos a la API de Gemini usando HttpClient
            string url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-flash:generateContent?key={_apiKey}";

            var requestBody = new { contents = new[] { new { parts = new[] { new { text = prompt } } } } };
            var json = JsonSerializer.Serialize(requestBody);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            // Hacemos la petición POST y manejamos la respuesta
            try
            {
                var response = await _httpClient.PostAsync(url, content);
                var responseString = await response.Content.ReadAsStringAsync();

                if (!response.IsSuccessStatusCode)
                {
                    return $"Error de Google ({response.StatusCode}): {responseString}";
                }

                using (var doc = JsonDocument.Parse(responseString))
                {
                    return doc.RootElement
                        .GetProperty("candidates")[0]
                        .GetProperty("content")
                        .GetProperty("parts")[0]
                        .GetProperty("text")
                        .GetString() ?? "Sin respuesta";
                }
            }
            catch (Exception ex)
            {
                return $"[Error]: {ex.Message}";
            }
        }
    }
}
