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
    public partial class biblio : Form
    {
        public biblio()
        {
            InitializeComponent();
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu inicio = new Menu();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }
    }
}
