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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Inicial));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_compressao = new System.Windows.Forms.Button();
            this.btn_flexao = new System.Windows.Forms.Button();
            this.btn_tracao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escolha o tipo de solicitação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_compressao
            // 
            this.btn_compressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compressao.Location = new System.Drawing.Point(86, 151);
            this.btn_compressao.Name = "btn_compressao";
            this.btn_compressao.Size = new System.Drawing.Size(124, 48);
            this.btn_compressao.TabIndex = 2;
            this.btn_compressao.Text = "Compressão";
            this.btn_compressao.UseVisualStyleBackColor = true;
            // 
            // btn_flexao
            // 
            this.btn_flexao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_flexao.Location = new System.Drawing.Point(86, 229);
            this.btn_flexao.Name = "btn_flexao";
            this.btn_flexao.Size = new System.Drawing.Size(124, 48);
            this.btn_flexao.TabIndex = 3;
            this.btn_flexao.Text = "Flexão";
            this.btn_flexao.UseVisualStyleBackColor = true;
            // 
            // btn_tracao
            // 
            this.btn_tracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tracao.Location = new System.Drawing.Point(86, 73);
            this.btn_tracao.Name = "btn_tracao";
            this.btn_tracao.Size = new System.Drawing.Size(124, 48);
            this.btn_tracao.TabIndex = 4;
            this.btn_tracao.Text = "Tração";
            this.btn_tracao.UseVisualStyleBackColor = true;
            this.btn_tracao.Click += new System.EventHandler(this.button4_Click);
            // 
            // F_Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 327);
            this.Controls.Add(this.btn_tracao);
            this.Controls.Add(this.btn_flexao);
            this.Controls.Add(this.btn_compressao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfis Laminados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_compressao;
        private System.Windows.Forms.Button btn_flexao;
        private System.Windows.Forms.Button btn_tracao;
    }
}