namespace VerPerfisLaminados
{
    partial class F_principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_principal));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_duploL = new System.Windows.Forms.RadioButton();
            this.rb_duploU = new System.Windows.Forms.RadioButton();
            this.rb_cantoneira = new System.Windows.Forms.RadioButton();
            this.rb_perfilU = new System.Windows.Forms.RadioButton();
            this.rb_perfilI = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_perfis = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_prop = new System.Windows.Forms.TextBox();
            this.btn_selecionar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabComb = new System.Windows.Forms.TabPage();
            this.tabTracao = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabCompressao = new System.Windows.Forms.TabPage();
            this.tabFlexao = new System.Windows.Forms.TabPage();
            this.tabCisalhamento = new System.Windows.Forms.TabPage();
            this.tabEstabilidade = new System.Windows.Forms.TabPage();
            this.pct_perfil = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabTracao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_perfil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lb_perfis);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.btn_selecionar);
            this.groupBox4.Location = new System.Drawing.Point(12, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(377, 526);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pct_perfil);
            this.groupBox5.Controls.Add(this.rb_duploL);
            this.groupBox5.Controls.Add(this.pictureBox5);
            this.groupBox5.Controls.Add(this.rb_duploU);
            this.groupBox5.Controls.Add(this.pictureBox4);
            this.groupBox5.Controls.Add(this.rb_cantoneira);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Controls.Add(this.pictureBox3);
            this.groupBox5.Controls.Add(this.pictureBox2);
            this.groupBox5.Controls.Add(this.rb_perfilU);
            this.groupBox5.Controls.Add(this.rb_perfilI);
            this.groupBox5.Location = new System.Drawing.Point(8, 265);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(348, 255);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            // 
            // rb_duploL
            // 
            this.rb_duploL.AutoSize = true;
            this.rb_duploL.Location = new System.Drawing.Point(45, 204);
            this.rb_duploL.Name = "rb_duploL";
            this.rb_duploL.Size = new System.Drawing.Size(107, 17);
            this.rb_duploL.TabIndex = 13;
            this.rb_duploL.Text = "Dupla Cantoneira";
            this.rb_duploL.UseVisualStyleBackColor = true;
            // 
            // rb_duploU
            // 
            this.rb_duploU.AutoSize = true;
            this.rb_duploU.Location = new System.Drawing.Point(45, 160);
            this.rb_duploU.Name = "rb_duploU";
            this.rb_duploU.Size = new System.Drawing.Size(64, 17);
            this.rb_duploU.TabIndex = 11;
            this.rb_duploU.Text = "Duplo U";
            this.rb_duploU.UseVisualStyleBackColor = true;
            // 
            // rb_cantoneira
            // 
            this.rb_cantoneira.AutoSize = true;
            this.rb_cantoneira.Location = new System.Drawing.Point(45, 117);
            this.rb_cantoneira.Name = "rb_cantoneira";
            this.rb_cantoneira.Size = new System.Drawing.Size(76, 17);
            this.rb_cantoneira.TabIndex = 9;
            this.rb_cantoneira.Text = "Cantoneira";
            this.rb_cantoneira.UseVisualStyleBackColor = true;
            // 
            // rb_perfilU
            // 
            this.rb_perfilU.AutoSize = true;
            this.rb_perfilU.Location = new System.Drawing.Point(45, 72);
            this.rb_perfilU.Name = "rb_perfilU";
            this.rb_perfilU.Size = new System.Drawing.Size(59, 17);
            this.rb_perfilU.TabIndex = 7;
            this.rb_perfilU.Text = "Perfil U";
            this.rb_perfilU.UseVisualStyleBackColor = true;
            // 
            // rb_perfilI
            // 
            this.rb_perfilI.AutoSize = true;
            this.rb_perfilI.Checked = true;
            this.rb_perfilI.Location = new System.Drawing.Point(45, 28);
            this.rb_perfilI.Name = "rb_perfilI";
            this.rb_perfilI.Size = new System.Drawing.Size(54, 17);
            this.rb_perfilI.TabIndex = 6;
            this.rb_perfilI.TabStop = true;
            this.rb_perfilI.Text = "Perfil I";
            this.rb_perfilI.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o perfil";
            // 
            // lb_perfis
            // 
            this.lb_perfis.FormattingEnabled = true;
            this.lb_perfis.Items.AddRange(new object[] {
            "W 150 x 13,0",
            "W 150 x 18,0",
            "W 150 x 22,5 (H)",
            "W 150 x 24,0",
            "W 150 x 29,8 (H)",
            "W 150 x 37,1 (H)",
            "W 200 x 15,0",
            "W 200 x 19,3",
            "W 200 x 22,5",
            "W 200 x 26,6",
            "W 200 x 31,3",
            "W 200 x 35,9 (H)",
            "W 200 x 41,7 (H)",
            "W 200 x 46,1 (H)",
            "W 200 x 52,0 (H)",
            "HP 200 x 53,0 (H)",
            "W 200 x 59,0 (H)",
            "W 200 x 71,0 (H)",
            "W 200 x 86,0 (H)",
            "W 250 x 17,9",
            "W 250 x 22,3",
            "W 250 x 25,3",
            "W 250 x 28,4",
            "W 250 x 32,7",
            "W 250 x 38,5",
            "W 250 x 44,8",
            "HP 250 x 62,0 (H)",
            "W 250 x 73,0 (H)",
            "W 250 x 80,0 (H)",
            "HP 250 x 85,0 (H)",
            "W 250 x 89,0 (H)",
            "W 250 x 101,0 (H)",
            "W 250 x 115,0 (H)",
            "W 310 x 21,0",
            "W 310 x 23,8",
            "W 310 x 28,3",
            "W 310 x 32,7",
            "W 310 x 38,7",
            "W 310 x 44,5",
            "W 310 x 52,0",
            "HP 310 x 79,0 (H)",
            "HP 310 x 93,0 (H)",
            "W 310 x 97,0 (H)",
            "W 310 x 107,0 (H)",
            "HP 310 x 110,0 (H)",
            "W 310 x 117,0 (H)",
            "HP 310 x 125,0 (H)",
            "W 360 x 32,9",
            "W 360 x 39,0",
            "W 360 x 44,6",
            "W 360 x 51,0",
            "W 360 x 58",
            "W 360 x 64,0",
            "W 360 x 72,0",
            "W 360 x 79,0",
            "W 360 x 91,0 (H)",
            "W 360 x 101,0 (H)",
            "W 360 x 110,0 (H)",
            "W 360 x 122,0 (H)",
            "W 410 x 38,8",
            "W 410 x 46,1",
            "W 410 x 53,0",
            "W 410 x 60,0",
            "W 410 x 67,0",
            "W 410 x 75,0",
            "W 410 x 85,0",
            "W 460 x 52,0",
            "W 460 x 60,0",
            "W 460 x 68,0",
            "W 460 x 74,0",
            "W 460 x 82,0",
            "W 460 x 89,0",
            "W 460 x 97,0",
            "W 460 x 106,0",
            "W 530 x 66,0",
            "W 530 x 72,0",
            "W 530 x 74,0",
            "W 530 x 82,0",
            "W 530 x 85,0",
            "W 530 x 92,0",
            "W 530 x 101,0",
            "W 530 x 109,0",
            "W 610 x 82,0",
            "W 610 x 92,0",
            "W 610 x 101,0",
            "W 610 x 113,0",
            "W 610 x 125,0",
            "W 610 x 140,0",
            "W 610 x 155,0",
            "W 610 x 174,0",
            "W 610 x 217,0"});
            this.lb_perfis.Location = new System.Drawing.Point(8, 32);
            this.lb_perfis.Name = "lb_perfis";
            this.lb_perfis.Size = new System.Drawing.Size(133, 186);
            this.lb_perfis.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_prop);
            this.groupBox2.Location = new System.Drawing.Point(155, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(201, 202);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Propriedades Geométricas da seção";
            // 
            // txt_prop
            // 
            this.txt_prop.Location = new System.Drawing.Point(6, 16);
            this.txt_prop.Multiline = true;
            this.txt_prop.Name = "txt_prop";
            this.txt_prop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_prop.Size = new System.Drawing.Size(189, 186);
            this.txt_prop.TabIndex = 0;
            // 
            // btn_selecionar
            // 
            this.btn_selecionar.Location = new System.Drawing.Point(37, 224);
            this.btn_selecionar.Name = "btn_selecionar";
            this.btn_selecionar.Size = new System.Drawing.Size(75, 23);
            this.btn_selecionar.TabIndex = 3;
            this.btn_selecionar.Text = "Selecionar";
            this.btn_selecionar.UseVisualStyleBackColor = true;
            this.btn_selecionar.Click += new System.EventHandler(this.btn_selecionar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabComb);
            this.tabControl1.Controls.Add(this.tabTracao);
            this.tabControl1.Controls.Add(this.tabCompressao);
            this.tabControl1.Controls.Add(this.tabFlexao);
            this.tabControl1.Controls.Add(this.tabCisalhamento);
            this.tabControl1.Controls.Add(this.tabEstabilidade);
            this.tabControl1.Location = new System.Drawing.Point(395, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(731, 526);
            this.tabControl1.TabIndex = 3;
            // 
            // tabComb
            // 
            this.tabComb.Location = new System.Drawing.Point(4, 22);
            this.tabComb.Name = "tabComb";
            this.tabComb.Padding = new System.Windows.Forms.Padding(3);
            this.tabComb.Size = new System.Drawing.Size(723, 500);
            this.tabComb.TabIndex = 6;
            this.tabComb.Text = "Combinações";
            this.tabComb.UseVisualStyleBackColor = true;
            // 
            // tabTracao
            // 
            this.tabTracao.Controls.Add(this.groupBox3);
            this.tabTracao.Controls.Add(this.groupBox1);
            this.tabTracao.Location = new System.Drawing.Point(4, 22);
            this.tabTracao.Name = "tabTracao";
            this.tabTracao.Padding = new System.Windows.Forms.Padding(3);
            this.tabTracao.Size = new System.Drawing.Size(723, 500);
            this.tabTracao.TabIndex = 1;
            this.tabTracao.Text = "Tração";
            this.tabTracao.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(311, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 226);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ELS";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ELU - Esforço Solicitante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "kN";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Força Solicitante";
            // 
            // tabCompressao
            // 
            this.tabCompressao.Location = new System.Drawing.Point(4, 22);
            this.tabCompressao.Name = "tabCompressao";
            this.tabCompressao.Size = new System.Drawing.Size(723, 500);
            this.tabCompressao.TabIndex = 2;
            this.tabCompressao.Text = "Compressão";
            this.tabCompressao.UseVisualStyleBackColor = true;
            // 
            // tabFlexao
            // 
            this.tabFlexao.Location = new System.Drawing.Point(4, 22);
            this.tabFlexao.Name = "tabFlexao";
            this.tabFlexao.Padding = new System.Windows.Forms.Padding(3);
            this.tabFlexao.Size = new System.Drawing.Size(723, 500);
            this.tabFlexao.TabIndex = 3;
            this.tabFlexao.Text = "Flexão";
            this.tabFlexao.UseVisualStyleBackColor = true;
            // 
            // tabCisalhamento
            // 
            this.tabCisalhamento.Location = new System.Drawing.Point(4, 22);
            this.tabCisalhamento.Name = "tabCisalhamento";
            this.tabCisalhamento.Size = new System.Drawing.Size(723, 500);
            this.tabCisalhamento.TabIndex = 4;
            this.tabCisalhamento.Text = "Cisalhamento";
            this.tabCisalhamento.UseVisualStyleBackColor = true;
            // 
            // tabEstabilidade
            // 
            this.tabEstabilidade.Location = new System.Drawing.Point(4, 22);
            this.tabEstabilidade.Name = "tabEstabilidade";
            this.tabEstabilidade.Size = new System.Drawing.Size(723, 500);
            this.tabEstabilidade.TabIndex = 5;
            this.tabEstabilidade.Text = "Estabilidade Global";
            this.tabEstabilidade.UseVisualStyleBackColor = true;
            // 
            // pct_perfil
            // 
            this.pct_perfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pct_perfil.Image = global::VerPerfisLaminados.Properties.Resources.Prop_i;
            this.pct_perfil.Location = new System.Drawing.Point(170, 19);
            this.pct_perfil.Name = "pct_perfil";
            this.pct_perfil.Size = new System.Drawing.Size(161, 223);
            this.pct_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_perfil.TabIndex = 14;
            this.pct_perfil.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::VerPerfisLaminados.Properties.Resources.Duplo_L;
            this.pictureBox5.Location = new System.Drawing.Point(7, 195);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(33, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VerPerfisLaminados.Properties.Resources.Duplo_C;
            this.pictureBox4.Location = new System.Drawing.Point(7, 151);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(33, 36);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VerPerfisLaminados.Properties.Resources.I;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VerPerfisLaminados.Properties.Resources.L;
            this.pictureBox3.Location = new System.Drawing.Point(6, 107);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(33, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VerPerfisLaminados.Properties.Resources.C;
            this.pictureBox2.Location = new System.Drawing.Point(6, 63);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // F_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 640);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_principal";
            this.Text = "Verificador de Perfis Laminados";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabTracao.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pct_perfil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rb_duploL;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.RadioButton rb_duploU;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.RadioButton rb_cantoneira;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton rb_perfilU;
        private System.Windows.Forms.RadioButton rb_perfilI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lb_perfis;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_prop;
        private System.Windows.Forms.Button btn_selecionar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabComb;
        private System.Windows.Forms.TabPage tabTracao;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabCompressao;
        private System.Windows.Forms.TabPage tabFlexao;
        private System.Windows.Forms.TabPage tabCisalhamento;
        private System.Windows.Forms.TabPage tabEstabilidade;
        private System.Windows.Forms.PictureBox pct_perfil;
    }
}

