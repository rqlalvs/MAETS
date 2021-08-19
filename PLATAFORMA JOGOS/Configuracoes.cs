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
    public partial class Configuracoes : Form
    {
        public Configuracoes()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
           Cadastro jogo = new Cadastro();
            jogo.Closed += (s, args) => this.Close();
            jogo.Show();

            this.Hide();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            this.Hide();
            criarlogin2 novologin = new criarlogin2();
            novologin.Closed += (s, args) => this.Close();
            novologin.Show();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu inicio = new Menu();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbllogin_Click(object sender, EventArgs e)
        {

        }
    }
}
