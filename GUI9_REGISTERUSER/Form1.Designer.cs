
namespace GUI9_REGISTERUSER
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
            this.chckItButton = new System.Windows.Forms.CheckBox();
            this.chckDeveloperBtn = new System.Windows.Forms.CheckBox();
            this.chckIkBtn = new System.Windows.Forms.CheckBox();
            this.btnSvd = new System.Windows.Forms.Button();
            this.lblEmploye = new System.Windows.Forms.Label();
            this.grpBox_Gender = new System.Windows.Forms.GroupBox();
            this.radioWmn_Btn = new System.Windows.Forms.RadioButton();
            this.radioMan_Btn = new System.Windows.Forms.RadioButton();
            this.linkAddres = new System.Windows.Forms.LinkLabel();
            this.grpBox_Gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // chckItButton
            // 
            this.chckItButton.AutoSize = true;
            this.chckItButton.Location = new System.Drawing.Point(30, 23);
            this.chckItButton.Name = "chckItButton";
            this.chckItButton.Size = new System.Drawing.Size(52, 29);
            this.chckItButton.TabIndex = 0;
            this.chckItButton.Text = "IT";
            this.chckItButton.UseVisualStyleBackColor = true;
            // 
            // chckDeveloperBtn
            // 
            this.chckDeveloperBtn.AutoSize = true;
            this.chckDeveloperBtn.Location = new System.Drawing.Point(30, 71);
            this.chckDeveloperBtn.Name = "chckDeveloperBtn";
            this.chckDeveloperBtn.Size = new System.Drawing.Size(119, 29);
            this.chckDeveloperBtn.TabIndex = 1;
            this.chckDeveloperBtn.Text = "Developer";
            this.chckDeveloperBtn.UseVisualStyleBackColor = true;
            // 
            // chckIkBtn
            // 
            this.chckIkBtn.AutoSize = true;
            this.chckIkBtn.Location = new System.Drawing.Point(30, 122);
            this.chckIkBtn.Name = "chckIkBtn";
            this.chckIkBtn.Size = new System.Drawing.Size(53, 29);
            this.chckIkBtn.TabIndex = 2;
            this.chckIkBtn.Text = "IK";
            this.chckIkBtn.UseVisualStyleBackColor = true;
            // 
            // btnSvd
            // 
            this.btnSvd.Location = new System.Drawing.Point(30, 203);
            this.btnSvd.Name = "btnSvd";
            this.btnSvd.Size = new System.Drawing.Size(112, 34);
            this.btnSvd.TabIndex = 3;
            this.btnSvd.Text = "Saved";
            this.btnSvd.UseVisualStyleBackColor = true;
            // 
            // lblEmploye
            // 
            this.lblEmploye.AutoSize = true;
            this.lblEmploye.Location = new System.Drawing.Point(30, 256);
            this.lblEmploye.Name = "lblEmploye";
            this.lblEmploye.Size = new System.Drawing.Size(24, 25);
            this.lblEmploye.TabIndex = 4;
            this.lblEmploye.Text = ">";
            // 
            // grpBox_Gender
            // 
            this.grpBox_Gender.Controls.Add(this.radioWmn_Btn);
            this.grpBox_Gender.Controls.Add(this.radioMan_Btn);
            this.grpBox_Gender.Location = new System.Drawing.Point(248, 23);
            this.grpBox_Gender.Name = "grpBox_Gender";
            this.grpBox_Gender.Size = new System.Drawing.Size(300, 150);
            this.grpBox_Gender.TabIndex = 5;
            this.grpBox_Gender.TabStop = false;
            this.grpBox_Gender.Text = "Gender";
            // 
            // radioWmn_Btn
            // 
            this.radioWmn_Btn.AutoSize = true;
            this.radioWmn_Btn.Location = new System.Drawing.Point(35, 99);
            this.radioWmn_Btn.Name = "radioWmn_Btn";
            this.radioWmn_Btn.Size = new System.Drawing.Size(99, 29);
            this.radioWmn_Btn.TabIndex = 1;
            this.radioWmn_Btn.TabStop = true;
            this.radioWmn_Btn.Text = "Woman";
            this.radioWmn_Btn.UseVisualStyleBackColor = true;
            // 
            // radioMan_Btn
            // 
            this.radioMan_Btn.AutoSize = true;
            this.radioMan_Btn.Location = new System.Drawing.Point(35, 48);
            this.radioMan_Btn.Name = "radioMan_Btn";
            this.radioMan_Btn.Size = new System.Drawing.Size(72, 29);
            this.radioMan_Btn.TabIndex = 0;
            this.radioMan_Btn.TabStop = true;
            this.radioMan_Btn.Text = "Man";
            this.radioMan_Btn.UseVisualStyleBackColor = true;
            // 
            // linkAddres
            // 
            this.linkAddres.AutoSize = true;
            this.linkAddres.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkAddres.Location = new System.Drawing.Point(30, 339);
            this.linkAddres.Name = "linkAddres";
            this.linkAddres.Size = new System.Drawing.Size(92, 27);
            this.linkAddres.TabIndex = 6;
            this.linkAddres.TabStop = true;
            this.linkAddres.Text = "linkLabel1";
            this.linkAddres.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAddress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 625);
            this.Controls.Add(this.linkAddres);
            this.Controls.Add(this.grpBox_Gender);
            this.Controls.Add(this.lblEmploye);
            this.Controls.Add(this.btnSvd);
            this.Controls.Add(this.chckIkBtn);
            this.Controls.Add(this.chckDeveloperBtn);
            this.Controls.Add(this.chckItButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpBox_Gender.ResumeLayout(false);
            this.grpBox_Gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chckItButton;
        private System.Windows.Forms.CheckBox chckDeveloperBtn;
        private System.Windows.Forms.CheckBox chckIkBtn;
        private System.Windows.Forms.Button btnSvd;
        private System.Windows.Forms.Label lblEmploye;
        private System.Windows.Forms.GroupBox grpBox_Gender;
        private System.Windows.Forms.RadioButton radioWmn_Btn;
        private System.Windows.Forms.RadioButton radioMan_Btn;
        private System.Windows.Forms.LinkLabel linkAddres;
    }
}

