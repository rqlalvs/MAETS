namespace PLATAFORMA_JOGOS
{
    partial class Carrinho
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnpagar = new System.Windows.Forms.Button();
            this.btnremover = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.apresentacao = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apresentacao)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.pictureBox1.Location = new System.Drawing.Point(27, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(654, 57);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(804, 61);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(27, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(654, 219);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seu Carrinho de Compras";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(231, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Itens Adicionados";
            // 
            // btnpagar
            // 
            this.btnpagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(69)))));
            this.btnpagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnpagar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnpagar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnpagar.Location = new System.Drawing.Point(569, 309);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(73, 30);
            this.btnpagar.TabIndex = 21;
            this.btnpagar.Text = "Pagar";
            this.btnpagar.UseVisualStyleBackColor = false;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // btnremover
            // 
            this.btnremover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(69)))));
            this.btnremover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnremover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnremover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnremover.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnremover.Location = new System.Drawing.Point(61, 309);
            this.btnremover.Name = "btnremover";
            this.btnremover.Size = new System.Drawing.Size(87, 30);
            this.btnremover.TabIndex = 22;
            this.btnremover.Text = "Remover";
            this.btnremover.UseVisualStyleBackColor = false;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(69)))));
            this.btnvoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnvoltar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnvoltar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnvoltar.Location = new System.Drawing.Point(12, 12);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(73, 30);
            this.btnvoltar.TabIndex = 51;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // apresentacao
            // 
            this.apresentacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apresentacao.Location = new System.Drawing.Point(47, 141);
            this.apresentacao.Name = "apresentacao";
            this.apresentacao.Size = new System.Drawing.Size(615, 150);
            this.apresentacao.TabIndex = 52;
            // 
            // Carrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(710, 354);
            this.Controls.Add(this.apresentacao);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnremover);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Carrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrinho";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apresentacao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Button btnremover;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.DataGridView apresentacao;
    }
}