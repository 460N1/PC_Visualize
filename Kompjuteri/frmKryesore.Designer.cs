namespace PC_Visualize
{
    partial class frmKryesore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKryesore));
            this.taskbar = new System.Windows.Forms.Panel();
            this.lblOra = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnStart = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Programet = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEmriProgramit = new System.Windows.Forms.Label();
            this.btnTrego = new System.Windows.Forms.Button();
            this.btnHape = new System.Windows.Forms.Button();
            this.btnKontrollo = new System.Windows.Forms.Button();
            this.btnNdryshoBG = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.taskbar.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // taskbar
            // 
            this.taskbar.BackgroundImage = global::PC_Visualize.Properties.Resources.taskbar;
            this.taskbar.Controls.Add(this.lblOra);
            this.taskbar.Controls.Add(this.menuStrip1);
            this.taskbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.taskbar.Location = new System.Drawing.Point(0, 484);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(984, 40);
            this.taskbar.TabIndex = 0;
            // 
            // lblOra
            // 
            this.lblOra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOra.BackColor = System.Drawing.Color.Transparent;
            this.lblOra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOra.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOra.Location = new System.Drawing.Point(884, 5);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(97, 35);
            this.lblOra.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStart});
            this.menuStrip1.Location = new System.Drawing.Point(0, -2);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(104, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.MouseLeave += new System.EventHandler(this.menuStrip1_MouseLeave);
            this.menuStrip1.MouseHover += new System.EventHandler(this.menuStrip1_MouseHover);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = false;
            this.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStart.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.sleepToolStripMenuItem,
            this.shutDownToolStripMenuItem});
            this.btnStart.Image = global::PC_Visualize.Properties.Resources.btnStart;
            this.btnStart.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStart.Name = "btnStart";
            this.btnStart.Padding = new System.Windows.Forms.Padding(0);
            this.btnStart.Size = new System.Drawing.Size(54, 42);
            this.btnStart.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.restartToolStripMenuItem.Text = "Restart";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // sleepToolStripMenuItem
            // 
            this.sleepToolStripMenuItem.Name = "sleepToolStripMenuItem";
            this.sleepToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.sleepToolStripMenuItem.Text = "Sleep";
            this.sleepToolStripMenuItem.Click += new System.EventHandler(this.sleepToolStripMenuItem_Click);
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.shutDownToolStripMenuItem.Text = "ShutDown";
            this.shutDownToolStripMenuItem.Click += new System.EventHandler(this.shutDownToolStripMenuItem_Click);
            // 
            // Programet
            // 
            this.Programet.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Programet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Programet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Programet.FormattingEnabled = true;
            this.Programet.ItemHeight = 24;
            this.Programet.Location = new System.Drawing.Point(73, 141);
            this.Programet.Name = "Programet";
            this.Programet.Size = new System.Drawing.Size(244, 240);
            this.Programet.TabIndex = 1;
            this.Programet.SelectedIndexChanged += new System.EventHandler(this.lstProgramet_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lblEmriProgramit);
            this.panel1.Controls.Add(this.btnTrego);
            this.panel1.Controls.Add(this.btnHape);
            this.panel1.Location = new System.Drawing.Point(646, 141);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 240);
            this.panel1.TabIndex = 2;
            // 
            // lblEmriProgramit
            // 
            this.lblEmriProgramit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmriProgramit.Location = new System.Drawing.Point(17, 16);
            this.lblEmriProgramit.Name = "lblEmriProgramit";
            this.lblEmriProgramit.Size = new System.Drawing.Size(252, 96);
            this.lblEmriProgramit.TabIndex = 2;
            this.lblEmriProgramit.Text = "Emri i programit:\r\nAsnje program nuk eshte i zgjedhur!";
            // 
            // btnTrego
            // 
            this.btnTrego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrego.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTrego.Location = new System.Drawing.Point(80, 185);
            this.btnTrego.Name = "btnTrego";
            this.btnTrego.Size = new System.Drawing.Size(134, 31);
            this.btnTrego.TabIndex = 1;
            this.btnTrego.Text = "Trego Vetite";
            this.btnTrego.UseVisualStyleBackColor = true;
            this.btnTrego.Click += new System.EventHandler(this.btnTrego_Click);
            // 
            // btnHape
            // 
            this.btnHape.Enabled = false;
            this.btnHape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHape.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHape.Location = new System.Drawing.Point(80, 134);
            this.btnHape.Name = "btnHape";
            this.btnHape.Size = new System.Drawing.Size(134, 31);
            this.btnHape.TabIndex = 0;
            this.btnHape.Text = "Hape";
            this.btnHape.UseVisualStyleBackColor = true;
            this.btnHape.Click += new System.EventHandler(this.btnHape_Click);
            // 
            // btnKontrollo
            // 
            this.btnKontrollo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnKontrollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontrollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKontrollo.Location = new System.Drawing.Point(726, 12);
            this.btnKontrollo.Name = "btnKontrollo";
            this.btnKontrollo.Size = new System.Drawing.Size(120, 57);
            this.btnKontrollo.TabIndex = 3;
            this.btnKontrollo.Text = "Kontrollo Statusin";
            this.btnKontrollo.UseVisualStyleBackColor = false;
            this.btnKontrollo.Click += new System.EventHandler(this.btnKontrollo_Click);
            // 
            // btnNdryshoBG
            // 
            this.btnNdryshoBG.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnNdryshoBG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNdryshoBG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNdryshoBG.Location = new System.Drawing.Point(860, 12);
            this.btnNdryshoBG.Name = "btnNdryshoBG";
            this.btnNdryshoBG.Size = new System.Drawing.Size(112, 57);
            this.btnNdryshoBG.TabIndex = 4;
            this.btnNdryshoBG.Text = "Ndrysho BG";
            this.btnNdryshoBG.UseVisualStyleBackColor = false;
            this.btnNdryshoBG.Click += new System.EventHandler(this.btnNdryshoBG_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmKryesore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 524);
            this.Controls.Add(this.btnNdryshoBG);
            this.Controls.Add(this.btnKontrollo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Programet);
            this.Controls.Add(this.taskbar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKryesore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kompjuteri";
            this.Load += new System.EventHandler(this.frmKryesore_Load);
            this.taskbar.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel taskbar;
        private System.Windows.Forms.ListBox Programet;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblEmriProgramit;
        private System.Windows.Forms.Button btnTrego;
        private System.Windows.Forms.Button btnHape;
        private System.Windows.Forms.Button btnKontrollo;
        private System.Windows.Forms.Button btnNdryshoBG;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnStart;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sleepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
    }
}