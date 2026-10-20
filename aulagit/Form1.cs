using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aulagit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Criarconta_click(object sender, EventArgs e)
        {
           CriarConta f1 = new CriarConta();
            f1.Show();

            this.Close();
        }
    }
}
