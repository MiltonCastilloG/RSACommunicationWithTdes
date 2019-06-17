using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Communicators;

namespace VisualInterface
{
    public partial class Master : Form
    {
        MasterCommunicator masterCommunicator;

        public Master()
        {
            masterCommunicator = new MasterCommunicator();
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Right - this.Width-100, scrn.Bounds.Top);
                    return;
                }
            }
        }
        private void RsaGeneratorBtn_Click(object sender, EventArgs e)
        {
            PublicKeyValue.Text = this.masterCommunicator.getPublicKey();
            PrivateKeyValue.Text = this.masterCommunicator.getPrivateKey();
        }
        private void ImportPublicKeyBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = Environment.CurrentDirectory + "/xml",
                    Title = "Browse XML Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "xml",
                    Filter = "xml files (*.xml)|*.xml",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ImportPublicKeyLabel.Text = this.masterCommunicator.ImportXML(openFileDialog1.FileName, "public_key"); ;
                    GenerateTdesBtn.Enabled = true;
                    RsaGeneratorBtn.Enabled = false;
                    PublicKeyValue.Text = ImportPublicKeyLabel.Text;
                    PrivateKeyValue.Text = "false";
                }
            }
            catch
            {
                MessageBox.Show("Documento invalido", "Error controlado");
            }
        }
        private void GenerateTdesBtn_Click(object sender, EventArgs e)
        {
            GenerateTdesLabel.Text = this.masterCommunicator.setTdesKeys();
            EncryptWithPublicKeyBtn.Enabled = true;
        }
        private void EncryptWithPublicKeyBtn_Click(object sender, EventArgs e)
        {
            string[] encriptedTdes = this.masterCommunicator.EncryptTdesWithPublicKey();
            string encriptedTdesLabel = "";
            foreach (string elem in encriptedTdes)
            {
                encriptedTdesLabel += elem;
            }
            EncryptWithPublicKeyLabel.Text = encriptedTdesLabel;
            ExportEncryptedTdesBtn.Enabled = true;
        }
        private void ExportEncryptedTdesBtn_Click(object sender, EventArgs e)
        {
            this.masterCommunicator.ExportXML("encrypted_tdes");
            ImportMessageBtn.Enabled = true;
        }
        private void ImportMessageBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog
                {
                    InitialDirectory = Environment.CurrentDirectory + "/xml",
                    Title = "Browse XML Files",

                    CheckFileExists = true,
                    CheckPathExists = true,

                    DefaultExt = "xml",
                    Filter = "xml files (*.xml)|*.xml",
                    FilterIndex = 2,
                    RestoreDirectory = true,

                    ReadOnlyChecked = true,
                    ShowReadOnly = true
                };
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ImportMessageLabel.Text = this.masterCommunicator.ImportXML(openFileDialog1.FileName, "message");
                    DecryptMessageBtn.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Documento invalido", "Error controlado");
            }
        }
        private void DecryptMessageBtn_Click(object sender, EventArgs e)
        {
            DecryptMessageLabel.Text = this.masterCommunicator.DecryptMessage();
        }
    }
}
