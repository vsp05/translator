﻿
namespace translator
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.TopBox = new System.Windows.Forms.PictureBox();
            this.PageTitleTxt = new System.Windows.Forms.TextBox();
            this.inputLangTxt = new System.Windows.Forms.TextBox();
            this.TextTxt = new System.Windows.Forms.TextBox();
            this.OutputLangTxt = new System.Windows.Forms.TextBox();
            this.inputLangInputTxt = new System.Windows.Forms.TextBox();
            this.TextInputTxt = new System.Windows.Forms.TextBox();
            this.OutputLangInputTxt = new System.Windows.Forms.TextBox();
            this.translateBtn = new System.Windows.Forms.Button();
            this.OutputTxt = new System.Windows.Forms.TextBox();
            this.translatedTxt = new System.Windows.Forms.TextBox();
            this.LanguagesBtn = new System.Windows.Forms.Button();
            this.LanguagesTxt = new System.Windows.Forms.TextBox();
            this.HomePgTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DocumentBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TopBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBox
            // 
            this.TopBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TopBox.Location = new System.Drawing.Point(-11, -6);
            this.TopBox.Name = "TopBox";
            this.TopBox.Size = new System.Drawing.Size(815, 65);
            this.TopBox.TabIndex = 0;
            this.TopBox.TabStop = false;
            // 
            // PageTitleTxt
            // 
            this.PageTitleTxt.BackColor = System.Drawing.SystemColors.Control;
            this.PageTitleTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PageTitleTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageTitleTxt.Location = new System.Drawing.Point(12, 3);
            this.PageTitleTxt.Name = "PageTitleTxt";
            this.PageTitleTxt.Size = new System.Drawing.Size(776, 46);
            this.PageTitleTxt.TabIndex = 0;
            this.PageTitleTxt.TabStop = false;
            this.PageTitleTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inputLangTxt
            // 
            this.inputLangTxt.BackColor = System.Drawing.SystemColors.Control;
            this.inputLangTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputLangTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLangTxt.Location = new System.Drawing.Point(29, 83);
            this.inputLangTxt.Name = "inputLangTxt";
            this.inputLangTxt.Size = new System.Drawing.Size(316, 33);
            this.inputLangTxt.TabIndex = 0;
            this.inputLangTxt.TabStop = false;
            this.inputLangTxt.Text = "Input Language Code*:";
            // 
            // TextTxt
            // 
            this.TextTxt.BackColor = System.Drawing.SystemColors.Control;
            this.TextTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextTxt.Location = new System.Drawing.Point(29, 214);
            this.TextTxt.Name = "TextTxt";
            this.TextTxt.Size = new System.Drawing.Size(233, 33);
            this.TextTxt.TabIndex = 0;
            this.TextTxt.TabStop = false;
            this.TextTxt.Text = "Text:";
            // 
            // OutputLangTxt
            // 
            this.OutputLangTxt.BackColor = System.Drawing.SystemColors.Control;
            this.OutputLangTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputLangTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLangTxt.Location = new System.Drawing.Point(29, 148);
            this.OutputLangTxt.Name = "OutputLangTxt";
            this.OutputLangTxt.Size = new System.Drawing.Size(316, 33);
            this.OutputLangTxt.TabIndex = 0;
            this.OutputLangTxt.TabStop = false;
            this.OutputLangTxt.Text = "Output Language Code*:";
            // 
            // inputLangInputTxt
            // 
            this.inputLangInputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputLangInputTxt.Location = new System.Drawing.Point(366, 83);
            this.inputLangInputTxt.Name = "inputLangInputTxt";
            this.inputLangInputTxt.Size = new System.Drawing.Size(100, 38);
            this.inputLangInputTxt.TabIndex = 1;
            this.inputLangInputTxt.TextChanged += new System.EventHandler(this.inputLangInputTxt_TextChanged);
            // 
            // TextInputTxt
            // 
            this.TextInputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.TextInputTxt.Location = new System.Drawing.Point(291, 214);
            this.TextInputTxt.Multiline = true;
            this.TextInputTxt.Name = "TextInputTxt";
            this.TextInputTxt.Size = new System.Drawing.Size(458, 142);
            this.TextInputTxt.TabIndex = 3;
            this.TextInputTxt.TextChanged += new System.EventHandler(this.TextInputTxt_TextChanged);
            // 
            // OutputLangInputTxt
            // 
            this.OutputLangInputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OutputLangInputTxt.Location = new System.Drawing.Point(366, 148);
            this.OutputLangInputTxt.Name = "OutputLangInputTxt";
            this.OutputLangInputTxt.Size = new System.Drawing.Size(100, 38);
            this.OutputLangInputTxt.TabIndex = 2;
            this.OutputLangInputTxt.TextChanged += new System.EventHandler(this.OutputLangInputTxt_TextChanged);
            // 
            // translateBtn
            // 
            this.translateBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.translateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.translateBtn.Location = new System.Drawing.Point(674, 372);
            this.translateBtn.Name = "translateBtn";
            this.translateBtn.Size = new System.Drawing.Size(114, 42);
            this.translateBtn.TabIndex = 4;
            this.translateBtn.Text = "Translate";
            this.translateBtn.UseVisualStyleBackColor = false;
            this.translateBtn.Click += new System.EventHandler(this.translateBtn_Click);
            // 
            // OutputTxt
            // 
            this.OutputTxt.BackColor = System.Drawing.SystemColors.Control;
            this.OutputTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTxt.Location = new System.Drawing.Point(29, 443);
            this.OutputTxt.Name = "OutputTxt";
            this.OutputTxt.Size = new System.Drawing.Size(233, 33);
            this.OutputTxt.TabIndex = 0;
            this.OutputTxt.TabStop = false;
            this.OutputTxt.Text = "Translation:";
            // 
            // translatedTxt
            // 
            this.translatedTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.translatedTxt.Location = new System.Drawing.Point(291, 443);
            this.translatedTxt.Multiline = true;
            this.translatedTxt.Name = "translatedTxt";
            this.translatedTxt.Size = new System.Drawing.Size(458, 142);
            this.translatedTxt.TabIndex = 0;
            this.translatedTxt.TabStop = false;
            // 
            // LanguagesBtn
            // 
            this.LanguagesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LanguagesBtn.BackgroundImage")));
            this.LanguagesBtn.Location = new System.Drawing.Point(664, 83);
            this.LanguagesBtn.Name = "LanguagesBtn";
            this.LanguagesBtn.Size = new System.Drawing.Size(48, 47);
            this.LanguagesBtn.TabIndex = 0;
            this.LanguagesBtn.TabStop = false;
            this.LanguagesBtn.UseVisualStyleBackColor = true;
            this.LanguagesBtn.Click += new System.EventHandler(this.LanguagesBtn_Click);
            // 
            // LanguagesTxt
            // 
            this.LanguagesTxt.BackColor = System.Drawing.SystemColors.Control;
            this.LanguagesTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LanguagesTxt.Location = new System.Drawing.Point(561, 99);
            this.LanguagesTxt.Name = "LanguagesTxt";
            this.LanguagesTxt.ReadOnly = true;
            this.LanguagesTxt.Size = new System.Drawing.Size(97, 13);
            this.LanguagesTxt.TabIndex = 0;
            this.LanguagesTxt.TabStop = false;
            this.LanguagesTxt.Text = "Language Codes:";
            // 
            // HomePgTitle
            // 
            this.HomePgTitle.AutoSize = true;
            this.HomePgTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomePgTitle.Location = new System.Drawing.Point(303, 7);
            this.HomePgTitle.Name = "HomePgTitle";
            this.HomePgTitle.Size = new System.Drawing.Size(215, 42);
            this.HomePgTitle.TabIndex = 0;
            this.HomePgTitle.Text = "Home Page";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(558, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "* Language codes should be in ISO 639-1 format";
            // 
            // DocumentBtn
            // 
            this.DocumentBtn.BackColor = System.Drawing.Color.LightYellow;
            this.DocumentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DocumentBtn.Location = new System.Drawing.Point(51, 640);
            this.DocumentBtn.Name = "DocumentBtn";
            this.DocumentBtn.Size = new System.Drawing.Size(154, 53);
            this.DocumentBtn.TabIndex = 5;
            this.DocumentBtn.Text = "Translate a large file";
            this.DocumentBtn.UseVisualStyleBackColor = false;
            this.DocumentBtn.Click += new System.EventHandler(this.DocumentBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 719);
            this.Controls.Add(this.DocumentBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HomePgTitle);
            this.Controls.Add(this.LanguagesTxt);
            this.Controls.Add(this.LanguagesBtn);
            this.Controls.Add(this.translatedTxt);
            this.Controls.Add(this.OutputTxt);
            this.Controls.Add(this.translateBtn);
            this.Controls.Add(this.OutputLangInputTxt);
            this.Controls.Add(this.TextInputTxt);
            this.Controls.Add(this.inputLangInputTxt);
            this.Controls.Add(this.OutputLangTxt);
            this.Controls.Add(this.TextTxt);
            this.Controls.Add(this.inputLangTxt);
            this.Controls.Add(this.PageTitleTxt);
            this.Controls.Add(this.TopBox);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TopBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox TopBox;
        private System.Windows.Forms.TextBox PageTitleTxt;
        private System.Windows.Forms.TextBox inputLangTxt;
        private System.Windows.Forms.TextBox TextTxt;
        private System.Windows.Forms.TextBox OutputLangTxt;
        private System.Windows.Forms.TextBox inputLangInputTxt;
        private System.Windows.Forms.TextBox TextInputTxt;
        private System.Windows.Forms.TextBox OutputLangInputTxt;
        private System.Windows.Forms.Button translateBtn;
        private System.Windows.Forms.TextBox OutputTxt;
        private System.Windows.Forms.TextBox translatedTxt;
        private System.Windows.Forms.Button LanguagesBtn;
        private System.Windows.Forms.TextBox LanguagesTxt;
        private System.Windows.Forms.Label HomePgTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DocumentBtn;
    }
}

