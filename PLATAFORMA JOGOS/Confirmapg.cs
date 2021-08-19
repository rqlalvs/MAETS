using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLATAFORMA_JOGOS
{
    public partial class Confirmapg : Form
    {
        public Confirmapg()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {

            this.Hide();
            Carrinho carro = new Carrinho();
            carro.Closed += (s, args) => this.Close();
            carro.Show();

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {

        }
    }
}
