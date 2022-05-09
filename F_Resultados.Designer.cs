namespace VerPerfisLaminados
{
    partial class F_ResComp
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
            this.txt_memorial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_memorial
            // 
            this.txt_memorial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_memorial.Location = new System.Drawing.Point(0, 0);
            this.txt_memorial.Multiline = true;
            this.txt_memorial.Name = "txt_memorial";
            this.txt_memorial.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txt_memorial.Size = new System.Drawing.Size(1125, 748);
            this.txt_memorial.TabIndex = 0;
            // 
            // F_ResComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 747);
            this.Controls.Add(this.txt_memorial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_ResComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memorial de Cálculo - Compressão";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_memorial;
    }
}