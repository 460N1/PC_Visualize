namespace PC_Visualize
{
    partial class frmLogOn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogOn));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblFIEK = new System.Windows.Forms.Label();
            this.btnLogOn = new System.Windows.Forms.Button();
            this.btnPyetje = new System.Windows.Forms.Button();
            this.btnKontrollo = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.shutDownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sleepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(668, 265);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(118, 20);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyUp);
            // 
            // lblFIEK
            // 
            this.lblFIEK.AutoSize = true;
            this.lblFIEK.BackColor = System.Drawing.Color.Transparent;
            this.lblFIEK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFIEK.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFIEK.Location = new System.Drawing.Point(600, 245);
            this.lblFIEK.Name = "lblFIEK";
            this.lblFIEK.Size = new System.Drawing.Size(40, 16);
            this.lblFIEK.TabIndex = 1;
            this.lblFIEK.Text = "FIEK";
            this.lblFIEK.Click += new System.EventHandler(this.lblFIEK_Click);
            // 
            // btnLogOn
            // 
            this.btnLogOn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogOn.BackgroundImage = global::PC_Visualize.Properties.Resources.btn;
            this.btnLogOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOn.FlatAppearance.BorderSize = 0;
            this.btnLogOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOn.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLogOn.Location = new System.Drawing.Point(792, 263);
            this.btnLogOn.Name = "btnLogOn";
            this.btnLogOn.Size = new System.Drawing.Size(90, 22);
            this.btnLogOn.TabIndex = 2;
            this.btnLogOn.Text = "LogOn";
            this.btnLogOn.UseVisualStyleBackColor = false;
            this.btnLogOn.Click += new System.EventHandler(this.btnLogOn_Click);
            // 
            // btnPyetje
            // 
            this.btnPyetje.BackColor = System.Drawing.Color.Transparent;
            this.btnPyetje.BackgroundImage = global::PC_Visualize.Properties.Resources.btnHelp1;
            this.btnPyetje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPyetje.FlatAppearance.BorderSize = 0;
            this.btnPyetje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPyetje.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPyetje.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPyetje.Location = new System.Drawing.Point(879, 263);
            this.btnPyetje.Name = "btnPyetje";
            this.btnPyetje.Size = new System.Drawing.Size(37, 24);
            this.btnPyetje.TabIndex = 3;
            this.btnPyetje.UseVisualStyleBackColor = false;
            this.btnPyetje.Click += new System.EventHandler(this.btnPyetje_Click);
            // 
            // btnKontrollo
            // 
            this.btnKontrollo.BackgroundImage = global::PC_Visualize.Properties.Resources.btn;
            this.btnKontrollo.FlatAppearance.BorderSize = 0;
            this.btnKontrollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKontrollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKontrollo.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKontrollo.Location = new System.Drawing.Point(904, 490);
            this.btnKontrollo.Name = "btnKontrollo";
            this.btnKontrollo.Size = new System.Drawing.Size(68, 22);
            this.btnKontrollo.TabIndex = 4;
            this.btnKontrollo.Text = "Statusi";
            this.btnKontrollo.UseVisualStyleBackColor = true;
            this.btnKontrollo.Click += new System.EventHandler(this.btnKontrollo_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.AutoSize = false;
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.Image = global::PC_Visualize.Properties.Resources.btnShutDown;
            this.toolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(71, 26);
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shutDownToolStripMenuItem,
            this.toolStripSeparator1,
            this.restartToolStripMenuItem,
            this.sleepToolStripMenuItem});
            this.toolStripMenuItem2.Image = global::PC_Visualize.Properties.Resources.btnOthers;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(26, 26);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // shutDownToolStripMenuItem
            // 
            this.shutDownToolStripMenuItem.Name = "shutDownToolStripMenuItem";
            this.shutDownToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.shutDownToolStripMenuItem.Text = "ShutDown";
            this.shutDownToolStripMenuItem.Click += new System.EventHandler(this.shutDownToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
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
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(9, 485);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(105, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // frmLogOn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PC_Visualize.Properties.Resources.bg_LogOn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 524);
            this.Controls.Add(this.btnKontrollo);
            this.Controls.Add(this.btnPyetje);
            this.Controls.Add(this.btnLogOn);
            this.Controls.Add(this.lblFIEK);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogOn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kompjuteri";
            this.Load += new System.EventHandler(this.frmLogOn_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblFIEK;
        private System.Windows.Forms.Button btnLogOn;
        private System.Windows.Forms.Button btnPyetje;
        private System.Windows.Forms.Button btnKontrollo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem shutDownToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sleepToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}