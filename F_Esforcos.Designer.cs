namespace VerPerfisLaminados
{
    partial class F_Esforcos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_compressao = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_momy = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_cortante = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_momx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_tracao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txt_compressao);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txt_momy);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_cortante);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_momx);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_tracao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 248);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Esforços solicitantes";
            this.toolTip1.SetToolTip(this.groupBox1, "Entrar com valores positivos em todos os campos");
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(75, 86);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(21, 13);
            this.label23.TabIndex = 22;
            this.label23.Text = "kN";
            // 
            // txt_compressao
            // 
            this.txt_compressao.Enabled = false;
            this.txt_compressao.Location = new System.Drawing.Point(16, 83);
            this.txt_compressao.Name = "txt_compressao";
            this.txt_compressao.Size = new System.Drawing.Size(53, 20);
            this.txt_compressao.TabIndex = 21;
            this.txt_compressao.Text = "0";
            this.txt_compressao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_compressao_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 67);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(88, 13);
            this.label24.TabIndex = 20;
            this.label24.Text = "Compressão (Nd)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(75, 174);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 19;
            this.label17.Text = "kN.m";
            // 
            // txt_momy
            // 
            this.txt_momy.Enabled = false;
            this.txt_momy.Location = new System.Drawing.Point(16, 171);
            this.txt_momy.Name = "txt_momy";
            this.txt_momy.Size = new System.Drawing.Size(53, 20);
            this.txt_momy.TabIndex = 18;
            this.txt_momy.Text = "0";
            this.txt_momy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_momy_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 155);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(136, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Momento Fletor em Y (Mdy)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(75, 218);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 16;
            this.label13.Text = "kN";
            // 
            // txt_cortante
            // 
            this.txt_cortante.Enabled = false;
            this.txt_cortante.Location = new System.Drawing.Point(16, 215);
            this.txt_cortante.Name = "txt_cortante";
            this.txt_cortante.Size = new System.Drawing.Size(53, 20);
            this.txt_cortante.TabIndex = 15;
            this.txt_cortante.Text = "0";
            this.txt_cortante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_v_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 199);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Força Cortante (Vd)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "kN.m";
            // 
            // txt_momx
            // 
            this.txt_momx.Enabled = false;
            this.txt_momx.Location = new System.Drawing.Point(16, 127);
            this.txt_momx.Name = "txt_momx";
            this.txt_momx.Size = new System.Drawing.Size(53, 20);
            this.txt_momx.TabIndex = 12;
            this.txt_momx.Text = "0";
            this.txt_momx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_momx_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Momento Fletor em X (Mdx)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "kN";
            // 
            // txt_tracao
            // 
            this.txt_tracao.Location = new System.Drawing.Point(16, 39);
            this.txt_tracao.Name = "txt_tracao";
            this.txt_tracao.Size = new System.Drawing.Size(53, 20);
            this.txt_tracao.TabIndex = 2;
            this.txt_tracao.Text = "0";
            this.txt_tracao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tracao_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tração (Nd)";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(66, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(11, 266);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(49, 23);
            this.btn_ok.TabIndex = 15;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // F_Esforcos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(195, 298);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Esforcos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_compressao;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_momy;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_cortante;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_momx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_tracao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button button1;
    }
}