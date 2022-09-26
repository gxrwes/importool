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
            this.about_txtbox.Location = new System.Drawing.Point(29, 103);
            this.about_txtbox.Name = "about_txtbox";
            this.about_txtbox.Size = new System.Drawing.Size(539, 276);
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
            // configure_settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}