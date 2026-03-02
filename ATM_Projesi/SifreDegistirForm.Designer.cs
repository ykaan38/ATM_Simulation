namespace ATM_Projesi
{
    partial class SifreDegistirForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SifreDegistirForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtTekrar = new System.Windows.Forms.TextBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Şifreniz:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre Tekrar:";
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtYeniSifre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtYeniSifre.Location = new System.Drawing.Point(285, 151);
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.PasswordChar = '*';
            this.txtYeniSifre.Size = new System.Drawing.Size(209, 20);
            this.txtYeniSifre.TabIndex = 2;
            // 
            // txtTekrar
            // 
            this.txtTekrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTekrar.Location = new System.Drawing.Point(285, 210);
            this.txtTekrar.Name = "txtTekrar";
            this.txtTekrar.PasswordChar = '*';
            this.txtTekrar.Size = new System.Drawing.Size(209, 20);
            this.txtTekrar.TabIndex = 3;
            // 
            // btnDegistir
            // 
            this.btnDegistir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDegistir.BackColor = System.Drawing.Color.Lime;
            this.btnDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDegistir.Location = new System.Drawing.Point(285, 288);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(104, 34);
            this.btnDegistir.TabIndex = 4;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = false;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(395, 288);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(99, 34);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // SifreDegistirForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(755, 494);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnDegistir);
            this.Controls.Add(this.txtTekrar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SifreDegistirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SifreDegistirForm";
            this.Load += new System.EventHandler(this.SifreDegistirForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtTekrar;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.Button btnIptal;
    }
}