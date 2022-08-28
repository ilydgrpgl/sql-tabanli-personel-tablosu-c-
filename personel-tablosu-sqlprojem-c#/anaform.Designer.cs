namespace personeltablosusqlprojem
{
    partial class anaform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsehir = new System.Windows.Forms.ComboBox();
            this.txtmeslek = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtmaas = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btngrafikler = new System.Windows.Forms.Button();
            this.btnistatistik = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnsil = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btnlistele = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.peridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.peradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perdurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.permeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelTablosuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personel_TablosuDataSet = new personeltablosusqlprojem.Personel_TablosuDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personel_TablosuTableAdapter = new personeltablosusqlprojem.Personel_TablosuDataSetTableAdapters.Personel_TablosuTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTablosuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_TablosuDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "personelid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "şehir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 241);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "durum";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(81, 272);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "meslek";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(93, 206);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "maaş";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsehir);
            this.groupBox1.Controls.Add(this.txtmeslek);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.txtmaas);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 328);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "personel kayıt";
            // 
            // txtsehir
            // 
            this.txtsehir.FormattingEnabled = true;
            this.txtsehir.Location = new System.Drawing.Point(154, 171);
            this.txtsehir.Name = "txtsehir";
            this.txtsehir.Size = new System.Drawing.Size(121, 30);
            this.txtsehir.TabIndex = 8;
            // 
            // txtmeslek
            // 
            this.txtmeslek.Location = new System.Drawing.Point(154, 265);
            this.txtmeslek.Name = "txtmeslek";
            this.txtmeslek.Size = new System.Drawing.Size(121, 29);
            this.txtmeslek.TabIndex = 12;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(219, 241);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(77, 26);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "bekar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(154, 241);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 26);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "evli";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtmaas
            // 
            this.txtmaas.Location = new System.Drawing.Point(154, 206);
            this.txtmaas.Name = "txtmaas";
            this.txtmaas.Size = new System.Drawing.Size(121, 29);
            this.txtmaas.TabIndex = 10;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(154, 136);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(121, 29);
            this.txtsoyad.TabIndex = 9;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(154, 101);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(121, 29);
            this.txtad.TabIndex = 8;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(154, 62);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(121, 29);
            this.txtid.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btngrafikler);
            this.groupBox2.Controls.Add(this.btnistatistik);
            this.groupBox2.Controls.Add(this.btntemizle);
            this.groupBox2.Controls.Add(this.btngüncelle);
            this.groupBox2.Controls.Add(this.btnsil);
            this.groupBox2.Controls.Add(this.btnkaydet);
            this.groupBox2.Controls.Add(this.btnlistele);
            this.groupBox2.Location = new System.Drawing.Point(411, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 328);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "işlemler";
            // 
            // btngrafikler
            // 
            this.btngrafikler.BackColor = System.Drawing.Color.White;
            this.btngrafikler.Location = new System.Drawing.Point(111, 265);
            this.btngrafikler.Name = "btngrafikler";
            this.btngrafikler.Size = new System.Drawing.Size(111, 28);
            this.btngrafikler.TabIndex = 6;
            this.btngrafikler.Text = "grafikler";
            this.btngrafikler.UseVisualStyleBackColor = false;
            this.btngrafikler.Click += new System.EventHandler(this.btngrafikler_Click);
            // 
            // btnistatistik
            // 
            this.btnistatistik.BackColor = System.Drawing.Color.White;
            this.btnistatistik.Location = new System.Drawing.Point(111, 231);
            this.btnistatistik.Name = "btnistatistik";
            this.btnistatistik.Size = new System.Drawing.Size(111, 28);
            this.btnistatistik.TabIndex = 5;
            this.btnistatistik.Text = "istatistik";
            this.btnistatistik.UseVisualStyleBackColor = false;
            this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.BackColor = System.Drawing.Color.White;
            this.btntemizle.Location = new System.Drawing.Point(111, 197);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(111, 28);
            this.btntemizle.TabIndex = 4;
            this.btntemizle.Text = "temizle";
            this.btntemizle.UseVisualStyleBackColor = false;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.BackColor = System.Drawing.Color.White;
            this.btngüncelle.Location = new System.Drawing.Point(111, 163);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(111, 28);
            this.btngüncelle.TabIndex = 3;
            this.btngüncelle.Text = "güncelle";
            this.btngüncelle.UseVisualStyleBackColor = false;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // btnsil
            // 
            this.btnsil.BackColor = System.Drawing.Color.White;
            this.btnsil.Location = new System.Drawing.Point(111, 124);
            this.btnsil.Name = "btnsil";
            this.btnsil.Size = new System.Drawing.Size(111, 28);
            this.btnsil.TabIndex = 2;
            this.btnsil.Text = "sil";
            this.btnsil.UseVisualStyleBackColor = false;
            this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.BackColor = System.Drawing.Color.White;
            this.btnkaydet.Location = new System.Drawing.Point(111, 86);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(111, 28);
            this.btnkaydet.TabIndex = 1;
            this.btnkaydet.Text = "kaydet";
            this.btnkaydet.UseVisualStyleBackColor = false;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // btnlistele
            // 
            this.btnlistele.BackColor = System.Drawing.Color.White;
            this.btnlistele.Location = new System.Drawing.Point(111, 48);
            this.btnlistele.Name = "btnlistele";
            this.btnlistele.Size = new System.Drawing.Size(111, 28);
            this.btnlistele.TabIndex = 0;
            this.btnlistele.Text = "listele";
            this.btnlistele.UseVisualStyleBackColor = false;
            this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 369);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(934, 144);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.peridDataGridViewTextBoxColumn,
            this.peradDataGridViewTextBoxColumn,
            this.persoyadDataGridViewTextBoxColumn,
            this.persehirDataGridViewTextBoxColumn,
            this.permaasDataGridViewTextBoxColumn,
            this.perdurumDataGridViewCheckBoxColumn,
            this.permeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personelTablosuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(928, 116);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // peridDataGridViewTextBoxColumn
            // 
            this.peridDataGridViewTextBoxColumn.DataPropertyName = "perid";
            this.peridDataGridViewTextBoxColumn.HeaderText = "perid";
            this.peridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peridDataGridViewTextBoxColumn.Name = "peridDataGridViewTextBoxColumn";
            this.peridDataGridViewTextBoxColumn.ReadOnly = true;
            this.peridDataGridViewTextBoxColumn.Width = 125;
            // 
            // peradDataGridViewTextBoxColumn
            // 
            this.peradDataGridViewTextBoxColumn.DataPropertyName = "perad";
            this.peradDataGridViewTextBoxColumn.HeaderText = "perad";
            this.peradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.peradDataGridViewTextBoxColumn.Name = "peradDataGridViewTextBoxColumn";
            this.peradDataGridViewTextBoxColumn.Width = 125;
            // 
            // persoyadDataGridViewTextBoxColumn
            // 
            this.persoyadDataGridViewTextBoxColumn.DataPropertyName = "persoyad";
            this.persoyadDataGridViewTextBoxColumn.HeaderText = "persoyad";
            this.persoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persoyadDataGridViewTextBoxColumn.Name = "persoyadDataGridViewTextBoxColumn";
            this.persoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // persehirDataGridViewTextBoxColumn
            // 
            this.persehirDataGridViewTextBoxColumn.DataPropertyName = "persehir";
            this.persehirDataGridViewTextBoxColumn.HeaderText = "persehir";
            this.persehirDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.persehirDataGridViewTextBoxColumn.Name = "persehirDataGridViewTextBoxColumn";
            this.persehirDataGridViewTextBoxColumn.Width = 125;
            // 
            // permaasDataGridViewTextBoxColumn
            // 
            this.permaasDataGridViewTextBoxColumn.DataPropertyName = "permaas";
            this.permaasDataGridViewTextBoxColumn.HeaderText = "permaas";
            this.permaasDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permaasDataGridViewTextBoxColumn.Name = "permaasDataGridViewTextBoxColumn";
            this.permaasDataGridViewTextBoxColumn.Width = 125;
            // 
            // perdurumDataGridViewCheckBoxColumn
            // 
            this.perdurumDataGridViewCheckBoxColumn.DataPropertyName = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.HeaderText = "perdurum";
            this.perdurumDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.perdurumDataGridViewCheckBoxColumn.Name = "perdurumDataGridViewCheckBoxColumn";
            this.perdurumDataGridViewCheckBoxColumn.Width = 125;
            // 
            // permeslekDataGridViewTextBoxColumn
            // 
            this.permeslekDataGridViewTextBoxColumn.DataPropertyName = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.HeaderText = "permeslek";
            this.permeslekDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.permeslekDataGridViewTextBoxColumn.Name = "permeslekDataGridViewTextBoxColumn";
            this.permeslekDataGridViewTextBoxColumn.Width = 125;
            // 
            // personelTablosuBindingSource
            // 
            this.personelTablosuBindingSource.DataMember = "Personel_Tablosu";
            this.personelTablosuBindingSource.DataSource = this.personel_TablosuDataSet;
            // 
            // personel_TablosuDataSet
            // 
            this.personel_TablosuDataSet.DataSetName = "Personel_TablosuDataSet";
            this.personel_TablosuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(791, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // personel_TablosuTableAdapter
            // 
            this.personel_TablosuTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(787, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 22);
            this.label8.TabIndex = 11;
            this.label8.Text = "label8";
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            // 
            // anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(958, 525);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "anaform";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelTablosuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personel_TablosuDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtsehir;
        private System.Windows.Forms.TextBox txtmeslek;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtmaas;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btngrafikler;
        private System.Windows.Forms.Button btnistatistik;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Button btnsil;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Button btnlistele;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Personel_TablosuDataSet personel_TablosuDataSet;
        private System.Windows.Forms.BindingSource personelTablosuBindingSource;
        private Personel_TablosuDataSetTableAdapters.Personel_TablosuTableAdapter personel_TablosuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn peridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn peradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn persehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn perdurumDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn permeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label8;
    }
}

