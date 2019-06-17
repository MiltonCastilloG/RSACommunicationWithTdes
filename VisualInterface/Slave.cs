using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Communicators;

namespace VisualInterface
{
    public partial class Slave : Form
    {
        SlaveCommunicator slaveCommunicator;
        public Slave()
        {
            slaveCommunicator = new SlaveCommunicator();
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            foreach (var scrn in Screen.AllScreens)
            {
                if (scrn.Bounds.Contains(this.Location))
                {
                    this.Location = new Point(scrn.Bounds.Left+100, scrn.Bounds.Top);
                    return;
                }
            }
        }
        private void RsaGeneratorBtn_Click(object sender, EventArgs e)
        {
            this.slaveCommunicator.GeneratePublicPrivateKey();
            PublicKeyValue.Text = this.slaveCommunicator.getPublicKey();
            PrivateKeyValue.Text = this.slaveCommunicator.getPrivateKey();
            ExportPublicKeyBtn.Enabled = true;
        }
        private void ExportPublicKeyBtn_Click(object sender, EventArgs e)
        {
            this.slaveCommunicator.ExportXML("public_key");
            ImportTdesXmlBtn.Enabled = true;
        }
        private void ImportTdesXmlBtn_Click(object sender, EventArgs e)
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
                    ImportTdesXmlLabel.Text = this.slaveCommunicator.ImportXML(openFileDialog1.FileName, "encrypted_tdes");
                    DecryptTdesBtn.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Documento invalido", "Error controlado");
            }
        }
        private void DecryptTdesBtn_Click(object sender, EventArgs e)
        {
            string labelText = this.slaveCommunicator.DecryptTdesKey();
            this.slaveCommunicator.setTdesKey();
            this.slaveCommunicator.setTdesIv();
            DecryptTdesLabel.Text = labelText;
            EncryptMessageBtn.Enabled = true;
        }
        private void EncryptMessageBtn_Click(object sender, EventArgs e)
        {
            EncryptMessageLabel.Text = slaveCommunicator.EncryptWithTdes(MessageTb.Text);
            ExportMessageTdesBtn.Enabled = true;
        }
        private void ExportMessageTdesBtn_Click(object sender, EventArgs e)
        {
            slaveCommunicator.ExportXML("message");
        }
    }
}
