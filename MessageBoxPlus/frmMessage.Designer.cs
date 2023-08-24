
namespace MessageBoxPlus
{
    partial class frmMessage
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
            this.panelTxt = new System.Windows.Forms.Panel();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.Label();
            this.panelPicButton = new System.Windows.Forms.Panel();
            this.panelPic = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.panelButton = new System.Windows.Forms.Panel();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panelTxt.SuspendLayout();
            this.panelPicButton.SuspendLayout();
            this.panelPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.panelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTxt
            // 
            this.panelTxt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelTxt.Controls.Add(this.txtRemark);
            this.panelTxt.Controls.Add(this.txtContent);
            this.panelTxt.Controls.Add(this.txtTitle);
            this.panelTxt.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTxt.Location = new System.Drawing.Point(0, 0);
            this.panelTxt.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.panelTxt.Name = "panelTxt";
            this.panelTxt.Size = new System.Drawing.Size(347, 279);
            this.panelTxt.TabIndex = 0;
            // 
            // txtRemark
            // 
            this.txtRemark.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.ForeColor = System.Drawing.SystemColors.Window;
            this.txtRemark.Location = new System.Drawing.Point(0, 169);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(347, 110);
            this.txtRemark.TabIndex = 2;
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.SystemColors.Info;
            this.txtContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtContent.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContent.Location = new System.Drawing.Point(0, 41);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.Size = new System.Drawing.Size(347, 128);
            this.txtContent.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.AutoSize = true;
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtTitle.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(0, 0);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Padding = new System.Windows.Forms.Padding(7, 7, 0, 7);
            this.txtTitle.Size = new System.Drawing.Size(136, 41);
            this.txtTitle.TabIndex = 0;
            this.txtTitle.Text = "Default title";
            // 
            // panelPicButton
            // 
            this.panelPicButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPicButton.Controls.Add(this.panelPic);
            this.panelPicButton.Controls.Add(this.panelButton);
            this.panelPicButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelPicButton.Location = new System.Drawing.Point(347, 0);
            this.panelPicButton.Name = "panelPicButton";
            this.panelPicButton.Size = new System.Drawing.Size(169, 279);
            this.panelPicButton.TabIndex = 0;
            // 
            // panelPic
            // 
            this.panelPic.Controls.Add(this.picIcon);
            this.panelPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPic.Location = new System.Drawing.Point(0, 0);
            this.panelPic.Name = "panelPic";
            this.panelPic.Size = new System.Drawing.Size(169, 90);
            this.panelPic.TabIndex = 4;
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(89, 3);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(77, 77);
            this.picIcon.TabIndex = 3;
            this.picIcon.TabStop = false;
            this.picIcon.Click += new System.EventHandler(this.picIcon_Click);
            // 
            // panelButton
            // 
            this.panelButton.Controls.Add(this.buttonOK);
            this.panelButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButton.Location = new System.Drawing.Point(0, 128);
            this.panelButton.Name = "panelButton";
            this.panelButton.Size = new System.Drawing.Size(169, 151);
            this.panelButton.TabIndex = 4;
            // 
            // buttonOK
            // 
            this.buttonOK.BackColor = System.Drawing.Color.Green;
            this.buttonOK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOK.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonOK.Location = new System.Drawing.Point(0, 116);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(169, 35);
            this.buttonOK.TabIndex = 0;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = false;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 279);
            this.Controls.Add(this.panelPicButton);
            this.Controls.Add(this.panelTxt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMessage";
            this.Text = "Message";
            this.Load += new System.EventHandler(this.frmMessage_Load);
            this.panelTxt.ResumeLayout(false);
            this.panelTxt.PerformLayout();
            this.panelPicButton.ResumeLayout(false);
            this.panelPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.panelButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTxt;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label txtTitle;
        private System.Windows.Forms.Panel panelPicButton;
        private System.Windows.Forms.Panel panelPic;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Panel panelButton;
        private System.Windows.Forms.Button buttonOK;
    }
}