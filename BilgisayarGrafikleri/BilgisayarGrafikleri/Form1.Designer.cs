
namespace BilgisayarGrafikleri
{
    partial class frmAnasayfa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEksen = new System.Windows.Forms.Button();
            this.btnOtele = new System.Windows.Forms.Button();
            this.btnİzdüşüm = new System.Windows.Forms.Button();
            this.oteleX = new System.Windows.Forms.TextBox();
            this.oteleY = new System.Windows.Forms.TextBox();
            this.oteleZ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOlcekle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.olcekleZ = new System.Windows.Forms.TextBox();
            this.olcekleY = new System.Windows.Forms.TextBox();
            this.olcekleX = new System.Windows.Forms.TextBox();
            this.btntemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEksen
            // 
            this.btnEksen.Location = new System.Drawing.Point(33, 51);
            this.btnEksen.Name = "btnEksen";
            this.btnEksen.Size = new System.Drawing.Size(129, 64);
            this.btnEksen.TabIndex = 0;
            this.btnEksen.Text = "Eksenleri Çiz(XYZ)";
            this.btnEksen.UseVisualStyleBackColor = true;
            this.btnEksen.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOtele
            // 
            this.btnOtele.Location = new System.Drawing.Point(33, 207);
            this.btnOtele.Name = "btnOtele";
            this.btnOtele.Size = new System.Drawing.Size(129, 130);
            this.btnOtele.TabIndex = 2;
            this.btnOtele.Text = "Ötele";
            this.btnOtele.UseVisualStyleBackColor = true;
            this.btnOtele.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnİzdüşüm
            // 
            this.btnİzdüşüm.Location = new System.Drawing.Point(33, 121);
            this.btnİzdüşüm.Name = "btnİzdüşüm";
            this.btnİzdüşüm.Size = new System.Drawing.Size(129, 64);
            this.btnİzdüşüm.TabIndex = 5;
            this.btnİzdüşüm.Text = "Cismin İzometrik İzdüşümünü Al";
            this.btnİzdüşüm.UseVisualStyleBackColor = true;
            this.btnİzdüşüm.Click += new System.EventHandler(this.btnİzdüşüm_Click);
            // 
            // oteleX
            // 
            this.oteleX.Location = new System.Drawing.Point(191, 225);
            this.oteleX.Name = "oteleX";
            this.oteleX.Size = new System.Drawing.Size(100, 27);
            this.oteleX.TabIndex = 6;
            this.oteleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oteleX_KeyPress);
            // 
            // oteleY
            // 
            this.oteleY.Location = new System.Drawing.Point(191, 262);
            this.oteleY.Name = "oteleY";
            this.oteleY.Size = new System.Drawing.Size(100, 27);
            this.oteleY.TabIndex = 7;
            this.oteleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oteleY_KeyPress_1);
            // 
            // oteleZ
            // 
            this.oteleZ.Location = new System.Drawing.Point(191, 299);
            this.oteleZ.Name = "oteleZ";
            this.oteleZ.Size = new System.Drawing.Size(100, 27);
            this.oteleZ.TabIndex = 8;
            this.oteleZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oteleZ_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "x";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(169, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(169, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "z";
            // 
            // btnOlcekle
            // 
            this.btnOlcekle.Location = new System.Drawing.Point(33, 343);
            this.btnOlcekle.Name = "btnOlcekle";
            this.btnOlcekle.Size = new System.Drawing.Size(129, 130);
            this.btnOlcekle.TabIndex = 12;
            this.btnOlcekle.Text = "Ölçekle";
            this.btnOlcekle.UseVisualStyleBackColor = true;
            this.btnOlcekle.Click += new System.EventHandler(this.btnOlcekle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(169, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "z";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(169, 395);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(169, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "x";
            // 
            // olcekleZ
            // 
            this.olcekleZ.Location = new System.Drawing.Point(191, 432);
            this.olcekleZ.Name = "olcekleZ";
            this.olcekleZ.Size = new System.Drawing.Size(100, 27);
            this.olcekleZ.TabIndex = 15;
            this.olcekleZ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.olcekleZ_KeyPress);
            // 
            // olcekleY
            // 
            this.olcekleY.Location = new System.Drawing.Point(191, 395);
            this.olcekleY.Name = "olcekleY";
            this.olcekleY.Size = new System.Drawing.Size(100, 27);
            this.olcekleY.TabIndex = 14;
            this.olcekleY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.olcekleY_KeyPress);
            // 
            // olcekleX
            // 
            this.olcekleX.Location = new System.Drawing.Point(191, 358);
            this.olcekleX.Name = "olcekleX";
            this.olcekleX.Size = new System.Drawing.Size(100, 27);
            this.olcekleX.TabIndex = 13;
            this.olcekleX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.olcekleX_KeyPress);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(33, 506);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(129, 46);
            this.btntemizle.TabIndex = 19;
            this.btntemizle.Text = "Formu Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // frmAnasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(982, 603);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.olcekleZ);
            this.Controls.Add(this.olcekleY);
            this.Controls.Add(this.olcekleX);
            this.Controls.Add(this.btnOlcekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oteleZ);
            this.Controls.Add(this.oteleY);
            this.Controls.Add(this.oteleX);
            this.Controls.Add(this.btnİzdüşüm);
            this.Controls.Add(this.btnOtele);
            this.Controls.Add(this.btnEksen);
            this.Name = "frmAnasayfa";
            this.Text = "Bilgisayar Grafikleri Kısa Sınav";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEksen;
        private System.Windows.Forms.Button btnOtele;
        private System.Windows.Forms.Button btnİzdüşüm;
        private System.Windows.Forms.TextBox oteleX;
        private System.Windows.Forms.TextBox oteleY;
        private System.Windows.Forms.TextBox oteleZ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOlcekle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox olcekleZ;
        private System.Windows.Forms.TextBox olcekleY;
        private System.Windows.Forms.TextBox olcekleX;
        private System.Windows.Forms.Button btntemizle;
    }
}

