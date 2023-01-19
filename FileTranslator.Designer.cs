
namespace translator
{
    partial class FileTranslator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileTranslator));
            this.HomeBtn = new System.Windows.Forms.Button();
            this.ImportBtn = new System.Windows.Forms.Button();
            this.translatedTxt = new System.Windows.Forms.TextBox();
            this.inputLangTxt = new System.Windows.Forms.TextBox();
            this.OutputLangTxt = new System.Windows.Forms.TextBox();
            this.inputLangInputTxt = new System.Windows.Forms.TextBox();
            this.OutputLangInputTxt = new System.Windows.Forms.TextBox();
            this.LanguagesTxt = new System.Windows.Forms.TextBox();
            this.LanguagesBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HomeBtn
            // 
            this.HomeBtn.BackColor = System.Drawing.Color.LightCoral;
            this.HomeBtn.Location = new System.Drawing.Point(683, 520);
            this.HomeBtn.Name = "HomeBtn";
            this.HomeBtn.Size = new System.Drawing.Size(105, 38);
            this.HomeBtn.TabIndex = 0;
            this.HomeBtn.Text = "Back To Home";
            this.HomeBtn.UseVisualStyleBackColor = false;
            // 
            // ImportBtn
            // 
            this.ImportBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.ImportBtn.Location = new System.Drawing.Point(33, 145);
            this.ImportBtn.Name = "ImportBtn";
            this.ImportBtn.Size = new System.Drawing.Size(151, 55);
            this.ImportBtn.TabIndex = 1;
            this.ImportBtn.Text = "Import Text File";
            this.ImportBtn.UseVisualStyleBackColor = false;
            this.ImportBtn.Click += new System.EventHandler(this.ImportBtn_Click);
            // 
            // translatedTxt
            // 
            this.translatedTxt.Location = new System.Drawing.Point(24, 250);
            this.translatedTxt.Multiline = true;
            this.translatedTxt.Name = "translatedTxt";
            this.translatedTxt.Size = new System.Drawing.Size(571, 225);
            this.translatedTxt.TabIndex = 2;
            // 
            // inputLangTxt
            // 
            this.inputLangTxt.BackColor = System.Drawing.SystemColors.Control;
            this.inputLangTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputLangTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputLangTxt.Location = new System.Drawing.Point(33, 12);
            this.inputLangTxt.Name = "inputLangTxt";
            this.inputLangTxt.Size = new System.Drawing.Size(316, 33);
            this.inputLangTxt.TabIndex = 3;
            this.inputLangTxt.TabStop = false;
            this.inputLangTxt.Text = "Input Language Code*:";
            // 
            // OutputLangTxt
            // 
            this.OutputLangTxt.BackColor = System.Drawing.SystemColors.Control;
            this.OutputLangTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutputLangTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputLangTxt.Location = new System.Drawing.Point(33, 71);
            this.OutputLangTxt.Name = "OutputLangTxt";
            this.OutputLangTxt.Size = new System.Drawing.Size(316, 33);
            this.OutputLangTxt.TabIndex = 4;
            this.OutputLangTxt.TabStop = false;
            this.OutputLangTxt.Text = "Output Language Code*:";
            // 
            // inputLangInputTxt
            // 
            this.inputLangInputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputLangInputTxt.Location = new System.Drawing.Point(414, 12);
            this.inputLangInputTxt.Name = "inputLangInputTxt";
            this.inputLangInputTxt.Size = new System.Drawing.Size(100, 38);
            this.inputLangInputTxt.TabIndex = 5;
            this.inputLangInputTxt.TextChanged += new System.EventHandler(this.inputLangInputTxt_TextChanged);
            // 
            // OutputLangInputTxt
            // 
            this.OutputLangInputTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OutputLangInputTxt.Location = new System.Drawing.Point(414, 71);
            this.OutputLangInputTxt.Name = "OutputLangInputTxt";
            this.OutputLangInputTxt.Size = new System.Drawing.Size(100, 38);
            this.OutputLangInputTxt.TabIndex = 6;
            this.OutputLangInputTxt.TextChanged += new System.EventHandler(this.OutputLangInputTxt_TextChanged);
            // 
            // LanguagesTxt
            // 
            this.LanguagesTxt.BackColor = System.Drawing.SystemColors.Control;
            this.LanguagesTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LanguagesTxt.Location = new System.Drawing.Point(578, 46);
            this.LanguagesTxt.Name = "LanguagesTxt";
            this.LanguagesTxt.ReadOnly = true;
            this.LanguagesTxt.Size = new System.Drawing.Size(97, 13);
            this.LanguagesTxt.TabIndex = 7;
            this.LanguagesTxt.TabStop = false;
            this.LanguagesTxt.Text = "Language Codes:";
            // 
            // LanguagesBtn
            // 
            this.LanguagesBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LanguagesBtn.BackgroundImage")));
            this.LanguagesBtn.Location = new System.Drawing.Point(683, 29);
            this.LanguagesBtn.Name = "LanguagesBtn";
            this.LanguagesBtn.Size = new System.Drawing.Size(48, 47);
            this.LanguagesBtn.TabIndex = 8;
            this.LanguagesBtn.TabStop = false;
            this.LanguagesBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "* Language codes should be in ISO 639-1 format";
            // 
            // FileTranslator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LanguagesBtn);
            this.Controls.Add(this.LanguagesTxt);
            this.Controls.Add(this.OutputLangInputTxt);
            this.Controls.Add(this.inputLangInputTxt);
            this.Controls.Add(this.OutputLangTxt);
            this.Controls.Add(this.inputLangTxt);
            this.Controls.Add(this.translatedTxt);
            this.Controls.Add(this.ImportBtn);
            this.Controls.Add(this.HomeBtn);
            this.Name = "FileTranslator";
            this.Text = "File Translator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HomeBtn;
        private System.Windows.Forms.Button ImportBtn;
        private System.Windows.Forms.TextBox translatedTxt;
        private System.Windows.Forms.TextBox inputLangTxt;
        private System.Windows.Forms.TextBox OutputLangTxt;
        private System.Windows.Forms.TextBox inputLangInputTxt;
        private System.Windows.Forms.TextBox OutputLangInputTxt;
        private System.Windows.Forms.TextBox LanguagesTxt;
        private System.Windows.Forms.Button LanguagesBtn;
        private System.Windows.Forms.Label label1;
    }
}