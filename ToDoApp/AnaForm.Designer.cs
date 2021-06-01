
namespace ToDoApp
{
    partial class AnaForm
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
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstYapilanlar = new System.Windows.Forms.ListBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYildizla = new System.Windows.Forms.Button();
            this.dtpAnaForm = new System.Windows.Forms.DateTimePicker();
            this.cbYildizlariGöster = new System.Windows.Forms.CheckBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMesaj
            // 
            this.txtMesaj.ForeColor = System.Drawing.Color.Purple;
            this.txtMesaj.Location = new System.Drawing.Point(38, 28);
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.Size = new System.Drawing.Size(237, 27);
            this.txtMesaj.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnEkle.Location = new System.Drawing.Point(286, 26);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(142, 29);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstYapilanlar
            // 
            this.lstYapilanlar.ForeColor = System.Drawing.Color.Purple;
            this.lstYapilanlar.FormattingEnabled = true;
            this.lstYapilanlar.ItemHeight = 20;
            this.lstYapilanlar.Location = new System.Drawing.Point(38, 119);
            this.lstYapilanlar.Name = "lstYapilanlar";
            this.lstYapilanlar.Size = new System.Drawing.Size(390, 264);
            this.lstYapilanlar.TabIndex = 2;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnDuzenle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDuzenle.Location = new System.Drawing.Point(41, 441);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(192, 29);
            this.btnDuzenle.TabIndex = 3;
            this.btnDuzenle.Text = "DÜZENLE";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSil.Location = new System.Drawing.Point(239, 441);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(189, 29);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYildizla
            // 
            this.btnYildizla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnYildizla.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnYildizla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnYildizla.Location = new System.Drawing.Point(38, 389);
            this.btnYildizla.Name = "btnYildizla";
            this.btnYildizla.Size = new System.Drawing.Size(205, 27);
            this.btnYildizla.TabIndex = 6;
            this.btnYildizla.Text = "YILDIZLA/YILDIZI KALDIR";
            this.btnYildizla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYildizla.UseVisualStyleBackColor = false;
            this.btnYildizla.Click += new System.EventHandler(this.btnYildizla_Click);
            // 
            // dtpAnaForm
            // 
            this.dtpAnaForm.CalendarForeColor = System.Drawing.Color.Purple;
            this.dtpAnaForm.Checked = false;
            this.dtpAnaForm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpAnaForm.Location = new System.Drawing.Point(38, 75);
            this.dtpAnaForm.Name = "dtpAnaForm";
            this.dtpAnaForm.ShowCheckBox = true;
            this.dtpAnaForm.Size = new System.Drawing.Size(389, 27);
            this.dtpAnaForm.TabIndex = 7;
            // 
            // cbYildizlariGöster
            // 
            this.cbYildizlariGöster.AutoSize = true;
            this.cbYildizlariGöster.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.cbYildizlariGöster.ForeColor = System.Drawing.Color.White;
            this.cbYildizlariGöster.Location = new System.Drawing.Point(245, 391);
            this.cbYildizlariGöster.Name = "cbYildizlariGöster";
            this.cbYildizlariGöster.Size = new System.Drawing.Size(183, 24);
            this.cbYildizlariGöster.TabIndex = 8;
            this.cbYildizlariGöster.Text = "YILDIZLILARI LİSTELE";
            this.cbYildizlariGöster.UseVisualStyleBackColor = true;
            this.cbYildizlariGöster.CheckStateChanged += new System.EventHandler(this.cbYildizlariGöster_CheckStateChanged);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAra.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAra.Location = new System.Drawing.Point(38, 486);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(389, 29);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "ARAMA  YAP";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(492, 554);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.cbYildizlariGöster);
            this.Controls.Add(this.dtpAnaForm);
            this.Controls.Add(this.btnYildizla);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.lstYapilanlar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtMesaj);
            this.Name = "AnaForm";
            this.Text = "MY DONE LİST";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AnaForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMesaj;
        public System.Windows.Forms.Button btnEkle;
        public System.Windows.Forms.ListBox lstYapilanlar;
        public System.Windows.Forms.Button btnDuzenle;
        public System.Windows.Forms.Button btnSil;
        public System.Windows.Forms.Button btnYildizla;
        public System.Windows.Forms.DateTimePicker dtpAnaForm;
        private System.Windows.Forms.CheckBox cbYildizlariGöster;
        public System.Windows.Forms.Button btnAra;
    }
}