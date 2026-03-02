namespace ATM_Projesi
{
    partial class ParaCekForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParaCekForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Çekilecek Miktar:";
            // 
            // txtMiktar
            // 
            this.txtMiktar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMiktar.Location = new System.Drawing.Point(295, 197);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(213, 20);
            this.txtMiktar.TabIndex = 1;
            this.txtMiktar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMiktar_KeyPress);
            // 
            // btnOnayla
            // 
            this.btnOnayla.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOnayla.BackColor = System.Drawing.Color.Lime;
            this.btnOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla.Location = new System.Drawing.Point(295, 249);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(98, 31);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(410, 249);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(98, 31);
            this.btnIptal.TabIndex = 6;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Modern No. 20", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBakiye.ForeColor = System.Drawing.Color.Gold;
            this.lblBakiye.Location = new System.Drawing.Point(14, 46);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(97, 29);
            this.lblBakiye.TabIndex = 7;
            this.lblBakiye.Text = "Bakiye";
            this.lblBakiye.Click += new System.EventHandler(this.lblBakiye_Click);
            // 
            // ParaCekForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(793, 449);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParaCekForm";
            this.Text = "ParaCekForm";
            this.Load += new System.EventHandler(this.ParaCekForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblBakiye;
    }
}