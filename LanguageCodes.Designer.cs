
namespace translator
{
    partial class LanguageCodes
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
            this.TopBox = new System.Windows.Forms.PictureBox();
            this.PageTitleTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TopBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBox
            // 
            this.TopBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopBox.Location = new System.Drawing.Point(-10, -2);
            this.TopBox.Name = "TopBox";
            this.TopBox.Size = new System.Drawing.Size(815, 65);
            this.TopBox.TabIndex = 1;
            this.TopBox.TabStop = false;
            this.TopBox.Click += new System.EventHandler(this.TopBox_Click);
            // 
            // PageTitleTxt
            // 
            this.PageTitleTxt.BackColor = System.Drawing.SystemColors.Control;
            this.PageTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PageTitleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitleTxt.Location = new System.Drawing.Point(12, -2);
            this.PageTitleTxt.Name = "PageTitleTxt";
            this.PageTitleTxt.Size = new System.Drawing.Size(776, 46);
            this.PageTitleTxt.TabIndex = 2;
            this.PageTitleTxt.Text = "Language Codes";
            this.PageTitleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LanguageCodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PageTitleTxt);
            this.Controls.Add(this.TopBox);
            this.Name = "LanguageCodes";
            this.Text = "Language Codes";
            ((System.ComponentModel.ISupportInitialize)(this.TopBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBox;
        private System.Windows.Forms.TextBox PageTitleTxt;
    }
}