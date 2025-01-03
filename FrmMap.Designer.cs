namespace CustomerTrackingAdoNet
{
    partial class FrmMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMap));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSehirİslemleri = new System.Windows.Forms.Button();
            this.BtnMüsteriİslem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(102, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome!!!";
            // 
            // btnSehirİslemleri
            // 
            this.btnSehirİslemleri.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSehirİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSehirİslemleri.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSehirİslemleri.Location = new System.Drawing.Point(13, 196);
            this.btnSehirİslemleri.Name = "btnSehirİslemleri";
            this.btnSehirİslemleri.Size = new System.Drawing.Size(300, 63);
            this.btnSehirİslemleri.TabIndex = 2;
            this.btnSehirİslemleri.Text = "Şehir İşlemleri";
            this.btnSehirİslemleri.UseVisualStyleBackColor = false;
            this.btnSehirİslemleri.Click += new System.EventHandler(this.btnSehirİslemleri_Click);
            // 
            // BtnMüsteriİslem
            // 
            this.BtnMüsteriİslem.BackColor = System.Drawing.Color.Chartreuse;
            this.BtnMüsteriİslem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMüsteriİslem.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnMüsteriİslem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnMüsteriİslem.Location = new System.Drawing.Point(12, 276);
            this.BtnMüsteriİslem.Name = "BtnMüsteriİslem";
            this.BtnMüsteriİslem.Size = new System.Drawing.Size(300, 63);
            this.BtnMüsteriİslem.TabIndex = 3;
            this.BtnMüsteriİslem.Text = "Müşteri İşlemleri";
            this.BtnMüsteriİslem.UseVisualStyleBackColor = false;
            this.BtnMüsteriİslem.Click += new System.EventHandler(this.BtnMüsteriİslem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Crimson;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(13, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 63);
            this.button3.TabIndex = 4;
            this.button3.Text = "Çıkış yap";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(325, 426);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnMüsteriİslem);
            this.Controls.Add(this.btnSehirİslemleri);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSehirİslemleri;
        private System.Windows.Forms.Button BtnMüsteriİslem;
        private System.Windows.Forms.Button button3;
    }
}