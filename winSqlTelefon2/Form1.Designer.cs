namespace winSqlTelefon2
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
            this.btnKisileriGetir = new System.Windows.Forms.Button();
            this.lstKisiler = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lstTelefonlar = new System.Windows.Forms.ListBox();
            this.lstAdresler = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKisileriGetir
            // 
            this.btnKisileriGetir.Location = new System.Drawing.Point(64, 363);
            this.btnKisileriGetir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKisileriGetir.Name = "btnKisileriGetir";
            this.btnKisileriGetir.Size = new System.Drawing.Size(164, 28);
            this.btnKisileriGetir.TabIndex = 0;
            this.btnKisileriGetir.Text = "Kişileri Getir";
            this.btnKisileriGetir.UseVisualStyleBackColor = true;
            this.btnKisileriGetir.Click += new System.EventHandler(this.btnKisileriGetir_Click);
            // 
            // lstKisiler
            // 
            this.lstKisiler.FormattingEnabled = true;
            this.lstKisiler.ItemHeight = 16;
            this.lstKisiler.Location = new System.Drawing.Point(14, 15);
            this.lstKisiler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstKisiler.Name = "lstKisiler";
            this.lstKisiler.Size = new System.Drawing.Size(214, 340);
            this.lstKisiler.TabIndex = 1;
            this.lstKisiler.SelectedIndexChanged += new System.EventHandler(this.lstKisiler_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(234, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(415, 340);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstTelefonlar);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(407, 311);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Telefon Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lstAdresler);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(407, 311);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adres Bilgileri";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstTelefonlar
            // 
            this.lstTelefonlar.FormattingEnabled = true;
            this.lstTelefonlar.ItemHeight = 16;
            this.lstTelefonlar.Location = new System.Drawing.Point(15, 24);
            this.lstTelefonlar.Name = "lstTelefonlar";
            this.lstTelefonlar.Size = new System.Drawing.Size(173, 260);
            this.lstTelefonlar.TabIndex = 0;
            // 
            // lstAdresler
            // 
            this.lstAdresler.FormattingEnabled = true;
            this.lstAdresler.ItemHeight = 16;
            this.lstAdresler.Location = new System.Drawing.Point(17, 25);
            this.lstAdresler.Name = "lstAdresler";
            this.lstAdresler.Size = new System.Drawing.Size(173, 228);
            this.lstAdresler.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 406);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lstKisiler);
            this.Controls.Add(this.btnKisileriGetir);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Telefon Defteri Versiyon 2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKisileriGetir;
        private System.Windows.Forms.ListBox lstKisiler;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstTelefonlar;
        private System.Windows.Forms.ListBox lstAdresler;
    }
}

