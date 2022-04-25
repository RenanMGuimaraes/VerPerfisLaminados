namespace VerPerfisLaminados
{
    partial class F_Prop
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
            this.txt_prop = new System.Windows.Forms.TextBox();
            this.pct_perfil = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct_perfil)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Propriedades Geométricas do Perfil";
            // 
            // txt_prop
            // 
            this.txt_prop.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prop.Location = new System.Drawing.Point(12, 34);
            this.txt_prop.Multiline = true;
            this.txt_prop.Name = "txt_prop";
            this.txt_prop.ReadOnly = true;
            this.txt_prop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_prop.Size = new System.Drawing.Size(260, 429);
            this.txt_prop.TabIndex = 2;
            // 
            // pct_perfil
            // 
            this.pct_perfil.BackgroundImage = global::VerPerfisLaminados.Properties.Resources.Prop_i;
            this.pct_perfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pct_perfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pct_perfil.Location = new System.Drawing.Point(278, 34);
            this.pct_perfil.Name = "pct_perfil";
            this.pct_perfil.Size = new System.Drawing.Size(248, 306);
            this.pct_perfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_perfil.TabIndex = 15;
            this.pct_perfil.TabStop = false;
            // 
            // F_Prop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 474);
            this.Controls.Add(this.pct_perfil);
            this.Controls.Add(this.txt_prop);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Prop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_Prop";
            ((System.ComponentModel.ISupportInitialize)(this.pct_perfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_prop;
        private System.Windows.Forms.PictureBox pct_perfil;
    }
}