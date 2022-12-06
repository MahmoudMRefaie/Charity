
namespace Charity
{
    partial class Main_Page
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
            this.show_allData = new System.Windows.Forms.Button();
            this.show_widower = new System.Windows.Forms.Button();
            this.show_divorced = new System.Windows.Forms.Button();
            this.mainPage_exit = new System.Windows.Forms.Button();
            this.show_orphans = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // show_allData
            // 
            this.show_allData.Location = new System.Drawing.Point(589, 78);
            this.show_allData.Name = "show_allData";
            this.show_allData.Size = new System.Drawing.Size(139, 42);
            this.show_allData.TabIndex = 0;
            this.show_allData.Text = "عرض البيانات";
            this.show_allData.UseVisualStyleBackColor = true;
            this.show_allData.Click += new System.EventHandler(this.show_allData_Click);
            // 
            // show_widower
            // 
            this.show_widower.Location = new System.Drawing.Point(63, 78);
            this.show_widower.Name = "show_widower";
            this.show_widower.Size = new System.Drawing.Size(146, 42);
            this.show_widower.TabIndex = 1;
            this.show_widower.Text = "بيانات الأرامل";
            this.show_widower.UseVisualStyleBackColor = true;
            this.show_widower.Click += new System.EventHandler(this.show_widower_Click);
            // 
            // show_divorced
            // 
            this.show_divorced.Location = new System.Drawing.Point(63, 164);
            this.show_divorced.Name = "show_divorced";
            this.show_divorced.Size = new System.Drawing.Size(146, 39);
            this.show_divorced.TabIndex = 2;
            this.show_divorced.Text = "بيانات المطلقات";
            this.show_divorced.UseVisualStyleBackColor = true;
            this.show_divorced.Click += new System.EventHandler(this.show_divorced_Click);
            // 
            // mainPage_exit
            // 
            this.mainPage_exit.Location = new System.Drawing.Point(702, 407);
            this.mainPage_exit.Name = "mainPage_exit";
            this.mainPage_exit.Size = new System.Drawing.Size(86, 31);
            this.mainPage_exit.TabIndex = 3;
            this.mainPage_exit.Text = "خروج";
            this.mainPage_exit.UseVisualStyleBackColor = true;
            this.mainPage_exit.Click += new System.EventHandler(this.mainPage_exit_Click);
            // 
            // show_orphans
            // 
            this.show_orphans.Location = new System.Drawing.Point(63, 249);
            this.show_orphans.Name = "show_orphans";
            this.show_orphans.Size = new System.Drawing.Size(146, 40);
            this.show_orphans.TabIndex = 4;
            this.show_orphans.Text = "بيانات الأيتام";
            this.show_orphans.UseVisualStyleBackColor = true;
            this.show_orphans.Click += new System.EventHandler(this.show_orphans_Click);
            // 
            // Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.show_orphans);
            this.Controls.Add(this.mainPage_exit);
            this.Controls.Add(this.show_divorced);
            this.Controls.Add(this.show_widower);
            this.Controls.Add(this.show_allData);
            this.Name = "Main_Page";
            this.Text = "Main Page";
            this.Load += new System.EventHandler(this.Main_Page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button show_allData;
        private System.Windows.Forms.Button show_widower;
        private System.Windows.Forms.Button show_divorced;
        private System.Windows.Forms.Button mainPage_exit;
        private System.Windows.Forms.Button show_orphans;
    }
}