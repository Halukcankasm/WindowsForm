
namespace ListelemeKontrolleri_AlışverişSepeti_
{
    partial class Form1
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
            this.cboKategoriler = new System.Windows.Forms.ComboBox();
            this.lstBoxUrunler = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSelectedItems = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboKategoriler
            // 
            this.cboKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategoriler.FormattingEnabled = true;
            this.cboKategoriler.Items.AddRange(new object[] {
            "(Kategoriler)",
            "Atıştırmalık",
            "HamurÜrünleri",
            "Meyve/Sebze",
            "SütÜrünleri",
            "TemizlikMalzemesi"});
            this.cboKategoriler.Location = new System.Drawing.Point(12, 12);
            this.cboKategoriler.Name = "cboKategoriler";
            this.cboKategoriler.Size = new System.Drawing.Size(221, 33);
            this.cboKategoriler.TabIndex = 0;
            this.cboKategoriler.SelectedIndexChanged += new System.EventHandler(this.cboKategoriler_SelectedIndexChanged);
            // 
            // lstBoxUrunler
            // 
            this.lstBoxUrunler.FormattingEnabled = true;
            this.lstBoxUrunler.ItemHeight = 25;
            this.lstBoxUrunler.Location = new System.Drawing.Point(319, 12);
            this.lstBoxUrunler.Name = "lstBoxUrunler";
            this.lstBoxUrunler.Size = new System.Drawing.Size(273, 304);
            this.lstBoxUrunler.TabIndex = 1;
            this.lstBoxUrunler.SelectedIndexChanged += new System.EventHandler(this.lstBoxUrunler_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(1140, 566);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(218, 90);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSelectedItems
            // 
            this.lblSelectedItems.AutoSize = true;
            this.lblSelectedItems.Location = new System.Drawing.Point(766, 12);
            this.lblSelectedItems.Name = "lblSelectedItems";
            this.lblSelectedItems.Size = new System.Drawing.Size(87, 25);
            this.lblSelectedItems.TabIndex = 3;
            this.lblSelectedItems.Text = "Sepetiniz:";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(960, 566);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(174, 90);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Çıkar";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(811, 566);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 90);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 803);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblSelectedItems);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstBoxUrunler);
            this.Controls.Add(this.cboKategoriler);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboKategoriler;
        private System.Windows.Forms.ListBox lstBoxUrunler;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSelectedItems;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
    }
}

