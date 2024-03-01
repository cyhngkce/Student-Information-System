namespace PostgreSQL
{
    partial class YoneticiPanel
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
            this.ogrencigoruntule = new System.Windows.Forms.Button();
            this.ogrenciekle = new System.Windows.Forms.Button();
            this.ogrenciguncelle = new System.Windows.Forms.Button();
            this.ogrencisil = new System.Windows.Forms.Button();
            this.hocaguncelle = new System.Windows.Forms.Button();
            this.hocasil = new System.Windows.Forms.Button();
            this.hocaekle = new System.Windows.Forms.Button();
            this.hocagoruntule = new System.Windows.Forms.Button();
            this.id2 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // ogrencigoruntule
            // 
            this.ogrencigoruntule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ogrencigoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencigoruntule.Location = new System.Drawing.Point(12, 321);
            this.ogrencigoruntule.Name = "ogrencigoruntule";
            this.ogrencigoruntule.Size = new System.Drawing.Size(203, 42);
            this.ogrencigoruntule.TabIndex = 1;
            this.ogrencigoruntule.Text = "Öğrenci Görüntüle";
            this.ogrencigoruntule.UseVisualStyleBackColor = false;
            this.ogrencigoruntule.Click += new System.EventHandler(this.ogrencigoruntule_Click);
            // 
            // ogrenciekle
            // 
            this.ogrenciekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ogrenciekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciekle.Location = new System.Drawing.Point(12, 369);
            this.ogrenciekle.Name = "ogrenciekle";
            this.ogrenciekle.Size = new System.Drawing.Size(203, 41);
            this.ogrenciekle.TabIndex = 2;
            this.ogrenciekle.Text = "Öğrenci Ekle";
            this.ogrenciekle.UseVisualStyleBackColor = false;
            this.ogrenciekle.Click += new System.EventHandler(this.ogrenciekle_Click);
            // 
            // ogrenciguncelle
            // 
            this.ogrenciguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrenciguncelle.Location = new System.Drawing.Point(12, 464);
            this.ogrenciguncelle.Name = "ogrenciguncelle";
            this.ogrenciguncelle.Size = new System.Drawing.Size(203, 41);
            this.ogrenciguncelle.TabIndex = 4;
            this.ogrenciguncelle.Text = "Öğrenci Güncelle";
            this.ogrenciguncelle.UseVisualStyleBackColor = true;
            this.ogrenciguncelle.Click += new System.EventHandler(this.ogrenciguncelle_Click);
            // 
            // ogrencisil
            // 
            this.ogrencisil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ogrencisil.Location = new System.Drawing.Point(12, 416);
            this.ogrencisil.Name = "ogrencisil";
            this.ogrencisil.Size = new System.Drawing.Size(203, 42);
            this.ogrencisil.TabIndex = 3;
            this.ogrencisil.Text = "Öğrenci Sil";
            this.ogrencisil.UseVisualStyleBackColor = true;
            this.ogrencisil.Click += new System.EventHandler(this.ogrencisil_Click);
            // 
            // hocaguncelle
            // 
            this.hocaguncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hocaguncelle.Location = new System.Drawing.Point(306, 464);
            this.hocaguncelle.Name = "hocaguncelle";
            this.hocaguncelle.Size = new System.Drawing.Size(203, 41);
            this.hocaguncelle.TabIndex = 8;
            this.hocaguncelle.Text = "Hoca Güncelle";
            this.hocaguncelle.UseVisualStyleBackColor = true;
            this.hocaguncelle.Click += new System.EventHandler(this.hocaguncelle_Click);
            // 
            // hocasil
            // 
            this.hocasil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hocasil.Location = new System.Drawing.Point(306, 416);
            this.hocasil.Name = "hocasil";
            this.hocasil.Size = new System.Drawing.Size(203, 42);
            this.hocasil.TabIndex = 7;
            this.hocasil.Text = "Hoca Sil";
            this.hocasil.UseVisualStyleBackColor = true;
            this.hocasil.Click += new System.EventHandler(this.hocasil_Click);
            // 
            // hocaekle
            // 
            this.hocaekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.hocaekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hocaekle.Location = new System.Drawing.Point(306, 369);
            this.hocaekle.Name = "hocaekle";
            this.hocaekle.Size = new System.Drawing.Size(203, 41);
            this.hocaekle.TabIndex = 6;
            this.hocaekle.Text = "Hoca Ekle";
            this.hocaekle.UseVisualStyleBackColor = false;
            this.hocaekle.Click += new System.EventHandler(this.hocaekle_Click);
            // 
            // hocagoruntule
            // 
            this.hocagoruntule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.hocagoruntule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hocagoruntule.Location = new System.Drawing.Point(306, 321);
            this.hocagoruntule.Name = "hocagoruntule";
            this.hocagoruntule.Size = new System.Drawing.Size(203, 42);
            this.hocagoruntule.TabIndex = 5;
            this.hocagoruntule.Text = "Hoca Görüntüle";
            this.hocagoruntule.UseVisualStyleBackColor = false;
            this.hocagoruntule.Click += new System.EventHandler(this.hocagoruntule_Click);
            // 
            // id2
            // 
            this.id2.Location = new System.Drawing.Point(658, 24);
            this.id2.Multiline = true;
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(164, 22);
            this.id2.TabIndex = 9;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ID.Location = new System.Drawing.Point(620, 24);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(32, 20);
            this.ID.TabIndex = 10;
            this.ID.Text = "ID*";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(602, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Şifre*";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(658, 183);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(163, 22);
            this.txtPassword.TabIndex = 17;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(658, 142);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(163, 22);
            this.txtUsername.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(547, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Kullanıcı Adı*";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(658, 102);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(163, 22);
            this.txtSoyad.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(591, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Soyad*";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(658, 64);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(163, 22);
            this.txtAd.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Coral;
            this.label3.Location = new System.Drawing.Point(611, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Ad*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(570, 297);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.MaximumSize = new System.Drawing.Size(300, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 40);
            this.label1.TabIndex = 19;
            this.label1.Text = "* : Hoca veya kullanıcı eklenirken * olan alanların doldurulması gerekir";
            // 
            // YoneticiPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.id2);
            this.Controls.Add(this.hocaguncelle);
            this.Controls.Add(this.hocasil);
            this.Controls.Add(this.hocaekle);
            this.Controls.Add(this.hocagoruntule);
            this.Controls.Add(this.ogrenciguncelle);
            this.Controls.Add(this.ogrencisil);
            this.Controls.Add(this.ogrenciekle);
            this.Controls.Add(this.ogrencigoruntule);
            this.Controls.Add(this.dataGridView1);
            this.Name = "YoneticiPanel";
            this.Text = "YoneticiPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ogrencigoruntule;
        private System.Windows.Forms.Button ogrenciekle;
        private System.Windows.Forms.Button ogrenciguncelle;
        private System.Windows.Forms.Button ogrencisil;
        private System.Windows.Forms.Button hocaguncelle;
        private System.Windows.Forms.Button hocasil;
        private System.Windows.Forms.Button hocaekle;
        private System.Windows.Forms.Button hocagoruntule;
        private System.Windows.Forms.TextBox id2;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}