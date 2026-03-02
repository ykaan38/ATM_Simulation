namespace ATM_Projesi
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.btnParaYatir = new System.Windows.Forms.Button();
            this.btnSifre = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.ForeColor = System.Drawing.Color.White;
            this.lblAdSoyad.Location = new System.Drawing.Point(12, 9);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(74, 33);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "İsim";
            this.lblAdSoyad.Click += new System.EventHandler(this.lblAdSoyad_Click);
            // 
            // lblBakiye
            // 
            this.lblBakiye.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBakiye.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBakiye.ForeColor = System.Drawing.Color.White;
            this.lblBakiye.Location = new System.Drawing.Point(496, 260);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(137, 42);
            this.lblBakiye.TabIndex = 1;
            this.lblBakiye.Text = "Bakiye";
            this.lblBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBakiye.Click += new System.EventHandler(this.lblBakiye_Click);
            // 
            // btnParaCek
            // 
            this.btnParaCek.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnParaCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaCek.Location = new System.Drawing.Point(18, 274);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(335, 58);
            this.btnParaCek.TabIndex = 2;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // btnParaYatir
            // 
            this.btnParaYatir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnParaYatir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParaYatir.Location = new System.Drawing.Point(18, 342);
            this.btnParaYatir.Name = "btnParaYatir";
            this.btnParaYatir.Size = new System.Drawing.Size(335, 58);
            this.btnParaYatir.TabIndex = 3;
            this.btnParaYatir.Text = "Para Yatır";
            this.btnParaYatir.UseVisualStyleBackColor = true;
            this.btnParaYatir.Click += new System.EventHandler(this.btnParaYatir_Click);
            // 
            // btnSifre
            // 
            this.btnSifre.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifre.Location = new System.Drawing.Point(780, 274);
            this.btnSifre.Name = "btnSifre";
            this.btnSifre.Size = new System.Drawing.Size(335, 58);
            this.btnSifre.TabIndex = 4;
            this.btnSifre.Text = "Şifre Değiştir";
            this.btnSifre.UseVisualStyleBackColor = true;
            this.btnSifre.Click += new System.EventHandler(this.btnSifre_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(780, 338);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(335, 58);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTarihSaat.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarihSaat.ForeColor = System.Drawing.Color.White;
            this.lblTarihSaat.Location = new System.Drawing.Point(967, 9);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(158, 23);
            this.lblTarihSaat.TabIndex = 6;
            this.lblTarihSaat.Text = "Tarih";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(12, 390);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1103, 249);
            this.dataGridView1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1127, 651);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTarihSaat);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnSifre);
            this.Controls.Add(this.btnParaYatir);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblAdSoyad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Click += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.Button btnParaYatir;
        private System.Windows.Forms.Button btnSifre;
        private System.Windows.Forms.Button btnCikis;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}