namespace _4.EF_UYGULAMA
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_Musteri = new System.Windows.Forms.ComboBox();
            this.cmb_personel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_Nakliye = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.num_Adet = new System.Windows.Forms.NumericUpDown();
            this.num_indirim = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_urunler = new System.Windows.Forms.DataGridView();
            this.btn_Ekle = new System.Windows.Forms.Button();
            this.list_urunler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_SipOnayla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num_Adet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_indirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(478, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri";
            // 
            // cmb_Musteri
            // 
            this.cmb_Musteri.FormattingEnabled = true;
            this.cmb_Musteri.Location = new System.Drawing.Point(477, 287);
            this.cmb_Musteri.Name = "cmb_Musteri";
            this.cmb_Musteri.Size = new System.Drawing.Size(121, 21);
            this.cmb_Musteri.TabIndex = 4;
            // 
            // cmb_personel
            // 
            this.cmb_personel.FormattingEnabled = true;
            this.cmb_personel.Location = new System.Drawing.Point(632, 287);
            this.cmb_personel.Name = "cmb_personel";
            this.cmb_personel.Size = new System.Drawing.Size(121, 21);
            this.cmb_personel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel";
            // 
            // cmb_Nakliye
            // 
            this.cmb_Nakliye.FormattingEnabled = true;
            this.cmb_Nakliye.Location = new System.Drawing.Point(779, 287);
            this.cmb_Nakliye.Name = "cmb_Nakliye";
            this.cmb_Nakliye.Size = new System.Drawing.Size(121, 21);
            this.cmb_Nakliye.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(780, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nakliye";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Adet";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // num_Adet
            // 
            this.num_Adet.Location = new System.Drawing.Point(13, 287);
            this.num_Adet.Name = "num_Adet";
            this.num_Adet.Size = new System.Drawing.Size(120, 20);
            this.num_Adet.TabIndex = 2;
            // 
            // num_indirim
            // 
            this.num_indirim.Location = new System.Drawing.Point(162, 287);
            this.num_indirim.Name = "num_indirim";
            this.num_indirim.Size = new System.Drawing.Size(120, 20);
            this.num_indirim.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "İndirim";
            // 
            // dgv_urunler
            // 
            this.dgv_urunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_urunler.Location = new System.Drawing.Point(12, 12);
            this.dgv_urunler.Name = "dgv_urunler";
            this.dgv_urunler.Size = new System.Drawing.Size(888, 243);
            this.dgv_urunler.TabIndex = 1;
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.Location = new System.Drawing.Point(288, 284);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_Ekle.TabIndex = 11;
            this.btn_Ekle.Text = "Ekle";
            this.btn_Ekle.UseVisualStyleBackColor = true;
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // list_urunler
            // 
            this.list_urunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.list_urunler.FullRowSelect = true;
            this.list_urunler.GridLines = true;
            this.list_urunler.Location = new System.Drawing.Point(12, 313);
            this.list_urunler.Name = "list_urunler";
            this.list_urunler.Size = new System.Drawing.Size(369, 156);
            this.list_urunler.TabIndex = 8;
            this.list_urunler.UseCompatibleStateImageBehavior = false;
            this.list_urunler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 151;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Fiyat";
            this.columnHeader2.Width = 68;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            this.columnHeader3.Width = 63;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İndirim";
            this.columnHeader4.Width = 82;
            // 
            // btn_SipOnayla
            // 
            this.btn_SipOnayla.Location = new System.Drawing.Point(477, 334);
            this.btn_SipOnayla.Name = "btn_SipOnayla";
            this.btn_SipOnayla.Size = new System.Drawing.Size(423, 25);
            this.btn_SipOnayla.TabIndex = 7;
            this.btn_SipOnayla.Text = "SiparisOnayla";
            this.btn_SipOnayla.UseVisualStyleBackColor = true;
            this.btn_SipOnayla.Click += new System.EventHandler(this.btn_SipOnayla_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(632, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Satisları Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_SipOnayla);
            this.Controls.Add(this.list_urunler);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.dgv_urunler);
            this.Controls.Add(this.num_indirim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.num_Adet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_Nakliye);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmb_personel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_Musteri);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_Adet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_indirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_urunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Musteri;
        private System.Windows.Forms.ComboBox cmb_personel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_Nakliye;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_Adet;
        private System.Windows.Forms.NumericUpDown num_indirim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_urunler;
        private System.Windows.Forms.Button btn_Ekle;
        private System.Windows.Forms.ListView list_urunler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btn_SipOnayla;
        private System.Windows.Forms.Button button1;
    }
}

