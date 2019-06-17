namespace VisualInterface
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.label1 = new System.Windows.Forms.Label();
            this.MasterBtn = new System.Windows.Forms.Button();
            this.SlaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Haz click para crear una instancia de:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MasterBtn
            // 
            this.MasterBtn.BackgroundImage = global::VisualInterface.Properties.Resources._51338;
            this.MasterBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MasterBtn.Location = new System.Drawing.Point(12, 49);
            this.MasterBtn.Name = "MasterBtn";
            this.MasterBtn.Size = new System.Drawing.Size(200, 84);
            this.MasterBtn.TabIndex = 1;
            this.MasterBtn.Text = "Maestro";
            this.MasterBtn.UseVisualStyleBackColor = true;
            this.MasterBtn.Click += new System.EventHandler(this.MasterBtn_Click);
            // 
            // SlaveBtn
            // 
            this.SlaveBtn.BackgroundImage = global::VisualInterface.Properties.Resources._41214_200;
            this.SlaveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SlaveBtn.Location = new System.Drawing.Point(221, 49);
            this.SlaveBtn.Name = "SlaveBtn";
            this.SlaveBtn.Size = new System.Drawing.Size(200, 84);
            this.SlaveBtn.TabIndex = 2;
            this.SlaveBtn.Text = "Esclavo";
            this.SlaveBtn.UseVisualStyleBackColor = true;
            this.SlaveBtn.Click += new System.EventHandler(this.SlaveBtn_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 146);
            this.Controls.Add(this.SlaveBtn);
            this.Controls.Add(this.MasterBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MasterBtn;
        private System.Windows.Forms.Button SlaveBtn;
    }
}