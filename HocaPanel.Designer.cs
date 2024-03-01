namespace PostgreSQL
{
    partial class HocaPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtilgiAlan = new System.Windows.Forms.TextBox();
            this.ilgiAlanEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(483, 456);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(524, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "İlgi alanı: ";
            // 
            // txtilgiAlan
            // 
            this.txtilgiAlan.Location = new System.Drawing.Point(615, 34);
            this.txtilgiAlan.Name = "txtilgiAlan";
            this.txtilgiAlan.Size = new System.Drawing.Size(186, 22);
            this.txtilgiAlan.TabIndex = 2;
            // 
            // ilgiAlanEkle
            // 
            this.ilgiAlanEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ilgiAlanEkle.Location = new System.Drawing.Point(664, 73);
            this.ilgiAlanEkle.Name = "ilgiAlanEkle";
            this.ilgiAlanEkle.Size = new System.Drawing.Size(81, 36);
            this.ilgiAlanEkle.TabIndex = 3;
            this.ilgiAlanEkle.Text = "Ekle";
            this.ilgiAlanEkle.UseVisualStyleBackColor = true;
            this.ilgiAlanEkle.Click += new System.EventHandler(this.ilgiAlanEkle_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(528, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(288, 94);
            this.button1.TabIndex = 4;
            this.button1.Text = "Dersimi alan oğrencileri görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HocaPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ilgiAlanEkle);
            this.Controls.Add(this.txtilgiAlan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "HocaPanel";
            this.Text = "HocaPanel";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtilgiAlan;
        private System.Windows.Forms.Button ilgiAlanEkle;
        private System.Windows.Forms.Button button1;
    }
}