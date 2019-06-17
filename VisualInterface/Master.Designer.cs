namespace VisualInterface
{
    partial class Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.DecryptMessageLabel = new System.Windows.Forms.Label();
            this.DecryptMessageBtn = new System.Windows.Forms.Button();
            this.ImportMessageBtn = new System.Windows.Forms.Button();
            this.EncryptWithPublicKeyLabel = new System.Windows.Forms.Label();
            this.GenerateTdesLabel = new System.Windows.Forms.Label();
            this.EncryptWithPublicKeyBtn = new System.Windows.Forms.Button();
            this.GenerateTdesBtn = new System.Windows.Forms.Button();
            this.ImportPublicKeyBtn = new System.Windows.Forms.Button();
            this.PrivateKeyValue = new System.Windows.Forms.Label();
            this.PrivateKeyLabel = new System.Windows.Forms.Label();
            this.PublicKeyLabel = new System.Windows.Forms.Label();
            this.PublicKeyValue = new System.Windows.Forms.Label();
            this.RsaGeneratorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ImportPublicKeyLabel = new System.Windows.Forms.Label();
            this.ExportEncryptedTdesBtn = new System.Windows.Forms.Button();
            this.ImportMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DecryptMessageLabel
            // 
            this.DecryptMessageLabel.AutoSize = true;
            this.DecryptMessageLabel.Location = new System.Drawing.Point(18, 469);
            this.DecryptMessageLabel.Name = "DecryptMessageLabel";
            this.DecryptMessageLabel.Size = new System.Drawing.Size(111, 13);
            this.DecryptMessageLabel.TabIndex = 31;
            this.DecryptMessageLabel.Text = "<Texto deencriptado>";
            // 
            // DecryptMessageBtn
            // 
            this.DecryptMessageBtn.Enabled = false;
            this.DecryptMessageBtn.Location = new System.Drawing.Point(21, 424);
            this.DecryptMessageBtn.Name = "DecryptMessageBtn";
            this.DecryptMessageBtn.Size = new System.Drawing.Size(243, 23);
            this.DecryptMessageBtn.TabIndex = 30;
            this.DecryptMessageBtn.Text = "Deencriptar texto con TDES y clave TDES creada";
            this.DecryptMessageBtn.UseVisualStyleBackColor = true;
            this.DecryptMessageBtn.Click += new System.EventHandler(this.DecryptMessageBtn_Click);
            // 
            // ImportMessageBtn
            // 
            this.ImportMessageBtn.Enabled = false;
            this.ImportMessageBtn.Location = new System.Drawing.Point(21, 379);
            this.ImportMessageBtn.Name = "ImportMessageBtn";
            this.ImportMessageBtn.Size = new System.Drawing.Size(237, 23);
            this.ImportMessageBtn.TabIndex = 29;
            this.ImportMessageBtn.Text = "Importar mensaje de xml";
            this.ImportMessageBtn.UseVisualStyleBackColor = true;
            this.ImportMessageBtn.Click += new System.EventHandler(this.ImportMessageBtn_Click);
            // 
            // EncryptWithPublicKeyLabel
            // 
            this.EncryptWithPublicKeyLabel.AutoSize = true;
            this.EncryptWithPublicKeyLabel.Location = new System.Drawing.Point(233, 276);
            this.EncryptWithPublicKeyLabel.Name = "EncryptWithPublicKeyLabel";
            this.EncryptWithPublicKeyLabel.Size = new System.Drawing.Size(182, 13);
            this.EncryptWithPublicKeyLabel.TabIndex = 26;
            this.EncryptWithPublicKeyLabel.Text = "<valor de la clave TDES encriptada>";
            // 
            // GenerateTdesLabel
            // 
            this.GenerateTdesLabel.AutoSize = true;
            this.GenerateTdesLabel.Location = new System.Drawing.Point(233, 215);
            this.GenerateTdesLabel.Name = "GenerateTdesLabel";
            this.GenerateTdesLabel.Size = new System.Drawing.Size(129, 13);
            this.GenerateTdesLabel.TabIndex = 25;
            this.GenerateTdesLabel.Text = "<valor de la clave TDES>";
            // 
            // EncryptWithPublicKeyBtn
            // 
            this.EncryptWithPublicKeyBtn.Enabled = false;
            this.EncryptWithPublicKeyBtn.Location = new System.Drawing.Point(21, 264);
            this.EncryptWithPublicKeyBtn.Name = "EncryptWithPublicKeyBtn";
            this.EncryptWithPublicKeyBtn.Size = new System.Drawing.Size(182, 37);
            this.EncryptWithPublicKeyBtn.TabIndex = 24;
            this.EncryptWithPublicKeyBtn.Text = "Encriptar clave TDES con RSA y clave publica esclavo";
            this.EncryptWithPublicKeyBtn.UseVisualStyleBackColor = true;
            this.EncryptWithPublicKeyBtn.Click += new System.EventHandler(this.EncryptWithPublicKeyBtn_Click);
            // 
            // GenerateTdesBtn
            // 
            this.GenerateTdesBtn.Enabled = false;
            this.GenerateTdesBtn.Location = new System.Drawing.Point(21, 203);
            this.GenerateTdesBtn.Name = "GenerateTdesBtn";
            this.GenerateTdesBtn.Size = new System.Drawing.Size(182, 37);
            this.GenerateTdesBtn.TabIndex = 23;
            this.GenerateTdesBtn.Text = "Generar clave TDES";
            this.GenerateTdesBtn.UseVisualStyleBackColor = true;
            this.GenerateTdesBtn.Click += new System.EventHandler(this.GenerateTdesBtn_Click);
            // 
            // ImportPublicKeyBtn
            // 
            this.ImportPublicKeyBtn.Location = new System.Drawing.Point(21, 146);
            this.ImportPublicKeyBtn.Name = "ImportPublicKeyBtn";
            this.ImportPublicKeyBtn.Size = new System.Drawing.Size(237, 23);
            this.ImportPublicKeyBtn.TabIndex = 22;
            this.ImportPublicKeyBtn.Text = "Importar clave publica RSA Esclavo";
            this.ImportPublicKeyBtn.UseVisualStyleBackColor = true;
            this.ImportPublicKeyBtn.Click += new System.EventHandler(this.ImportPublicKeyBtn_Click);
            // 
            // PrivateKeyValue
            // 
            this.PrivateKeyValue.AutoSize = true;
            this.PrivateKeyValue.Location = new System.Drawing.Point(275, 106);
            this.PrivateKeyValue.Name = "PrivateKeyValue";
            this.PrivateKeyValue.Size = new System.Drawing.Size(97, 13);
            this.PrivateKeyValue.TabIndex = 21;
            this.PrivateKeyValue.Text = "<valor de la clave>";
            // 
            // PrivateKeyLabel
            // 
            this.PrivateKeyLabel.AutoSize = true;
            this.PrivateKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivateKeyLabel.Location = new System.Drawing.Point(173, 106);
            this.PrivateKeyLabel.Name = "PrivateKeyLabel";
            this.PrivateKeyLabel.Size = new System.Drawing.Size(86, 13);
            this.PrivateKeyLabel.TabIndex = 20;
            this.PrivateKeyLabel.Text = "Clave Privada";
            // 
            // PublicKeyLabel
            // 
            this.PublicKeyLabel.AutoSize = true;
            this.PublicKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicKeyLabel.Location = new System.Drawing.Point(173, 71);
            this.PublicKeyLabel.Name = "PublicKeyLabel";
            this.PublicKeyLabel.Size = new System.Drawing.Size(85, 13);
            this.PublicKeyLabel.TabIndex = 19;
            this.PublicKeyLabel.Text = "Clave Publica";
            // 
            // PublicKeyValue
            // 
            this.PublicKeyValue.AutoSize = true;
            this.PublicKeyValue.Location = new System.Drawing.Point(275, 71);
            this.PublicKeyValue.Name = "PublicKeyValue";
            this.PublicKeyValue.Size = new System.Drawing.Size(97, 13);
            this.PublicKeyValue.TabIndex = 18;
            this.PublicKeyValue.Text = "<valor de la clave>";
            // 
            // RsaGeneratorBtn
            // 
            this.RsaGeneratorBtn.Location = new System.Drawing.Point(21, 84);
            this.RsaGeneratorBtn.Name = "RsaGeneratorBtn";
            this.RsaGeneratorBtn.Size = new System.Drawing.Size(121, 23);
            this.RsaGeneratorBtn.TabIndex = 17;
            this.RsaGeneratorBtn.Text = "Generar Clave RSA";
            this.RsaGeneratorBtn.UseVisualStyleBackColor = true;
            this.RsaGeneratorBtn.Click += new System.EventHandler(this.RsaGeneratorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Soy Maestro";
            // 
            // ImportPublicKeyLabel
            // 
            this.ImportPublicKeyLabel.AutoSize = true;
            this.ImportPublicKeyLabel.Location = new System.Drawing.Point(275, 151);
            this.ImportPublicKeyLabel.Name = "ImportPublicKeyLabel";
            this.ImportPublicKeyLabel.Size = new System.Drawing.Size(174, 13);
            this.ImportPublicKeyLabel.TabIndex = 32;
            this.ImportPublicKeyLabel.Text = "<valor de la clave publica esclavo>";
            // 
            // ExportEncryptedTdesBtn
            // 
            this.ExportEncryptedTdesBtn.Enabled = false;
            this.ExportEncryptedTdesBtn.Location = new System.Drawing.Point(21, 332);
            this.ExportEncryptedTdesBtn.Name = "ExportEncryptedTdesBtn";
            this.ExportEncryptedTdesBtn.Size = new System.Drawing.Size(500, 23);
            this.ExportEncryptedTdesBtn.TabIndex = 33;
            this.ExportEncryptedTdesBtn.Text = "Exportar xml TDES encriptada";
            this.ExportEncryptedTdesBtn.UseVisualStyleBackColor = true;
            this.ExportEncryptedTdesBtn.Click += new System.EventHandler(this.ExportEncryptedTdesBtn_Click);
            // 
            // ImportMessageLabel
            // 
            this.ImportMessageLabel.AutoSize = true;
            this.ImportMessageLabel.Location = new System.Drawing.Point(275, 384);
            this.ImportMessageLabel.Name = "ImportMessageLabel";
            this.ImportMessageLabel.Size = new System.Drawing.Size(169, 13);
            this.ImportMessageLabel.TabIndex = 34;
            this.ImportMessageLabel.Text = "<Texto encriptado del fichero xml>";
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(537, 710);
            this.Controls.Add(this.ImportMessageLabel);
            this.Controls.Add(this.ExportEncryptedTdesBtn);
            this.Controls.Add(this.ImportPublicKeyLabel);
            this.Controls.Add(this.DecryptMessageLabel);
            this.Controls.Add(this.DecryptMessageBtn);
            this.Controls.Add(this.ImportMessageBtn);
            this.Controls.Add(this.EncryptWithPublicKeyLabel);
            this.Controls.Add(this.GenerateTdesLabel);
            this.Controls.Add(this.EncryptWithPublicKeyBtn);
            this.Controls.Add(this.GenerateTdesBtn);
            this.Controls.Add(this.ImportPublicKeyBtn);
            this.Controls.Add(this.PrivateKeyValue);
            this.Controls.Add(this.PrivateKeyLabel);
            this.Controls.Add(this.PublicKeyLabel);
            this.Controls.Add(this.PublicKeyValue);
            this.Controls.Add(this.RsaGeneratorBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Master";
            this.Text = "Master";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DecryptMessageLabel;
        private System.Windows.Forms.Button DecryptMessageBtn;
        private System.Windows.Forms.Button ImportMessageBtn;
        private System.Windows.Forms.Label EncryptWithPublicKeyLabel;
        private System.Windows.Forms.Label GenerateTdesLabel;
        private System.Windows.Forms.Button EncryptWithPublicKeyBtn;
        private System.Windows.Forms.Button GenerateTdesBtn;
        private System.Windows.Forms.Button ImportPublicKeyBtn;
        private System.Windows.Forms.Label PrivateKeyValue;
        private System.Windows.Forms.Label PrivateKeyLabel;
        private System.Windows.Forms.Label PublicKeyLabel;
        private System.Windows.Forms.Label PublicKeyValue;
        private System.Windows.Forms.Button RsaGeneratorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ImportPublicKeyLabel;
        private System.Windows.Forms.Button ExportEncryptedTdesBtn;
        private System.Windows.Forms.Label ImportMessageLabel;
    }
}