namespace PLATAFORMA_JOGOS
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.btnentrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsenha = new System.Windows.Forms.TextBox();
            this.btncontanova = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(56, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtlogin
            // 
            this.txtlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtlogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtlogin.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtlogin.Location = new System.Drawing.Point(112, 102);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(123, 23);
            this.txtlogin.TabIndex = 2;
            // 
            // btnentrar
            // 
            this.btnentrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(69)))));
            this.btnentrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnentrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnentrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnentrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnentrar.Location = new System.Drawing.Point(156, 147);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(79, 30);
            this.btnentrar.TabIndex = 4;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = false;
            this.btnentrar.Click += new System.EventHandler(this.btnentrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(258, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Senha";
            // 
            // txtsenha
            // 
            this.txtsenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.txtsenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtsenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtsenha.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtsenha.Location = new System.Drawing.Point(320, 98);
            this.txtsenha.Name = "txtsenha";
            this.txtsenha.Size = new System.Drawing.Size(123, 23);
            this.txtsenha.TabIndex = 7;
            this.txtsenha.UseSystemPasswordChar = true;
            this.txtsenha.TextChanged += new System.EventHandler(this.txtsenha_TextChanged);
            // 
            // btncontanova
            // 
            this.btncontanova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(72)))), ((int)(((byte)(69)))));
            this.btncontanova.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btncontanova.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btncontanova.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btncontanova.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncontanova.Location = new System.Drawing.Point(262, 147);
            this.btncontanova.Name = "btncontanova";
            this.btncontanova.Size = new System.Drawing.Size(79, 30);
            this.btncontanova.TabIndex = 10;
            this.btncontanova.Text = "Criar";
            this.btncontanova.UseVisualStyleBackColor = false;
            this.btncontanova.Click += new System.EventHandler(this.btncontanova_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(44, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(399, 39);
            this.label3.TabIndex = 55;
            this.label3.Text = "Bem Vindo(a) ao MAETS";
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Font = new System.Drawing.Font("Arial Narrow", 12.75F);
            this.btnFechar.ForeColor = System.Drawing.Color.White;
            this.btnFechar.Location = new System.Drawing.Point(463, 12);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(1);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(35, 35);
            this.btnFechar.TabIndex = 56;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(512, 204);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncontanova);
            this.Controls.Add(this.txtsenha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.txtlogin);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsenha;
        private System.Windows.Forms.Button btncontanova;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFechar;
    }
}

