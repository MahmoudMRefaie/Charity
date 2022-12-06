
namespace Charity
{
    partial class login_page
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
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_text = new System.Windows.Forms.TextBox();
            this.password_text = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(156, 119);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(73, 17);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            this.username_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(156, 218);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(69, 17);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // username_text
            // 
            this.username_text.Location = new System.Drawing.Point(362, 119);
            this.username_text.Name = "username_text";
            this.username_text.Size = new System.Drawing.Size(232, 22);
            this.username_text.TabIndex = 2;
            // 
            // password_text
            // 
            this.password_text.Location = new System.Drawing.Point(362, 218);
            this.password_text.Name = "password_text";
            this.password_text.Size = new System.Drawing.Size(232, 22);
            this.password_text.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(197, 281);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(284, 48);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(676, 356);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(75, 23);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 391);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_text);
            this.Controls.Add(this.username_text);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Name = "login_page";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_text;
        private System.Windows.Forms.TextBox password_text;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
    }
}

