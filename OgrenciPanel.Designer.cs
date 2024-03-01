namespace PostgreSQL
{
    partial class OgrenciPanel
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transkript = new System.Windows.Forms.Button();
            this.txtilgiAlan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ilgiAlanEkle = new System.Windows.Forms.Button();
            this.hocaListele = new System.Windows.Forms.Button();
            this.bilgiGoruntule = new System.Windows.Forms.Button();
            this.notButton = new System.Windows.Forms.Button();
            this.dersSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(513, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // transkript
            // 
            this.transkript.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.transkript.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.transkript.Location = new System.Drawing.Point(519, 329);
            this.transkript.Name = "transkript";
            this.transkript.Size = new System.Drawing.Size(269, 44);
            this.transkript.TabIndex = 1;
            this.transkript.Text = "Transkript belgesi yükle";
            this.transkript.UseVisualStyleBackColor = false;
            this.transkript.Click += new System.EventHandler(this.transkript_Click);
            // 
            // txtilgiAlan
            // 
            this.txtilgiAlan.BackColor = System.Drawing.Color.White;
            this.txtilgiAlan.Location = new System.Drawing.Point(607, 36);
            this.txtilgiAlan.Multiline = true;
            this.txtilgiAlan.Name = "txtilgiAlan";
            this.txtilgiAlan.Size = new System.Drawing.Size(157, 27);
            this.txtilgiAlan.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(519, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlgi Alanı:";
            // 
            // ilgiAlanEkle
            // 
            this.ilgiAlanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilgiAlanEkle.Location = new System.Drawing.Point(630, 81);
            this.ilgiAlanEkle.Name = "ilgiAlanEkle";
            this.ilgiAlanEkle.Size = new System.Drawing.Size(99, 33);
            this.ilgiAlanEkle.TabIndex = 4;
            this.ilgiAlanEkle.Text = "Ekle";
            this.ilgiAlanEkle.UseVisualStyleBackColor = true;
            this.ilgiAlanEkle.Click += new System.EventHandler(this.ilgiAlanEkle_Click);
            // 
            // hocaListele
            // 
            this.hocaListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.hocaListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hocaListele.Location = new System.Drawing.Point(519, 255);
            this.hocaListele.Name = "hocaListele";
            this.hocaListele.Size = new System.Drawing.Size(269, 56);
            this.hocaListele.TabIndex = 5;
            this.hocaListele.Text = "İlgi alanına göre hocaları listele";
            this.hocaListele.UseVisualStyleBackColor = false;
            this.hocaListele.Click += new System.EventHandler(this.hocaListele_Click);
            // 
            // bilgiGoruntule
            // 
            this.bilgiGoruntule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bilgiGoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bilgiGoruntule.Location = new System.Drawing.Point(519, 395);
            this.bilgiGoruntule.Name = "bilgiGoruntule";
            this.bilgiGoruntule.Size = new System.Drawing.Size(269, 43);
            this.bilgiGoruntule.TabIndex = 6;
            this.bilgiGoruntule.Text = "Bilgilerimi Görüntüle";
            this.bilgiGoruntule.UseVisualStyleBackColor = false;
            this.bilgiGoruntule.Click += new System.EventHandler(this.bilgiGoruntule_Click);
            // 
            // notButton
            // 
            this.notButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.notButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notButton.Location = new System.Drawing.Point(523, 190);
            this.notButton.Name = "notButton";
            this.notButton.Size = new System.Drawing.Size(265, 44);
            this.notButton.TabIndex = 7;
            this.notButton.Text = "Notları Görüntüle";
            this.notButton.UseVisualStyleBackColor = false;
            this.notButton.Click += new System.EventHandler(this.notButton_Click);
            // 
            // dersSec
            // 
            this.dersSec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dersSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dersSec.ForeColor = System.Drawing.Color.Black;
            this.dersSec.Location = new System.Drawing.Point(523, 137);
            this.dersSec.Name = "dersSec";
            this.dersSec.Size = new System.Drawing.Size(265, 47);
            this.dersSec.TabIndex = 8;
            this.dersSec.Text = "Ders Seç";
            this.dersSec.UseVisualStyleBackColor = false;
            this.dersSec.Click += new System.EventHandler(this.dersSec_Click);
            // 
            // OgrenciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dersSec);
            this.Controls.Add(this.notButton);
            this.Controls.Add(this.bilgiGoruntule);
            this.Controls.Add(this.hocaListele);
            this.Controls.Add(this.ilgiAlanEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtilgiAlan);
            this.Controls.Add(this.transkript);
            this.Controls.Add(this.dataGridView1);
            this.Name = "OgrenciPanel";
            this.Text = "OgrenciPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button transkript;
        private System.Windows.Forms.TextBox txtilgiAlan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ilgiAlanEkle;
        private System.Windows.Forms.Button hocaListele;
        private System.Windows.Forms.Button bilgiGoruntule;
        private System.Windows.Forms.Button notButton;
        private System.Windows.Forms.Button dersSec;
    }
}