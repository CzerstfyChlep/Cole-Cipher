using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading;


namespace ColeCipher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();            
        }
        
    private void ConnectButton_Click(object sender, EventArgs e)
        {
         
            MessageBox.Show("Connected!", "Connected!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(IPBox.Text, 2055);
            Stream s = client.GetStream();
            StreamReader sr = new StreamReader(s);
            StreamWriter sw = new StreamWriter(s);
            sw.AutoFlush = true;
            sw.WriteLine("exit");
            sr.ReadLine();
            client.Close();
            this.Close();
        }

        private void CodeButton_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(IPBox.Text, 2055);
            Stream s = client.GetStream();
            StreamReader sr = new StreamReader(s);
            StreamWriter sw = new StreamWriter(s);
            sw.AutoFlush = true;
            sw.WriteLine("code");
            sw.WriteLine(InputBox.Text);
            OutputBox.Text = sr.ReadLine();
            client.Close();
        }

        private void DecodeButton_Click(object sender, EventArgs e)
        {
            TcpClient client = new TcpClient(IPBox.Text, 2055);
            Stream s = client.GetStream();
            StreamReader sr = new StreamReader(s);
            StreamWriter sw = new StreamWriter(s);
            sw.AutoFlush = true;
            sw.WriteLine("decode");
            sw.WriteLine(InputBox.Text);
            OutputBox.Text = sr.ReadLine();
            client.Close();
        }

      
    }
}
