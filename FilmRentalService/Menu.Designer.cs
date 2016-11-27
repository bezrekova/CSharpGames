namespace FilmRentalService
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmGenreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fimmNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filmrentalPriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFilmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.filmNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.writerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1,
            this.writerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(264, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.addToolStripMenuItem,
            this.displayToolStripMenuItem,
            this.toolStripMenuItem1});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(42, 20);
            this.toolStripComboBox1.Text = "Film";
            this.toolStripComboBox1.Click += new System.EventHandler(this.toolStripComboBox1_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmGenreToolStripMenuItem,
            this.fimmNameToolStripMenuItem,
            this.filmrentalPriceToolStripMenuItem});
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.findToolStripMenuItem.Text = "Find";
            // 
            // filmGenreToolStripMenuItem
            // 
            this.filmGenreToolStripMenuItem.Name = "filmGenreToolStripMenuItem";
            this.filmGenreToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.filmGenreToolStripMenuItem.Text = "FilmGenre";
            this.filmGenreToolStripMenuItem.Click += new System.EventHandler(this.filmGenreToolStripMenuItem_Click);
            // 
            // fimmNameToolStripMenuItem
            // 
            this.fimmNameToolStripMenuItem.Name = "fimmNameToolStripMenuItem";
            this.fimmNameToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.fimmNameToolStripMenuItem.Text = "FilmName";
            this.fimmNameToolStripMenuItem.Click += new System.EventHandler(this.fimmNameToolStripMenuItem_Click);
            // 
            // filmrentalPriceToolStripMenuItem
            // 
            this.filmrentalPriceToolStripMenuItem.Name = "filmrentalPriceToolStripMenuItem";
            this.filmrentalPriceToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.filmrentalPriceToolStripMenuItem.Text = "FilmRentalPrice";
            this.filmrentalPriceToolStripMenuItem.Click += new System.EventHandler(this.filmrentalPriceToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFilmToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // newFilmToolStripMenuItem
            // 
            this.newFilmToolStripMenuItem.Name = "newFilmToolStripMenuItem";
            this.newFilmToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newFilmToolStripMenuItem.Text = "NewRental";
            this.newFilmToolStripMenuItem.Click += new System.EventHandler(this.newFilmToolStripMenuItem_Click);
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statisticsToolStripMenuItem,
            this.allRentalsToolStripMenuItem});
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayToolStripMenuItem.Text = "Display";
            this.displayToolStripMenuItem.Click += new System.EventHandler(this.displayToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.statisticsToolStripMenuItem.Text = "StatisticsPerDate";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // allRentalsToolStripMenuItem
            // 
            this.allRentalsToolStripMenuItem.Name = "allRentalsToolStripMenuItem";
            this.allRentalsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.allRentalsToolStripMenuItem.Text = "AllRentals";
            this.allRentalsToolStripMenuItem.Click += new System.EventHandler(this.allRentalsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filmNameToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Delete";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // filmNameToolStripMenuItem
            // 
            this.filmNameToolStripMenuItem.Name = "filmNameToolStripMenuItem";
            this.filmNameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.filmNameToolStripMenuItem.Text = "FilmName";
            this.filmNameToolStripMenuItem.Click += new System.EventHandler(this.filmNameToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 243);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(146, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Click me";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // writerToolStripMenuItem
            // 
            this.writerToolStripMenuItem.Name = "writerToolStripMenuItem";
            this.writerToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.writerToolStripMenuItem.Text = "Writer";
            this.writerToolStripMenuItem.Click += new System.EventHandler(this.writerToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(264, 296);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "RentalService";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmGenreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fimmNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem filmrentalPriceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFilmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filmNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writerToolStripMenuItem;
    }
}

