
namespace HastaneRandevuSistemi
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.BtnHastaGiris = new System.Windows.Forms.Button();
            this.BtnSekreterGiris = new System.Windows.Forms.Button();
            this.BtnDoktorGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHastaGiris
            // 
            this.BtnHastaGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnHastaGiris.BackgroundImage")));
            this.BtnHastaGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGiris.Location = new System.Drawing.Point(11, 95);
            this.BtnHastaGiris.Name = "BtnHastaGiris";
            this.BtnHastaGiris.Size = new System.Drawing.Size(235, 177);
            this.BtnHastaGiris.TabIndex = 0;
            this.BtnHastaGiris.UseVisualStyleBackColor = true;
            this.BtnHastaGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnSekreterGiris
            // 
            this.BtnSekreterGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGiris.BackgroundImage")));
            this.BtnSekreterGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGiris.Location = new System.Drawing.Point(263, 95);
            this.BtnSekreterGiris.Name = "BtnSekreterGiris";
            this.BtnSekreterGiris.Size = new System.Drawing.Size(237, 177);
            this.BtnSekreterGiris.TabIndex = 1;
            this.BtnSekreterGiris.UseVisualStyleBackColor = true;
            this.BtnSekreterGiris.Click += new System.EventHandler(this.BtnSekreterGiris_Click);
            // 
            // BtnDoktorGiris
            // 
            this.BtnDoktorGiris.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnDoktorGiris.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGiris.BackgroundImage")));
            this.BtnDoktorGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGiris.Location = new System.Drawing.Point(517, 95);
            this.BtnDoktorGiris.Name = "BtnDoktorGiris";
            this.BtnDoktorGiris.Size = new System.Drawing.Size(224, 177);
            this.BtnDoktorGiris.TabIndex = 2;
            this.BtnDoktorGiris.UseVisualStyleBackColor = true;
            this.BtnDoktorGiris.Click += new System.EventHandler(this.BtnDoktorGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 16.25F);
            this.label1.Location = new System.Drawing.Point(76, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "HASTA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 16.25F);
            this.label2.Location = new System.Drawing.Point(329, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "SEKRETER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 16.25F);
            this.label3.Location = new System.Drawing.Point(577, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "DOKTOR";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 327);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDoktorGiris);
            this.Controls.Add(this.BtnSekreterGiris);
            this.Controls.Add(this.BtnHastaGiris);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGirisler";
            this.Text = "Sakarya Eğitim Araştırma Hastanesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHastaGiris;
        private System.Windows.Forms.Button BtnSekreterGiris;
        private System.Windows.Forms.Button BtnDoktorGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

