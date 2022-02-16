namespace VerPerfisLaminados
{
    partial class F_Inicial
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
            this.btn_tracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o tipo de esforço solicitante";
            // 
            // btn_tracao
            // 
            this.btn_tracao.Location = new System.Drawing.Point(94, 54);
            this.btn_tracao.Name = "btn_tracao";
            this.btn_tracao.Size = new System.Drawing.Size(75, 23);
            this.btn_tracao.TabIndex = 1;
            this.btn_tracao.Text = "Tração";
            this.btn_tracao.UseVisualStyleBackColor = true;
            this.btn_tracao.Click += new System.EventHandler(this.btn_tracao_Click);
            // 
            // F_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_tracao);
            this.Controls.Add(this.label1);
            this.Name = "F_Inicial";
            this.Text = "F_Inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_tracao;
    }
}