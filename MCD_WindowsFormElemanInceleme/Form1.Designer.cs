
namespace MCD_WindowsFormElemanInceleme
{
    partial class Form1
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
            this.btnResimSec = new System.Windows.Forms.Button();
            this.chkEkGaranti = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(106, 55);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(75, 23);
            this.btnResimSec.TabIndex = 0;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            // 
            // chkEkGaranti
            // 
            this.chkEkGaranti.AutoSize = true;
            this.chkEkGaranti.Location = new System.Drawing.Point(259, 55);
            this.chkEkGaranti.Name = "chkEkGaranti";
            this.chkEkGaranti.Size = new System.Drawing.Size(97, 17);
            this.chkEkGaranti.TabIndex = 1;
            this.chkEkGaranti.Text = "Ek garanti 2 Yıl";
            this.chkEkGaranti.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkEkGaranti);
            this.Controls.Add(this.btnResimSec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.CheckBox chkEkGaranti;
    }
}

