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
    public partial class Master : Form
    {
        MasterCommunicator masterCommunicator;

        public Master()
        {
            masterCommunicator = new MasterCommunicator();
            InitializeComponent();
            Slave master = new Slave();
            master.Show();
        }
        private void ImportPublicKeyBtn_Click(object sender, EventArgs e)
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
            {
                ImportPublicKeyLabel.Text = this.masterCommunicator.ImportXML(openFileDialog1.FileName, "public_key"); ;

            }
        }
        private void GenerateTdesBtn_Click(object sender, EventArgs e)
        {
            GenerateTdesLabel.Text = this.masterCommunicator.setTdesKeys();
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
        }
        private void ExportEncryptedTdesBtn_Click(object sender, EventArgs e)
        {
            this.masterCommunicator.ExportXML("encrypted_tdes");
        }
        private void ImportMessageBtn_Click(object sender, EventArgs e)
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
                ImportMessageLabel.Text = this.masterCommunicator.ImportXML(openFileDialog1.FileName, "message");
        }
        private void DecryptMessageBtn_Click(object sender, EventArgs e)
        {
            DecryptMessageLabel.Text = this.masterCommunicator.DecryptMessage();
        }
        private void RsaGeneratorBtn_Click(object sender, EventArgs e)
        {

        }
        
    }
}
