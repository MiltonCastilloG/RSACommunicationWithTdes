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
            this.label1 = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(174, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soy Esclavo";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // RsaGeneratorBtn
            // 
            this.RsaGeneratorBtn.Location = new System.Drawing.Point(25, 69);
            this.RsaGeneratorBtn.Name = "RsaGeneratorBtn";
            this.RsaGeneratorBtn.Size = new System.Drawing.Size(121, 23);
            this.RsaGeneratorBtn.TabIndex = 1;
            this.RsaGeneratorBtn.Text = "Generar Clave RSA";
            this.RsaGeneratorBtn.UseVisualStyleBackColor = true;
            // 
            // PublicKeyValue
            // 
            this.PublicKeyValue.AutoSize = true;
            this.PublicKeyValue.Location = new System.Drawing.Point(279, 57);
            this.PublicKeyValue.Name = "PublicKeyValue";
            this.PublicKeyValue.Size = new System.Drawing.Size(97, 13);
            this.PublicKeyValue.TabIndex = 2;
            this.PublicKeyValue.Text = "<valor de la clave>";
            // 
            // PublicKeyLabel
            // 
            this.PublicKeyLabel.AutoSize = true;
            this.PublicKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublicKeyLabel.Location = new System.Drawing.Point(177, 57);
            this.PublicKeyLabel.Name = "PublicKeyLabel";
            this.PublicKeyLabel.Size = new System.Drawing.Size(85, 13);
            this.PublicKeyLabel.TabIndex = 3;
            this.PublicKeyLabel.Text = "Clave Publica";
            this.PublicKeyLabel.Click += new System.EventHandler(this.Label2_Click);
            // 
            // PrivateKeyLabel
            // 
            this.PrivateKeyLabel.AutoSize = true;
            this.PrivateKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivateKeyLabel.Location = new System.Drawing.Point(177, 92);
            this.PrivateKeyLabel.Name = "PrivateKeyLabel";
            this.PrivateKeyLabel.Size = new System.Drawing.Size(86, 13);
            this.PrivateKeyLabel.TabIndex = 4;
            this.PrivateKeyLabel.Text = "Clave Privada";
            // 
            // PrivateKeyValue
            // 
            this.PrivateKeyValue.AutoSize = true;
            this.PrivateKeyValue.Location = new System.Drawing.Point(279, 92);
            this.PrivateKeyValue.Name = "PrivateKeyValue";
            this.PrivateKeyValue.Size = new System.Drawing.Size(97, 13);
            this.PrivateKeyValue.TabIndex = 5;
            this.PrivateKeyValue.Text = "<valor de la clave>";
            // 
            // ExportPublicKeyBtn
            // 
            this.ExportPublicKeyBtn.Location = new System.Drawing.Point(25, 132);
            this.ExportPublicKeyBtn.Name = "ExportPublicKeyBtn";
            this.ExportPublicKeyBtn.Size = new System.Drawing.Size(500, 23);
            this.ExportPublicKeyBtn.TabIndex = 6;
            this.ExportPublicKeyBtn.Text = "Exportar XML Publica";
            this.ExportPublicKeyBtn.UseVisualStyleBackColor = true;
            this.ExportPublicKeyBtn.Click += new System.EventHandler(this.Button2_Click_1);
            // 
            // ImportTdesXmlBtn
            // 
            this.ImportTdesXmlBtn.Location = new System.Drawing.Point(25, 189);
            this.ImportTdesXmlBtn.Name = "ImportTdesXmlBtn";
            this.ImportTdesXmlBtn.Size = new System.Drawing.Size(121, 37);
            this.ImportTdesXmlBtn.TabIndex = 7;
            this.ImportTdesXmlBtn.Text = "Importar clave TDES de fichero XML";
            this.ImportTdesXmlBtn.UseVisualStyleBackColor = true;
            // 
            // DecryptTdesBtn
            // 
            this.DecryptTdesBtn.Location = new System.Drawing.Point(25, 250);
            this.DecryptTdesBtn.Name = "DecryptTdesBtn";
            this.DecryptTdesBtn.Size = new System.Drawing.Size(121, 37);
            this.DecryptTdesBtn.TabIndex = 8;
            this.DecryptTdesBtn.Text = "Desencriptar clave TDES de fichero";
            this.DecryptTdesBtn.UseVisualStyleBackColor = true;
            // 
            // ImportTdesXmlLabel
            // 
            this.ImportTdesXmlLabel.AutoSize = true;
            this.ImportTdesXmlLabel.Location = new System.Drawing.Point(177, 201);
            this.ImportTdesXmlLabel.Name = "ImportTdesXmlLabel";
            this.ImportTdesXmlLabel.Size = new System.Drawing.Size(182, 13);
            this.ImportTdesXmlLabel.TabIndex = 9;
            this.ImportTdesXmlLabel.Text = "<valor de la clave TDES encriptada>";
            // 
            // DecryptTdesLabel
            // 
            this.DecryptTdesLabel.AutoSize = true;
            this.DecryptTdesLabel.Location = new System.Drawing.Point(177, 262);
            this.DecryptTdesLabel.Name = "DecryptTdesLabel";
            this.DecryptTdesLabel.Size = new System.Drawing.Size(194, 13);
            this.DecryptTdesLabel.TabIndex = 10;
            this.DecryptTdesLabel.Text = "<valor de la clave TDES deencriptada>";
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageLabel.Location = new System.Drawing.Point(22, 333);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(101, 13);
            this.MessageLabel.TabIndex = 11;
            this.MessageLabel.Text = "Introducir Texto:";
            this.MessageLabel.Click += new System.EventHandler(this.MessageLabel_Click);
            // 
            // MessageTb
            // 
            this.MessageTb.Location = new System.Drawing.Point(129, 330);
            this.MessageTb.Name = "MessageTb";
            this.MessageTb.Size = new System.Drawing.Size(396, 20);
            this.MessageTb.TabIndex = 12;
            // 
            // Slave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 710);
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
            this.Controls.Add(this.label1);
            this.Name = "Slave";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
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
    }
}

