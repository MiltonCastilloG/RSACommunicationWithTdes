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
        SlaveCommunicator slaveCommunicator = new SlaveCommunicator();
        public Slave()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RsaGeneratorBtn_Click(object sender, EventArgs e)
        {
            slaveCommunicator.GeneratePublicPrivateKey();
            PublicKeyValue.Text = slaveCommunicator.getPublicKey();
            PrivateKeyValue.Text = slaveCommunicator.getPrivateKey();
        }
        private void ExportPublicKeyBtn_Click(object sender, EventArgs e)
        {
            slaveCommunicator.ExportXML("PublicKey");
        }
        private void ImportTdesXmlBtn_Click(object sender, EventArgs e)
        {

        }
        private void DecryptTdesBtn_Click(object sender, EventArgs e)
        {

        }
        private void EncryptMessageBtn_Click(object sender, EventArgs e)
        {

        }
        private void ExportMessageTdesBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
