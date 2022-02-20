namespace VerPerfisLaminados
{
    partial class F_DadosFlexao
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
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_lc = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_puncionamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_lc.SuspendLayout();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(70, 93);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Cancelar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(15, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(49, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "OK";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // btn_lc
            // 
            this.btn_lc.Controls.Add(this.textBox1);
            this.btn_lc.Controls.Add(this.label1);
            this.btn_lc.Controls.Add(this.label17);
            this.btn_lc.Controls.Add(this.txt_puncionamento);
            this.btn_lc.Location = new System.Drawing.Point(12, 12);
            this.btn_lc.Name = "btn_lc";
            this.btn_lc.Size = new System.Drawing.Size(159, 75);
            this.btn_lc.TabIndex = 15;
            this.btn_lc.TabStop = false;
            this.btn_lc.Text = "Coeficientes de momento";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(151, 93);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(20, 23);
            this.button5.TabIndex = 28;
            this.button5.Text = "?";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 13);
            this.label17.TabIndex = 16;
            this.label17.Text = "Cb (x)";
            // 
            // txt_puncionamento
            // 
            this.txt_puncionamento.Location = new System.Drawing.Point(21, 45);
            this.txt_puncionamento.Name = "txt_puncionamento";
            this.txt_puncionamento.Size = new System.Drawing.Size(31, 20);
            this.txt_puncionamento.TabIndex = 17;
            this.txt_puncionamento.Text = "2,0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cb (y)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 19;
            this.textBox1.Text = "2,0";
            // 
            // F_DadosFlexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn_lc);
            this.Name = "F_DadosFlexao";
            this.Text = "F_DadosFlexao";
            this.btn_lc.ResumeLayout(false);
            this.btn_lc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox btn_lc;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.TextBox txt_puncionamento;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}