namespace combox_örnek_1_1681
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
            this.lbSayılar = new System.Windows.Forms.ListBox();
            this.btnSayılar = new System.Windows.Forms.Button();
            this.cmbCiftSayilar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbSayılar
            // 
            this.lbSayılar.FormattingEnabled = true;
            this.lbSayılar.Location = new System.Drawing.Point(21, 12);
            this.lbSayılar.Name = "lbSayılar";
            this.lbSayılar.Size = new System.Drawing.Size(120, 186);
            this.lbSayılar.TabIndex = 0;
            // 
            // btnSayılar
            // 
            this.btnSayılar.Location = new System.Drawing.Point(21, 216);
            this.btnSayılar.Name = "btnSayılar";
            this.btnSayılar.Size = new System.Drawing.Size(120, 33);
            this.btnSayılar.TabIndex = 1;
            this.btnSayılar.Text = "çift sayı ekle";
            this.btnSayılar.UseVisualStyleBackColor = true;
            this.btnSayılar.Click += new System.EventHandler(this.btnSayılar_Click);
            // 
            // cmbCiftSayilar
            // 
            this.cmbCiftSayilar.FormattingEnabled = true;
            this.cmbCiftSayilar.Location = new System.Drawing.Point(21, 268);
            this.cmbCiftSayilar.Name = "cmbCiftSayilar";
            this.cmbCiftSayilar.Size = new System.Drawing.Size(121, 21);
            this.cmbCiftSayilar.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 450);
            this.Controls.Add(this.cmbCiftSayilar);
            this.Controls.Add(this.btnSayılar);
            this.Controls.Add(this.lbSayılar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbSayılar;
        private System.Windows.Forms.Button btnSayılar;
        private System.Windows.Forms.ComboBox cmbCiftSayilar;
    }
}

