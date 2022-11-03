namespace ImportTool
{
    partial class configure_settings
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
            this.defaultPath_txtbox = new System.Windows.Forms.TextBox();
            this.chooseDefaultPath_button = new System.Windows.Forms.Button();
            this.about_txtbox = new System.Windows.Forms.RichTextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.defaultPMFile_textbox = new System.Windows.Forms.TextBox();
            this.conifg_default_videopath = new System.Windows.Forms.Label();
            this.defaultpremiere_lable = new System.Windows.Forms.Label();
            this.chooseDefPMTemplate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // defaultPath_txtbox
            // 
            this.defaultPath_txtbox.Location = new System.Drawing.Point(29, 45);
            this.defaultPath_txtbox.Name = "defaultPath_txtbox";
            this.defaultPath_txtbox.ReadOnly = true;
            this.defaultPath_txtbox.Size = new System.Drawing.Size(539, 23);
            this.defaultPath_txtbox.TabIndex = 2;
            // 
            // chooseDefaultPath_button
            // 
            this.chooseDefaultPath_button.Location = new System.Drawing.Point(599, 45);
            this.chooseDefaultPath_button.Name = "chooseDefaultPath_button";
            this.chooseDefaultPath_button.Size = new System.Drawing.Size(130, 23);
            this.chooseDefaultPath_button.TabIndex = 3;
            this.chooseDefaultPath_button.Text = "Choose Default Path";
            this.chooseDefaultPath_button.UseVisualStyleBackColor = true;
            this.chooseDefaultPath_button.Click += new System.EventHandler(this.chooseDefaultPath_Click);
            // 
            // about_txtbox
            // 
            this.about_txtbox.Location = new System.Drawing.Point(29, 130);
            this.about_txtbox.Name = "about_txtbox";
            this.about_txtbox.Size = new System.Drawing.Size(539, 249);
            this.about_txtbox.TabIndex = 4;
            this.about_txtbox.Text = "";
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(600, 327);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(129, 23);
            this.back_button.TabIndex = 5;
            this.back_button.Text = "Accept and Return";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.backButton_click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(599, 356);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(129, 23);
            this.Cancel_button.TabIndex = 6;
            this.Cancel_button.Text = "Cancel and Return";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.cancel_click);
            // 
            // defaultPMFile_textbox
            // 
            this.defaultPMFile_textbox.Location = new System.Drawing.Point(29, 101);
            this.defaultPMFile_textbox.Name = "defaultPMFile_textbox";
            this.defaultPMFile_textbox.ReadOnly = true;
            this.defaultPMFile_textbox.Size = new System.Drawing.Size(539, 23);
            this.defaultPMFile_textbox.TabIndex = 7;
            // 
            // conifg_default_videopath
            // 
            this.conifg_default_videopath.AutoSize = true;
            this.conifg_default_videopath.Location = new System.Drawing.Point(29, 27);
            this.conifg_default_videopath.Name = "conifg_default_videopath";
            this.conifg_default_videopath.Size = new System.Drawing.Size(114, 15);
            this.conifg_default_videopath.TabIndex = 8;
            this.conifg_default_videopath.Text = "Default Video Folder";
            this.conifg_default_videopath.Click += new System.EventHandler(this.label1_Click);
            // 
            // defaultpremiere_lable
            // 
            this.defaultpremiere_lable.AutoSize = true;
            this.defaultpremiere_lable.Location = new System.Drawing.Point(29, 83);
            this.defaultpremiere_lable.Name = "defaultpremiere_lable";
            this.defaultpremiere_lable.Size = new System.Drawing.Size(140, 15);
            this.defaultpremiere_lable.TabIndex = 9;
            this.defaultpremiere_lable.Text = "Default Premier Template";
            // 
            // chooseDefPMTemplate
            // 
            this.chooseDefPMTemplate.Location = new System.Drawing.Point(600, 101);
            this.chooseDefPMTemplate.Name = "chooseDefPMTemplate";
            this.chooseDefPMTemplate.Size = new System.Drawing.Size(130, 23);
            this.chooseDefPMTemplate.TabIndex = 10;
            this.chooseDefPMTemplate.Text = "Choose Default Path";
            this.chooseDefPMTemplate.UseVisualStyleBackColor = true;
            this.chooseDefPMTemplate.Click += new System.EventHandler(this.chooseDefPMTemplate_Click);
            // 
            // configure_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseDefPMTemplate);
            this.Controls.Add(this.defaultpremiere_lable);
            this.Controls.Add(this.conifg_default_videopath);
            this.Controls.Add(this.defaultPMFile_textbox);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.about_txtbox);
            this.Controls.Add(this.chooseDefaultPath_button);
            this.Controls.Add(this.defaultPath_txtbox);
            this.Name = "configure_settings";
            this.Text = "configure_settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox defaultPath_txtbox;
        private Button chooseDefaultPath_button;
        private RichTextBox about_txtbox;
        private Button back_button;
        private Button Cancel_button;
        private TextBox defaultPMFile_textbox;
        private Label conifg_default_videopath;
        private Label defaultpremiere_lable;
        private Button chooseDefPMTemplate;
    }
}