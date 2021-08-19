using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PLATAFORMA_JOGOS
{
    public partial class Cadastro : Form
    {
        AcessoBD dbCentroEsportivo = new AcessoBD();

        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            string strComando = "EXEC SP_Jogo '" + txtnomeusu.Text + "', " + txtDescri.Text + ", " + txtpreco.Text + ",  '" + txtClass.Text + "', '" + txtEquip.Text + "';";
            AcessoBD dbMassaCentrale = new AcessoBD();
            SqlDataReader dr = null;
            try
            {
                if (txtnomeusu.Text == "" ||
                txtDescri.Text == "" ||
                txtpreco.Text == "" ||
                txtClass.Text == "" ||
                txtEquip.Text == "")
                {
                    MessageBox.Show("Existem valores nulos!", "Valores inválidos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlCommand Comando = new SqlCommand(strComando);
                    Comando.Connection = dbMassaCentrale.Entrar();
                    Comando.ExecuteNonQuery();
                    MessageBox.Show("Salvo com seucesso!", "Salvo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnomeusu.Text = "";
                    txtDescri.Text = "";
                    txtpreco.Text = "";
                    txtClass.Text = "";
                    txtEquip.Text = "";
                }
                if (MessageBox.Show("Deseja continuar cadastrando ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    this.Close();
                    Menu novaform = new Menu();
                    novaform.Show();
                }
            }
            finally
            {
                if (dr != null)
                {
                    dr.Close();
                }
                dbMassaCentrale.Sair();

            }

            this.Hide();
            Menu inicio = new Menu();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }
        string a;
        private void pictblogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnfoto_Click(object sender, EventArgs e)
        {
            this.ofd1.Multiselect = true;
            this.ofd1.Title = "Selecionar Fotos";
            ofd1.InitialDirectory = @"C:\";
            //filtra para exibir somente arquivos de imagens
            ofd1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd1.CheckFileExists = true;
            ofd1.CheckPathExists = true;
            ofd1.FilterIndex = 2;
            ofd1.RestoreDirectory = true;
            ofd1.ReadOnlyChecked = true;
            ofd1.ShowReadOnly = true;
            DialogResult dr = this.ofd1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach (String arquivo in ofd1.FileNames)
                {
                    a += arquivo;
                    // cria um PictureBox
                    Image Imagem = Image.FromFile(arquivo);
                    pictblogin.SizeMode = PictureBoxSizeMode.StretchImage;
                    //para exibir as imagens em tamanho natural 
                    //descomente as linhas abaixo e comente as duas seguintes
                    //pb.Height = loadedImage.Height;
                    //pb.Width = loadedImage.Width;
                    pictblogin.Height = 162;
                    pictblogin.Width = 172;
                    //atribui a imagem ao PictureBox - pb
                    pictblogin.Image = Imagem;
                }
            }
        }

        private void rblivre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb18_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu inicio = new Menu();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
