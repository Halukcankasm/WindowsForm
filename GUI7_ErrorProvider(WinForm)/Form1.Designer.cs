
namespace GUI7_ErrorProvider_WinForm_
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
            this.components = new System.ComponentModel.Container();
            this.txtVatandaslıkNO = new System.Windows.Forms.TextBox();
            this.btn_Kaydet = new System.Windows.Forms.Button();
            this.errTCNoSına = new System.Windows.Forms.ErrorProvider(this.components);
            this.errBasmakSayisi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errTCNoSına)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBasmakSayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtVatandaslıkNO
            // 
            this.txtVatandaslıkNO.BackColor = System.Drawing.SystemColors.Info;
            this.txtVatandaslıkNO.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtVatandaslıkNO.ForeColor = System.Drawing.Color.Gray;
            this.txtVatandaslıkNO.Location = new System.Drawing.Point(44, 30);
            this.txtVatandaslıkNO.Name = "txtVatandaslıkNO";
            this.txtVatandaslıkNO.Size = new System.Drawing.Size(248, 42);
            this.txtVatandaslıkNO.TabIndex = 0;
            this.txtVatandaslıkNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtVatandaslıkNO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVatandaslıkNO_KeyPress);
            // 
            // btn_Kaydet
            // 
            this.btn_Kaydet.Location = new System.Drawing.Point(104, 113);
            this.btn_Kaydet.Name = "btn_Kaydet";
            this.btn_Kaydet.Size = new System.Drawing.Size(112, 34);
            this.btn_Kaydet.TabIndex = 1;
            this.btn_Kaydet.Text = "&Kaydet";
            this.btn_Kaydet.UseVisualStyleBackColor = true;
            this.btn_Kaydet.Click += new System.EventHandler(this.btnKydt_Click);
            // 
            // errTCNoSına
            // 
            this.errTCNoSına.BlinkRate = 300;
            this.errTCNoSına.ContainerControl = this;
            // 
            // errBasmakSayisi
            // 
            this.errBasmakSayisi.BlinkRate = 300;
            this.errBasmakSayisi.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 728);
            this.Controls.Add(this.btn_Kaydet);
            this.Controls.Add(this.txtVatandaslıkNO);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errTCNoSına)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errBasmakSayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVatandaslıkNO;
        private System.Windows.Forms.Button btn_Kaydet;
        private System.Windows.Forms.ErrorProvider errTCNoSına;
        private System.Windows.Forms.ErrorProvider errBasmakSayisi;
    }
}

