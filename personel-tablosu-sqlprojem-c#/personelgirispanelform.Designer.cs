namespace personeltablosusqlprojem
{
    partial class personelgirispanelform
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnkullanicigiris = new System.Windows.Forms.Button();
            this.txtkullanicigiris = new System.Windows.Forms.TextBox();
            this.txtkullanicisifre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "kullanıcı girisi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Brush Script MT", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(398, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "personel takip sistemi giriş paneli";
            // 
            // btnkullanicigiris
            // 
            this.btnkullanicigiris.Location = new System.Drawing.Point(243, 262);
            this.btnkullanicigiris.Name = "btnkullanicigiris";
            this.btnkullanicigiris.Size = new System.Drawing.Size(119, 38);
            this.btnkullanicigiris.TabIndex = 3;
            this.btnkullanicigiris.Text = "giriş";
            this.btnkullanicigiris.UseVisualStyleBackColor = true;
            this.btnkullanicigiris.Click += new System.EventHandler(this.btnkullanicigiris_Click);
            // 
            // txtkullanicigiris
            // 
            this.txtkullanicigiris.Location = new System.Drawing.Point(243, 125);
            this.txtkullanicigiris.Name = "txtkullanicigiris";
            this.txtkullanicigiris.Size = new System.Drawing.Size(119, 36);
            this.txtkullanicigiris.TabIndex = 4;
            // 
            // txtkullanicisifre
            // 
            this.txtkullanicisifre.Location = new System.Drawing.Point(243, 195);
            this.txtkullanicisifre.Name = "txtkullanicisifre";
            this.txtkullanicisifre.Size = new System.Drawing.Size(119, 36);
            this.txtkullanicisifre.TabIndex = 5;
            this.txtkullanicisifre.UseSystemPasswordChar = true;
            // 
            // personelgirispanelform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(571, 354);
            this.Controls.Add(this.txtkullanicisifre);
            this.Controls.Add(this.txtkullanicigiris);
            this.Controls.Add(this.btnkullanicigiris);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "personelgirispanelform";
            this.Text = "personelgirispanelform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnkullanicigiris;
        private System.Windows.Forms.TextBox txtkullanicigiris;
        private System.Windows.Forms.TextBox txtkullanicisifre;
    }
}