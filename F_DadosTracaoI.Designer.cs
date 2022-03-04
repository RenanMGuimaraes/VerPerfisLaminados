namespace VerPerfisLaminados
{
    partial class F_DadosTracaoI
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
            this.components = new System.ComponentModel.Container();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rb_ct3 = new System.Windows.Forms.RadioButton();
            this.rb_ct2 = new System.Windows.Forms.RadioButton();
            this.rb_ct1 = new System.Windows.Forms.RadioButton();
            this.btn_lc = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_numfurosMesa = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_ac = new System.Windows.Forms.TextBox();
            this.cb_numfurosAlma = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_folgaFuro = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_lc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cb_diamparafusos = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_puncionamento = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_ac = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_ambos = new System.Windows.Forms.RadioButton();
            this.rb_mesa = new System.Windows.Forms.RadioButton();
            this.rb_alma = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox7.SuspendLayout();
            this.btn_lc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rb_ct3);
            this.groupBox7.Controls.Add(this.rb_ct2);
            this.groupBox7.Controls.Add(this.rb_ct1);
            this.groupBox7.Location = new System.Drawing.Point(12, 12);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(345, 137);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Coef. de redução da área líquida - Ct";
            // 
            // rb_ct3
            // 
            this.rb_ct3.Location = new System.Drawing.Point(6, 93);
            this.rb_ct3.MaximumSize = new System.Drawing.Size(400, 200);
            this.rb_ct3.Name = "rb_ct3";
            this.rb_ct3.Size = new System.Drawing.Size(333, 30);
            this.rb_ct3.TabIndex = 2;
            this.rb_ct3.Text = "Forças transmitidas por soldas longitudinais ou parafusos em perfis de seção aber" +
    "ta";
            this.toolTip1.SetToolTip(this.rb_ct3, "Ct = 1 - ec / lc");
            this.rb_ct3.UseVisualStyleBackColor = true;
            this.rb_ct3.CheckedChanged += new System.EventHandler(this.rb_ct3_CheckedChanged);
            // 
            // rb_ct2
            // 
            this.rb_ct2.Location = new System.Drawing.Point(6, 59);
            this.rb_ct2.MaximumSize = new System.Drawing.Size(400, 200);
            this.rb_ct2.Name = "rb_ct2";
            this.rb_ct2.Size = new System.Drawing.Size(314, 30);
            this.rb_ct2.TabIndex = 1;
            this.rb_ct2.Text = "Forças transmitadas somente por soldas transversais à solicitação";
            this.toolTip1.SetToolTip(this.rb_ct2, "Ct = Ac / Ag");
            this.rb_ct2.UseVisualStyleBackColor = true;
            this.rb_ct2.CheckedChanged += new System.EventHandler(this.rb_ct2_CheckedChanged);
            // 
            // rb_ct1
            // 
            this.rb_ct1.Checked = true;
            this.rb_ct1.Location = new System.Drawing.Point(6, 25);
            this.rb_ct1.MaximumSize = new System.Drawing.Size(400, 200);
            this.rb_ct1.Name = "rb_ct1";
            this.rb_ct1.Size = new System.Drawing.Size(333, 30);
            this.rb_ct1.TabIndex = 0;
            this.rb_ct1.TabStop = true;
            this.rb_ct1.Text = "Todos os elementos da seção estão conectados por parafusos ou soldas. Ct = 1 ";
            this.toolTip1.SetToolTip(this.rb_ct1, "Ct = 1.0");
            this.rb_ct1.UseVisualStyleBackColor = true;
            this.rb_ct1.CheckedChanged += new System.EventHandler(this.rb_ct1_CheckedChanged);
            // 
            // btn_lc
            // 
            this.btn_lc.Controls.Add(this.label1);
            this.btn_lc.Controls.Add(this.cb_numfurosMesa);
            this.btn_lc.Controls.Add(this.label20);
            this.btn_lc.Controls.Add(this.label11);
            this.btn_lc.Controls.Add(this.label19);
            this.btn_lc.Controls.Add(this.label14);
            this.btn_lc.Controls.Add(this.label21);
            this.btn_lc.Controls.Add(this.txt_ac);
            this.btn_lc.Controls.Add(this.cb_numfurosAlma);
            this.btn_lc.Controls.Add(this.label15);
            this.btn_lc.Controls.Add(this.label18);
            this.btn_lc.Controls.Add(this.txt_folgaFuro);
            this.btn_lc.Controls.Add(this.label16);
            this.btn_lc.Controls.Add(this.txt_lc);
            this.btn_lc.Controls.Add(this.label13);
            this.btn_lc.Controls.Add(this.cb_diamparafusos);
            this.btn_lc.Controls.Add(this.label17);
            this.btn_lc.Controls.Add(this.txt_puncionamento);
            this.btn_lc.Location = new System.Drawing.Point(12, 287);
            this.btn_lc.Name = "btn_lc";
            this.btn_lc.Size = new System.Drawing.Size(345, 255);
            this.btn_lc.TabIndex = 12;
            this.btn_lc.TabStop = false;
            this.btn_lc.Text = "Furos na seção transversal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Número de furos na mesa";
            // 
            // cb_numfurosMesa
            // 
            this.cb_numfurosMesa.Enabled = false;
            this.cb_numfurosMesa.FormattingEnabled = true;
            this.cb_numfurosMesa.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_numfurosMesa.Location = new System.Drawing.Point(22, 100);
            this.cb_numfurosMesa.Name = "cb_numfurosMesa";
            this.cb_numfurosMesa.Size = new System.Drawing.Size(30, 21);
            this.cb_numfurosMesa.TabIndex = 26;
            this.cb_numfurosMesa.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(177, 144);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(23, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Ac ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Número de furos na alma";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(239, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(27, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "cm2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(239, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(23, 13);
            this.label14.TabIndex = 15;
            this.label14.Text = "mm";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 204);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(19, 13);
            this.label21.TabIndex = 24;
            this.label21.Text = "Lc";
            this.toolTip1.SetToolTip(this.label21, "Comprimento efetivo da ligação. Clique no botão \"?\" para mais detalhes.");
            // 
            // txt_ac
            // 
            this.txt_ac.Enabled = false;
            this.txt_ac.Location = new System.Drawing.Point(180, 160);
            this.txt_ac.Name = "txt_ac";
            this.txt_ac.Size = new System.Drawing.Size(53, 20);
            this.txt_ac.TabIndex = 22;
            this.txt_ac.Text = "1";
            this.txt_ac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ac_KeyPress);
            // 
            // cb_numfurosAlma
            // 
            this.cb_numfurosAlma.FormattingEnabled = true;
            this.cb_numfurosAlma.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cb_numfurosAlma.Location = new System.Drawing.Point(22, 39);
            this.cb_numfurosAlma.Name = "cb_numfurosAlma";
            this.cb_numfurosAlma.Size = new System.Drawing.Size(30, 21);
            this.cb_numfurosAlma.TabIndex = 7;
            this.cb_numfurosAlma.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(177, 84);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 13;
            this.label15.Text = "Folga do furo";
            this.toolTip1.SetToolTip(this.label15, "Folga de montagem do furo");
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(81, 223);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "cm";
            // 
            // txt_folgaFuro
            // 
            this.txt_folgaFuro.Location = new System.Drawing.Point(180, 100);
            this.txt_folgaFuro.Name = "txt_folgaFuro";
            this.txt_folgaFuro.Size = new System.Drawing.Size(53, 20);
            this.txt_folgaFuro.TabIndex = 14;
            this.txt_folgaFuro.Text = "1,5";
            this.txt_folgaFuro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_folgaFuro_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(81, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 18;
            this.label16.Text = "mm";
            // 
            // txt_lc
            // 
            this.txt_lc.Enabled = false;
            this.txt_lc.Location = new System.Drawing.Point(22, 220);
            this.txt_lc.Name = "txt_lc";
            this.txt_lc.Size = new System.Drawing.Size(53, 20);
            this.txt_lc.TabIndex = 20;
            this.txt_lc.Text = "1";
            this.txt_lc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lc_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(177, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 13);
            this.label13.TabIndex = 11;
            this.label13.Text = "Diâmetro dos parafusos";
            // 
            // cb_diamparafusos
            // 
            this.cb_diamparafusos.FormattingEnabled = true;
            this.cb_diamparafusos.Items.AddRange(new object[] {
            "9,25",
            "12,5",
            "16,0",
            "19,0"});
            this.cb_diamparafusos.Location = new System.Drawing.Point(180, 39);
            this.cb_diamparafusos.Name = "cb_diamparafusos";
            this.cb_diamparafusos.Size = new System.Drawing.Size(53, 21);
            this.cb_diamparafusos.TabIndex = 12;
            this.cb_diamparafusos.Text = "12,5";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 144);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Puncionamento";
            this.toolTip1.SetToolTip(this.label17, "Perda de área no furo devido ao processo de puncionamento");
            // 
            // txt_puncionamento
            // 
            this.txt_puncionamento.Location = new System.Drawing.Point(22, 160);
            this.txt_puncionamento.Name = "txt_puncionamento";
            this.txt_puncionamento.Size = new System.Drawing.Size(53, 20);
            this.txt_puncionamento.TabIndex = 17;
            this.txt_puncionamento.Text = "2,0";
            this.txt_puncionamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_puncionamento_KeyPress);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(67, 548);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 14;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 548);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "OK";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_ac
            // 
            this.btn_ac.Location = new System.Drawing.Point(326, 548);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(28, 23);
            this.btn_ac.TabIndex = 25;
            this.btn_ac.Text = "?";
            this.btn_ac.UseVisualStyleBackColor = true;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_ambos);
            this.groupBox1.Controls.Add(this.rb_mesa);
            this.groupBox1.Controls.Add(this.rb_alma);
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 126);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ligações";
            this.toolTip1.SetToolTip(this.groupBox1, "Aplica-se no caso de perfis I ou U");
            // 
            // rb_ambos
            // 
            this.rb_ambos.Checked = true;
            this.rb_ambos.Location = new System.Drawing.Point(6, 89);
            this.rb_ambos.MaximumSize = new System.Drawing.Size(400, 200);
            this.rb_ambos.Name = "rb_ambos";
            this.rb_ambos.Size = new System.Drawing.Size(314, 30);
            this.rb_ambos.TabIndex = 2;
            this.rb_ambos.TabStop = true;
            this.rb_ambos.Text = "A ligação é feita pelas mesas (ou abas) do perfil e pela alma";
            this.rb_ambos.UseVisualStyleBackColor = true;
            this.rb_ambos.CheckedChanged += new System.EventHandler(this.rb_ambos_CheckedChanged);
            // 
            // rb_mesa
            // 
            this.rb_mesa.Location = new System.Drawing.Point(6, 53);
            this.rb_mesa.MaximumSize = new System.Drawing.Size(400, 200);
            this.rb_mesa.Name = "rb_mesa";
            this.rb_mesa.Size = new System.Drawing.Size(295, 30);
            this.rb_mesa.TabIndex = 1;
            this.rb_mesa.Text = "A ligação é feita pelas mesas (ou abas) do perfil";
            this.rb_mesa.UseVisualStyleBackColor = true;
            this.rb_mesa.CheckedChanged += new System.EventHandler(this.rb_mesa_CheckedChanged);
            // 
            // rb_alma
            // 
            this.rb_alma.Location = new System.Drawing.Point(6, 19);
            this.rb_alma.MaximumSize = new System.Drawing.Size(400, 200);
            this.rb_alma.Name = "rb_alma";
            this.rb_alma.Size = new System.Drawing.Size(314, 30);
            this.rb_alma.TabIndex = 0;
            this.rb_alma.Text = "A ligação é feita pela alma do perfil";
            this.rb_alma.UseVisualStyleBackColor = true;
            this.rb_alma.CheckedChanged += new System.EventHandler(this.rb_alma_CheckedChanged);
            // 
            // F_DadosTracaoI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 600);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_lc);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.btn_ac);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_DadosTracaoI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propriedades para tração";
            this.Load += new System.EventHandler(this.F_DadosTracao_Load);
            this.groupBox7.ResumeLayout(false);
            this.btn_lc.ResumeLayout(false);
            this.btn_lc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton rb_ct3;
        private System.Windows.Forms.RadioButton rb_ct2;
        private System.Windows.Forms.RadioButton rb_ct1;
        private System.Windows.Forms.GroupBox btn_lc;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txt_ac;
        private System.Windows.Forms.ComboBox cb_numfurosAlma;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txt_folgaFuro;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_lc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_diamparafusos;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txt_puncionamento;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_mesa;
        private System.Windows.Forms.RadioButton rb_alma;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rb_ambos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_numfurosMesa;
    }
}