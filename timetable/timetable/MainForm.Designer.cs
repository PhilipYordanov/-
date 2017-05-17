namespace timetable
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистърНаСлужителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прегледНаСлужителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.регистърToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прегледНаСписъкСПроектиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списъкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.регистърНаСлужителиToolStripMenuItem,
            this.регистърToolStripMenuItem,
            this.списъкToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(1065, 43);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изходToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.файлToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.файлToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(78, 39);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // изходToolStripMenuItem
            // 
            this.изходToolStripMenuItem.Name = "изходToolStripMenuItem";
            this.изходToolStripMenuItem.Size = new System.Drawing.Size(166, 40);
            this.изходToolStripMenuItem.Text = "Изход";
            this.изходToolStripMenuItem.Click += new System.EventHandler(this.изходToolStripMenuItem_Click);
            // 
            // регистърНаСлужителиToolStripMenuItem
            // 
            this.регистърНаСлужителиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прегледНаСлужителиToolStripMenuItem});
            this.регистърНаСлужителиToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.регистърНаСлужителиToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.регистърНаСлужителиToolStripMenuItem.Name = "регистърНаСлужителиToolStripMenuItem";
            this.регистърНаСлужителиToolStripMenuItem.Size = new System.Drawing.Size(294, 39);
            this.регистърНаСлужителиToolStripMenuItem.Text = "Регистър на служители";
            // 
            // прегледНаСлужителиToolStripMenuItem
            // 
            this.прегледНаСлужителиToolStripMenuItem.Name = "прегледНаСлужителиToolStripMenuItem";
            this.прегледНаСлужителиToolStripMenuItem.Size = new System.Drawing.Size(294, 40);
            this.прегледНаСлужителиToolStripMenuItem.Text = "Работа с данните";
            this.прегледНаСлужителиToolStripMenuItem.Click += new System.EventHandler(this.прегледНаСлужителиToolStripMenuItem_Click);
            // 
            // регистърToolStripMenuItem
            // 
            this.регистърToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прегледНаСписъкСПроектиToolStripMenuItem});
            this.регистърToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.регистърToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.регистърToolStripMenuItem.Name = "регистърToolStripMenuItem";
            this.регистърToolStripMenuItem.Size = new System.Drawing.Size(230, 39);
            this.регистърToolStripMenuItem.Text = "Списък с проекти";
          
            // 
            // прегледНаСписъкСПроектиToolStripMenuItem
            // 
            this.прегледНаСписъкСПроектиToolStripMenuItem.Name = "прегледНаСписъкСПроектиToolStripMenuItem";
            this.прегледНаСписъкСПроектиToolStripMenuItem.Size = new System.Drawing.Size(295, 40);
            this.прегледНаСписъкСПроектиToolStripMenuItem.Text = "Работа с проекти";
            this.прегледНаСписъкСПроектиToolStripMenuItem.Click += new System.EventHandler(this.прегледНаСписъкСПроектиToolStripMenuItem_Click);
            // 
            // списъкToolStripMenuItem
            // 
            this.списъкToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.списъкToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.списъкToolStripMenuItem.Name = "списъкToolStripMenuItem";
            this.списъкToolStripMenuItem.Size = new System.Drawing.Size(244, 39);
            this.списъкToolStripMenuItem.Text = "Oтработено време";
            this.списъкToolStripMenuItem.Click += new System.EventHandler(this.списъкToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1065, 473);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.MenuText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "график време";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистърНаСлужителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem регистърToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списъкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прегледНаСлужителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прегледНаСписъкСПроектиToolStripMenuItem;
    }
}

