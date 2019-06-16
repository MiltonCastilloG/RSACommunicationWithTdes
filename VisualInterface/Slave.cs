using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void RsaGeneratorBtn_Click(object sender, EventArgs e)
        {
            this.slaveCommunicator.GeneratePublicPrivateKey();
            PublicKeyValue.Text = this.slaveCommunicator.getPublicKey();
            PrivateKeyValue.Text = this.slaveCommunicator.getPrivateKey();
        }
        private void ExportPublicKeyBtn_Click(object sender, EventArgs e)
        {
            this.slaveCommunicator.ExportXML("public_key");
        }
        private void ImportTdesXmlBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\Users\Yo\Desktop\Studies\Cryptografia\RSACommunicationWithTdes\xmls",
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
                ImportTdesXmlLabel.Text = this.slaveCommunicator.ImportXML(openFileDialog1.FileName, "encrypted_tdes");
        }
        private void DecryptTdesBtn_Click(object sender, EventArgs e)
        {
            DecryptTdesLabel.Text = this.slaveCommunicator.DecryptTdesKey();
        }
        private void EncryptMessageBtn_Click(object sender, EventArgs e)
        {
            EncryptMessageLabel.Text = slaveCommunicator.EncryptWithTdes(MessageTb.Text);
        }
        private void ExportMessageTdesBtn_Click(object sender, EventArgs e)
        {
            slaveCommunicator.ExportXML("message");
        }
    }
}
