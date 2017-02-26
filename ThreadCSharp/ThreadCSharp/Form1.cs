using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormClosed += new FormClosedEventHandler(HandleFormClosed);
            InitializeComponent();
        }

        public void HandleFormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("Handle Form Closed");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("Form1 Loaded successfully");
            button1.Text = "Click Here";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Display button clicked");
            MessageBox.Show("Thanks for clicking me :)");
        }

        public void HandleForm()
        {
            this.ShowDialog();
        }
    }
}
