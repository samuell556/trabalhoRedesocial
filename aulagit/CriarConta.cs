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
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void info_click(object sender, EventArgs e)
        {
            MessageBox.Show("Regras de criação conta" +
                "1. A palavra passe deve conter mais de 8 caracteres" +
                "2.não pode haver dois ou mais utilizadores com o mesmo nome" +
                "3.a palavra passe não pode ter letras ou simbolos ");
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
