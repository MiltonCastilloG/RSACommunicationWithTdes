namespace VisualInterface
{
    partial class Slave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.RsaGeneratorBtn = new System.Windows.Forms.Button();
            this.PublicKeyValue = new System.Windows.Forms.Label();
            this.PublicKeyLabel = new System.Windows.Forms.Label();
            this.PrivateKeyLabel = new System.Windows.Forms.Label();
            this.PrivateKeyValue = new System.Windows.Forms.Label();
            this.ExportPublicKeyBtn = new System.Windows.Forms.Button();
            this.ImportTdesXmlBtn = new System.Windows.Forms.Button();
            this.DecryptTdesBtn = new System.Windows.Forms.Button();
            this.ImportTdesXmlLabel = new System.Windows.Forms.Label();
            this.DecryptTdesLabel = new System.Windows.Forms.Label();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.MessageTb = new System.Windows.Forms.TextBox();
            this.EncryptMessageBtn = new System.Windows.Forms.Button();
            this.ExportMessageTdesBtn = new System.Windows.Forms.Button();
            this.EncryptMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(184, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(175, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Soy Esclavo";
            // 
            // RsaGeneratorBtn
            // 
            this.RsaGeneratorBtn.Location = new System.Drawing.Point(25, 83);
            this.RsaGeneratorBtn.Name = "RsaGeneratorBtn";
            this.RsaGeneratorBtn.Size = new System.Drawing.Size(121, 23);
            this.RsaGeneratorBtn.TabIndex = 1;
            this.RsaGeneratorBtn.Text = "Generar Clave RSA";
            this.RsaGeneratorBtn.UseVisualStyleBackColor = true;
            this.RsaGeneratorBtn.Click += new System.EventHandler(this.RsaGeneratorBtn_Click);
            // 
            // PublicKeyValue
            // 
            this.PublicKeyValue.AutoSize = true;
            this.PublicKeyValue.Location = new System.Drawing.Point(279, 71);
            this.PublicKeyValue.Name = "PublicKeyValue";
            this.PublicKeyValue.Size = new System.Drawing.Size(97, 13);
            this.PublicKeyValue.TabIndex = 2;
            this.PublicKeyValue.Text = "<valor de la clave>";
            // 
            // PublicKeyLabel
            // 
            this.PublicKeyLabel.AutoSize = true;
            this.PublicKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicKeyLabel.Location = new System.Drawing.Point(177, 71);
            this.PublicKeyLabel.Name = "PublicKeyLabel";
            this.PublicKeyLabel.Size = new System.Drawing.Size(85, 13);
            this.PublicKeyLabel.TabIndex = 3;
            this.PublicKeyLabel.Text = "Clave Publica";
            // 
            // PrivateKeyLabel
            // 
            this.PrivateKeyLabel.AutoSize = true;
            this.PrivateKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivateKeyLabel.Location = new System.Drawing.Point(177, 106);
            this.PrivateKeyLabel.Name = "PrivateKeyLabel";
            this.PrivateKeyLabel.Size = new System.Drawing.Size(86, 13);
            this.PrivateKeyLabel.TabIndex = 4;
            this.PrivateKeyLabel.Text = "Clave Privada";
            // 
            // PrivateKeyValue
            // 
            this.PrivateKeyValue.AutoSize = true;
            this.PrivateKeyValue.Location = new System.Drawing.Point(279, 106);
            this.PrivateKeyValue.Name = "PrivateKeyValue";
            this.PrivateKeyValue.Size = new System.Drawing.Size(97, 13);
            this.PrivateKeyValue.TabIndex = 5;
            this.PrivateKeyValue.Text = "<valor de la clave>";
            // 
            // ExportPublicKeyBtn
            // 
            this.ExportPublicKeyBtn.Location = new System.Drawing.Point(25, 146);
            this.ExportPublicKeyBtn.Name = "ExportPublicKeyBtn";
            this.ExportPublicKeyBtn.Size = new System.Drawing.Size(500, 23);
            this.ExportPublicKeyBtn.TabIndex = 6;
            this.ExportPublicKeyBtn.Text = "Exportar XML Publica";
            this.ExportPublicKeyBtn.UseVisualStyleBackColor = true;
            this.ExportPublicKeyBtn.Click += new System.EventHandler(this.ExportPublicKeyBtn_Click);
            // 
            // ImportTdesXmlBtn
            // 
            this.ImportTdesXmlBtn.Location = new System.Drawing.Point(25, 203);
            this.ImportTdesXmlBtn.Name = "ImportTdesXmlBtn";
            this.ImportTdesXmlBtn.Size = new System.Drawing.Size(121, 37);
            this.ImportTdesXmlBtn.TabIndex = 7;
            this.ImportTdesXmlBtn.Text = "Importar clave TDES de fichero XML";
            this.ImportTdesXmlBtn.UseVisualStyleBackColor = true;
            this.ImportTdesXmlBtn.Click += new System.EventHandler(this.ImportTdesXmlBtn_Click);
            // 
            // DecryptTdesBtn
            // 
            this.DecryptTdesBtn.Location = new System.Drawing.Point(25, 264);
            this.DecryptTdesBtn.Name = "DecryptTdesBtn";
            this.DecryptTdesBtn.Size = new System.Drawing.Size(121, 37);
            this.DecryptTdesBtn.TabIndex = 8;
            this.DecryptTdesBtn.Text = "Desencriptar clave TDES de fichero";
            this.DecryptTdesBtn.UseVisualStyleBackColor = true;
            this.DecryptTdesBtn.Click += new System.EventHandler(this.DecryptTdesBtn_Click);
            // 
            // ImportTdesXmlLabel
            // 
            this.ImportTdesXmlLabel.AutoSize = true;
            this.ImportTdesXmlLabel.Location = new System.Drawing.Point(177, 215);
            this.ImportTdesXmlLabel.Name = "ImportTdesXmlLabel";
            this.ImportTdesXmlLabel.Size = new System.Drawing.Size(182, 13);
            this.ImportTdesXmlLabel.TabIndex = 9;
            this.ImportTdesXmlLabel.Text = "<valor de la clave TDES encriptada>";
            // 
            // DecryptTdesLabel
            // 
            this.DecryptTdesLabel.AutoSize = true;
            this.DecryptTdesLabel.Location = new System.Drawing.Point(177, 276);
            this.DecryptTdesLabel.Name = "DecryptTdesLabel";
            this.DecryptTdesLabel.Size = new System.Drawing.Size(194, 13);
            this.DecryptTdesLabel.TabIndex = 10;
            this.DecryptTdesLabel.Text = "<valor de la clave TDES deencriptada>";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(22, 347);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(101, 13);
            this.MessageLabel.TabIndex = 11;
            this.MessageLabel.Text = "Introducir Texto:";
            // 
            // MessageTb
            // 
            this.MessageTb.Location = new System.Drawing.Point(129, 344);
            this.MessageTb.Name = "MessageTb";
            this.MessageTb.Size = new System.Drawing.Size(396, 20);
            this.MessageTb.TabIndex = 12;
            // 
            // EncryptMessageBtn
            // 
            this.EncryptMessageBtn.Location = new System.Drawing.Point(25, 385);
            this.EncryptMessageBtn.Name = "EncryptMessageBtn";
            this.EncryptMessageBtn.Size = new System.Drawing.Size(500, 23);
            this.EncryptMessageBtn.TabIndex = 13;
            this.EncryptMessageBtn.Text = "Encriptar texto algoritmo TDES y clave TDES desencriptada ";
            this.EncryptMessageBtn.UseVisualStyleBackColor = true;
            this.EncryptMessageBtn.Click += new System.EventHandler(this.EncryptMessageBtn_Click);
            // 
            // ExportMessageTdesBtn
            // 
            this.ExportMessageTdesBtn.Location = new System.Drawing.Point(282, 436);
            this.ExportMessageTdesBtn.Name = "ExportMessageTdesBtn";
            this.ExportMessageTdesBtn.Size = new System.Drawing.Size(243, 23);
            this.ExportMessageTdesBtn.TabIndex = 14;
            this.ExportMessageTdesBtn.Text = "Exportar mensaje a xml";
            this.ExportMessageTdesBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ExportMessageTdesBtn.UseVisualStyleBackColor = true;
            this.ExportMessageTdesBtn.Click += new System.EventHandler(this.ExportMessageTdesBtn_Click);
            // 
            // EncryptMessageLabel
            // 
            this.EncryptMessageLabel.AutoSize = true;
            this.EncryptMessageLabel.Location = new System.Drawing.Point(60, 441);
            this.EncryptMessageLabel.Name = "EncryptMessageLabel";
            this.EncryptMessageLabel.Size = new System.Drawing.Size(163, 13);
            this.EncryptMessageLabel.TabIndex = 15;
            this.EncryptMessageLabel.Text = "<Resultado del texto encriptado>";
            // 
            // Slave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(537, 710);
            this.Controls.Add(this.EncryptMessageLabel);
            this.Controls.Add(this.ExportMessageTdesBtn);
            this.Controls.Add(this.EncryptMessageBtn);
            this.Controls.Add(this.MessageTb);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.DecryptTdesLabel);
            this.Controls.Add(this.ImportTdesXmlLabel);
            this.Controls.Add(this.DecryptTdesBtn);
            this.Controls.Add(this.ImportTdesXmlBtn);
            this.Controls.Add(this.ExportPublicKeyBtn);
            this.Controls.Add(this.PrivateKeyValue);
            this.Controls.Add(this.PrivateKeyLabel);
            this.Controls.Add(this.PublicKeyLabel);
            this.Controls.Add(this.PublicKeyValue);
            this.Controls.Add(this.RsaGeneratorBtn);
            this.Controls.Add(this.Title);
            this.Name = "Slave";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button RsaGeneratorBtn;
        private System.Windows.Forms.Label PublicKeyValue;
        private System.Windows.Forms.Label PublicKeyLabel;
        private System.Windows.Forms.Label PrivateKeyLabel;
        private System.Windows.Forms.Label PrivateKeyValue;
        private System.Windows.Forms.Button ExportPublicKeyBtn;
        private System.Windows.Forms.Button ImportTdesXmlBtn;
        private System.Windows.Forms.Button DecryptTdesBtn;
        private System.Windows.Forms.Label ImportTdesXmlLabel;
        private System.Windows.Forms.Label DecryptTdesLabel;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.TextBox MessageTb;
        private System.Windows.Forms.Button EncryptMessageBtn;
        private System.Windows.Forms.Button ExportMessageTdesBtn;
        private System.Windows.Forms.Label EncryptMessageLabel;
    }
}

