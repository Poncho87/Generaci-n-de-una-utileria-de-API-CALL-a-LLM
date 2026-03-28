namespace PruebaConexionGemini
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvChat = new System.Windows.Forms.DataGridView();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtRespuestaCompleta = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChat
            // 
            this.dgvChat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChat.Location = new System.Drawing.Point(12, 48);
            this.dgvChat.Name = "dgvChat";
            this.dgvChat.Size = new System.Drawing.Size(265, 468);
            this.dgvChat.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(807, 482);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(122, 35);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(352, 485);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(409, 26);
            this.txtInput.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtRespuestaCompleta
            // 
            this.txtRespuestaCompleta.BackColor = System.Drawing.SystemColors.GrayText;
            this.txtRespuestaCompleta.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuestaCompleta.ForeColor = System.Drawing.SystemColors.Window;
            this.txtRespuestaCompleta.Location = new System.Drawing.Point(295, 48);
            this.txtRespuestaCompleta.Name = "txtRespuestaCompleta";
            this.txtRespuestaCompleta.ReadOnly = true;
            this.txtRespuestaCompleta.Size = new System.Drawing.Size(655, 420);
            this.txtRespuestaCompleta.TabIndex = 6;
            this.txtRespuestaCompleta.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "HISTORIAL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(447, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "GEMINI RESPONDE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(962, 540);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRespuestaCompleta);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.dgvChat);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvChat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChat;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox txtRespuestaCompleta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

