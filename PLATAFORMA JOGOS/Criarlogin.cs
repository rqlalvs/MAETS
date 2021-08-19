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
    public partial class Criarlogin : Form
    {
        public Criarlogin()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }
        string a;
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
                    pictblogin.Width =   172;
                    //atribui a imagem ao PictureBox - pb
                    pictblogin.Image = Imagem;
                }
            }
        }
            public void OpenAndSelectPath(string path)
            {
                bool isfile = System.IO.File.Exists(path);
                if (isfile)
                {
                    string argument = @"/select, " + path;
                    System.Diagnostics.Process.Start("explorer.exe", argument);
                }
                else
                {
                    bool isfolder = System.IO.Directory.Exists(path);
                    if (isfolder)
                    {
                        string argument = @"/select, " + path;
                        System.Diagnostics.Process.Start("explorer.exe", argument);
                    }
                }
            }

            private void pictblogin_Click(object sender, EventArgs e)
            {

            }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 inicio = new Form1();
            inicio.Closed += (s, args) => this.Close();
            inicio.Show();
        }
    }
    }
