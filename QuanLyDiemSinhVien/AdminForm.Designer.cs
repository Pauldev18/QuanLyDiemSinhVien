namespace QuanLyDiemSinhVien
{
    partial class AdminForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýGiáoViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSubjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Admin = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSinhViênToolStripMenuItem,
            this.quảnLýGiáoViênToolStripMenuItem,
            this.quảnLýLToolStripMenuItem,
            this.quảnLýSubjectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýSinhViênToolStripMenuItem
            // 
            this.quảnLýSinhViênToolStripMenuItem.Name = "quảnLýSinhViênToolStripMenuItem";
            this.quảnLýSinhViênToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.quảnLýSinhViênToolStripMenuItem.Text = "Quản lý sinh viên";
            this.quảnLýSinhViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSinhViênToolStripMenuItem_Click);
            // 
            // quảnLýGiáoViênToolStripMenuItem
            // 
            this.quảnLýGiáoViênToolStripMenuItem.Name = "quảnLýGiáoViênToolStripMenuItem";
            this.quảnLýGiáoViênToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.quảnLýGiáoViênToolStripMenuItem.Text = "Quản lý giáo viên";
            this.quảnLýGiáoViênToolStripMenuItem.Click += new System.EventHandler(this.quảnLýGiáoViênToolStripMenuItem_Click);
            // 
            // quảnLýLToolStripMenuItem
            // 
            this.quảnLýLToolStripMenuItem.Name = "quảnLýLToolStripMenuItem";
            this.quảnLýLToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.quảnLýLToolStripMenuItem.Text = "Quản lý course";
            this.quảnLýLToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLToolStripMenuItem_Click);
            // 
            // quảnLýSubjectToolStripMenuItem
            // 
            this.quảnLýSubjectToolStripMenuItem.Name = "quảnLýSubjectToolStripMenuItem";
            this.quảnLýSubjectToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.quảnLýSubjectToolStripMenuItem.Text = "Quản lý subject";
            this.quảnLýSubjectToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSubjectToolStripMenuItem_Click);
            // 
            // pnl_Admin
            // 
            this.pnl_Admin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Admin.Location = new System.Drawing.Point(0, 27);
            this.pnl_Admin.Name = "pnl_Admin";
            this.pnl_Admin.Size = new System.Drawing.Size(800, 422);
            this.pnl_Admin.TabIndex = 1;
            this.pnl_Admin.Resize += new System.EventHandler(this.pnl_Admin_Resize);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_Admin);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýGiáoViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSubjectToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_Admin;
    }
}