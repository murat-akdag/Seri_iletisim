namespace Seri_iletisim
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
            this.txtGonderilecek = new System.Windows.Forms.TextBox();
            this.txtAlinacak = new System.Windows.Forms.TextBox();
            this.btnYolla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGonderilecek
            // 
            this.txtGonderilecek.Location = new System.Drawing.Point(25, 26);
            this.txtGonderilecek.Multiline = true;
            this.txtGonderilecek.Name = "txtGonderilecek";
            this.txtGonderilecek.Size = new System.Drawing.Size(200, 173);
            this.txtGonderilecek.TabIndex = 0;
            this.txtGonderilecek.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGonderilecek_KeyPress);
            // 
            // txtAlinacak
            // 
            this.txtAlinacak.Location = new System.Drawing.Point(295, 26);
            this.txtAlinacak.Multiline = true;
            this.txtAlinacak.Name = "txtAlinacak";
            this.txtAlinacak.Size = new System.Drawing.Size(200, 173);
            this.txtAlinacak.TabIndex = 1;
            // 
            // btnYolla
            // 
            this.btnYolla.Location = new System.Drawing.Point(150, 228);
            this.btnYolla.Name = "btnYolla";
            this.btnYolla.Size = new System.Drawing.Size(75, 23);
            this.btnYolla.TabIndex = 2;
            this.btnYolla.Text = "Yolla";
            this.btnYolla.UseVisualStyleBackColor = true;
            this.btnYolla.Click += new System.EventHandler(this.btnYolla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 353);
            this.Controls.Add(this.btnYolla);
            this.Controls.Add(this.txtAlinacak);
            this.Controls.Add(this.txtGonderilecek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGonderilecek;
        private System.Windows.Forms.TextBox txtAlinacak;
        private System.Windows.Forms.Button btnYolla;
    }
}

