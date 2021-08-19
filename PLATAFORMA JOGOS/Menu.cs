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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnconfig_Click(object sender, EventArgs e)
        {
          this.Hide();
            Configuracoes conf = new Configuracoes();
            conf.Closed += (s, args) => this.Close();
            conf.Show();

        }

        private void btncarr_Click(object sender, EventArgs e)
        {
            this.Hide();
            Carrinho carro = new Carrinho();
            carro.Closed += (s, args) => this.Close();
           carro.Show();
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnbiblo_Click(object sender, EventArgs e)
        {
            this.Hide();
            biblio carro = new biblio();
            carro.Closed += (s, args) => this.Close();
            carro.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
