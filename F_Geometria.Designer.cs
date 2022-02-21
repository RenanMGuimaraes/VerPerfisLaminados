namespace VerPerfisLaminados
{
    partial class F_Geometria
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txt_z = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txt_z);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.txt_y);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_x);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 241);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comprimentos do perfil";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 188);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(152, 13);
            this.label21.TabIndex = 14;
            this.label21.Text = "Comprimento livre à torção (Lz)";
            // 
            // txt_z
            // 
            this.txt_z.Location = new System.Drawing.Point(9, 203);
            this.txt_z.Name = "txt_z";
            this.txt_z.Size = new System.Drawing.Size(53, 20);
            this.txt_z.TabIndex = 15;
            this.txt_z.Text = "0";
            this.txt_z.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_z_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(68, 206);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(21, 13);
            this.label22.TabIndex = 16;
            this.label22.Text = "cm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Comprimento livre em torno de y (Ly)";
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(9, 123);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(53, 20);
            this.txt_y.TabIndex = 12;
            this.txt_y.Text = "0";
            this.txt_y.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_y_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(68, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(21, 13);
            this.label20.TabIndex = 13;
            this.label20.Text = "cm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(177, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Comprimento livre em torno de x (Lx)";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(9, 43);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(53, 20);
            this.txt_x.TabIndex = 9;
            this.txt_x.Text = "0";
            this.txt_x.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_x_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(68, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "cm";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(12, 259);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(49, 23);
            this.btn_ok.TabIndex = 17;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // F_Geometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(215, 289);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Geometria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label21;
        public System.Windows.Forms.TextBox txt_z;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_ok;
    }
}