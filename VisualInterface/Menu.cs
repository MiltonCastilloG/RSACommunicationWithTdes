using System;
using System.IO;
using System.Windows.Forms;

namespace VisualInterface
{
    public partial class Menu : Form
    {
        public Menu()
        {
            DirectoryInfo di = Directory.CreateDirectory(Environment.CurrentDirectory + "/xml");
            MessageBox.Show("Todos tus archivos se guardaran en:\n"+ Environment.CurrentDirectory + @"\xml", "Informacion de uso");
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SlaveBtn_Click(object sender, EventArgs e)
        {
            SlaveBtn.Enabled = false;
            Slave slave = new Slave();
            slave.FormClosed += new FormClosedEventHandler(Slave_Closed);
            slave.Show();
        }

        private void MasterBtn_Click(object sender, EventArgs e)
        {
            MasterBtn.Enabled = false;
            Master master = new Master();
            master.FormClosed += new FormClosedEventHandler(Master_Closed);
            master.Show();
        }
        public void Slave_Closed(object sender, FormClosedEventArgs e)
        {
            SlaveBtn.Enabled = true;
        }
        public void Master_Closed(object sender, FormClosedEventArgs e)
        {
            MasterBtn.Enabled = true;
        }
    }
}
