namespace SinemaOtomasyon2
{
    partial class Form1
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lb_KoltukSecimi = new System.Windows.Forms.Label();
            this.btn_KoltukOnayla = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lb_filmAdi = new System.Windows.Forms.Label();
            this.dgv_seans = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zaman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cb_filmAdi = new System.Windows.Forms.ComboBox();
            this.lb_filmSec = new System.Windows.Forms.Label();
            this.btn_onayla = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lb_rez5 = new System.Windows.Forms.Label();
            this.lb_rez4 = new System.Windows.Forms.Label();
            this.lb_rez3 = new System.Windows.Forms.Label();
            this.lb_rez2 = new System.Windows.Forms.Label();
            this.lb_rez1 = new System.Windows.Forms.Label();
            this.lb_seansDetay = new System.Windows.Forms.Label();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seans)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lb_KoltukSecimi);
            this.tabPage3.Controls.Add(this.btn_KoltukOnayla);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(774, 524);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Salon Seçin";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // lb_KoltukSecimi
            // 
            this.lb_KoltukSecimi.AutoSize = true;
            this.lb_KoltukSecimi.Location = new System.Drawing.Point(4, 505);
            this.lb_KoltukSecimi.Name = "lb_KoltukSecimi";
            this.lb_KoltukSecimi.Size = new System.Drawing.Size(87, 16);
            this.lb_KoltukSecimi.TabIndex = 1;
            this.lb_KoltukSecimi.Text = "Koltuk Seçimi";
            // 
            // btn_KoltukOnayla
            // 
            this.btn_KoltukOnayla.Location = new System.Drawing.Point(610, 495);
            this.btn_KoltukOnayla.Name = "btn_KoltukOnayla";
            this.btn_KoltukOnayla.Size = new System.Drawing.Size(156, 23);
            this.btn_KoltukOnayla.TabIndex = 0;
            this.btn_KoltukOnayla.Text = "Koltuk Onayla";
            this.btn_KoltukOnayla.UseVisualStyleBackColor = true;
            this.btn_KoltukOnayla.Click += new System.EventHandler(this.btn_KoltukOnayla_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lb_filmAdi);
            this.tabPage2.Controls.Add(this.dgv_seans);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(774, 524);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Seans Seçin";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lb_filmAdi
            // 
            this.lb_filmAdi.AutoSize = true;
            this.lb_filmAdi.Location = new System.Drawing.Point(364, 20);
            this.lb_filmAdi.Name = "lb_filmAdi";
            this.lb_filmAdi.Size = new System.Drawing.Size(47, 16);
            this.lb_filmAdi.TabIndex = 1;
            this.lb_filmAdi.Text = "filmAdi";
            this.lb_filmAdi.Click += new System.EventHandler(this.lb_filmAdi_Click);
            // 
            // dgv_seans
            // 
            this.dgv_seans.AllowUserToAddRows = false;
            this.dgv_seans.AllowUserToDeleteRows = false;
            this.dgv_seans.AllowUserToResizeColumns = false;
            this.dgv_seans.AllowUserToResizeRows = false;
            this.dgv_seans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_seans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_seans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.salonId,
            this.tarih,
            this.zaman,
            this.buton});
            this.dgv_seans.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_seans.Location = new System.Drawing.Point(3, 74);
            this.dgv_seans.Name = "dgv_seans";
            this.dgv_seans.ReadOnly = true;
            this.dgv_seans.RowHeadersWidth = 51;
            this.dgv_seans.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_seans.RowTemplate.Height = 24;
            this.dgv_seans.Size = new System.Drawing.Size(768, 447);
            this.dgv_seans.TabIndex = 0;
            this.dgv_seans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_seans_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // salonId
            // 
            this.salonId.HeaderText = "salonId";
            this.salonId.MinimumWidth = 6;
            this.salonId.Name = "salonId";
            this.salonId.ReadOnly = true;
            this.salonId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.salonId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tarih
            // 
            this.tarih.HeaderText = "tarih";
            this.tarih.MinimumWidth = 6;
            this.tarih.Name = "tarih";
            this.tarih.ReadOnly = true;
            this.tarih.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tarih.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // zaman
            // 
            this.zaman.HeaderText = "zaman";
            this.zaman.MinimumWidth = 6;
            this.zaman.Name = "zaman";
            this.zaman.ReadOnly = true;
            this.zaman.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.zaman.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buton
            // 
            this.buton.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.buton.HeaderText = "buton";
            this.buton.MinimumWidth = 6;
            this.buton.Name = "buton";
            this.buton.ReadOnly = true;
            this.buton.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cb_filmAdi);
            this.tabPage1.Controls.Add(this.lb_filmSec);
            this.tabPage1.Controls.Add(this.btn_onayla);
            this.tabPage1.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(774, 524);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Film Seçin";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cb_filmAdi
            // 
            this.cb_filmAdi.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filmAdi.FormattingEnabled = true;
            this.cb_filmAdi.Location = new System.Drawing.Point(321, 205);
            this.cb_filmAdi.Name = "cb_filmAdi";
            this.cb_filmAdi.Size = new System.Drawing.Size(255, 27);
            this.cb_filmAdi.TabIndex = 4;
            // 
            // lb_filmSec
            // 
            this.lb_filmSec.AutoSize = true;
            this.lb_filmSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_filmSec.Location = new System.Drawing.Point(198, 205);
            this.lb_filmSec.Name = "lb_filmSec";
            this.lb_filmSec.Size = new System.Drawing.Size(117, 25);
            this.lb_filmSec.TabIndex = 3;
            this.lb_filmSec.Text = "Film Seçiniz";
            // 
            // btn_onayla
            // 
            this.btn_onayla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_onayla.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_onayla.Location = new System.Drawing.Point(203, 274);
            this.btn_onayla.Name = "btn_onayla";
            this.btn_onayla.Size = new System.Drawing.Size(97, 45);
            this.btn_onayla.TabIndex = 2;
            this.btn_onayla.Text = "Onayla";
            this.btn_onayla.UseVisualStyleBackColor = true;
            this.btn_onayla.Click += new System.EventHandler(this.btn_onayla_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(782, 553);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lb_rez5);
            this.tabPage4.Controls.Add(this.lb_rez4);
            this.tabPage4.Controls.Add(this.lb_rez3);
            this.tabPage4.Controls.Add(this.lb_rez2);
            this.tabPage4.Controls.Add(this.lb_rez1);
            this.tabPage4.Controls.Add(this.lb_seansDetay);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(774, 524);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Rezervasyon";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lb_rez5
            // 
            this.lb_rez5.AutoSize = true;
            this.lb_rez5.Location = new System.Drawing.Point(34, 270);
            this.lb_rez5.Name = "lb_rez5";
            this.lb_rez5.Size = new System.Drawing.Size(70, 16);
            this.lb_rez5.TabIndex = 5;
            this.lb_rez5.Text = "Koltuk No :";
            // 
            // lb_rez4
            // 
            this.lb_rez4.AutoSize = true;
            this.lb_rez4.Location = new System.Drawing.Point(34, 232);
            this.lb_rez4.Name = "lb_rez4";
            this.lb_rez4.Size = new System.Drawing.Size(62, 16);
            this.lb_rez4.TabIndex = 4;
            this.lb_rez4.Text = "Salon Id :";
            // 
            // lb_rez3
            // 
            this.lb_rez3.AutoSize = true;
            this.lb_rez3.Location = new System.Drawing.Point(34, 199);
            this.lb_rez3.Name = "lb_rez3";
            this.lb_rez3.Size = new System.Drawing.Size(86, 16);
            this.lb_rez3.TabIndex = 3;
            this.lb_rez3.Text = "Seans Tarih :";
            // 
            // lb_rez2
            // 
            this.lb_rez2.AutoSize = true;
            this.lb_rez2.Location = new System.Drawing.Point(34, 152);
            this.lb_rez2.Name = "lb_rez2";
            this.lb_rez2.Size = new System.Drawing.Size(61, 16);
            this.lb_rez2.TabIndex = 2;
            this.lb_rez2.Text = "Film Adı :";
            // 
            // lb_rez1
            // 
            this.lb_rez1.AutoSize = true;
            this.lb_rez1.Location = new System.Drawing.Point(31, 111);
            this.lb_rez1.Name = "lb_rez1";
            this.lb_rez1.Size = new System.Drawing.Size(66, 16);
            this.lb_rez1.TabIndex = 1;
            this.lb_rez1.Text = "Seans Id :";
            // 
            // lb_seansDetay
            // 
            this.lb_seansDetay.AutoSize = true;
            this.lb_seansDetay.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_seansDetay.Location = new System.Drawing.Point(247, 35);
            this.lb_seansDetay.Name = "lb_seansDetay";
            this.lb_seansDetay.Size = new System.Drawing.Size(270, 38);
            this.lb_seansDetay.TabIndex = 0;
            this.lb_seansDetay.Text = "Seans Ayrıntıları";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_seans)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lb_filmAdi;
        private System.Windows.Forms.DataGridView dgv_seans;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonId;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn zaman;
        private System.Windows.Forms.DataGridViewButtonColumn buton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox cb_filmAdi;
        private System.Windows.Forms.Label lb_filmSec;
        private System.Windows.Forms.Button btn_onayla;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_KoltukOnayla;
        private System.Windows.Forms.Label lb_KoltukSecimi;
        private System.Windows.Forms.Label lb_seansDetay;
        private System.Windows.Forms.Label lb_rez5;
        private System.Windows.Forms.Label lb_rez4;
        private System.Windows.Forms.Label lb_rez3;
        private System.Windows.Forms.Label lb_rez2;
        private System.Windows.Forms.Label lb_rez1;
    }
}

