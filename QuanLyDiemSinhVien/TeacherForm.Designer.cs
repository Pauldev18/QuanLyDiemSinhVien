namespace QuanLyDiemSinhVien
{
    partial class TeacherForm
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
            this.nhậpĐiểmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemDanhSáchMônHọcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_teacher = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhậpĐiểmToolStripMenuItem,
            this.xemDanhSáchMônHọcToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhậpĐiểmToolStripMenuItem
            // 
            this.nhậpĐiểmToolStripMenuItem.Name = "nhậpĐiểmToolStripMenuItem";
            this.nhậpĐiểmToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.nhậpĐiểmToolStripMenuItem.Text = "Nhập điểm";
            this.nhậpĐiểmToolStripMenuItem.Click += new System.EventHandler(this.nhậpĐiểmToolStripMenuItem_Click);
            // 
            // xemDanhSáchMônHọcToolStripMenuItem
            // 
            this.xemDanhSáchMônHọcToolStripMenuItem.Name = "xemDanhSáchMônHọcToolStripMenuItem";
            this.xemDanhSáchMônHọcToolStripMenuItem.Size = new System.Drawing.Size(151, 20);
            this.xemDanhSáchMônHọcToolStripMenuItem.Text = "Xem danh sách môn học";
            this.xemDanhSáchMônHọcToolStripMenuItem.Click += new System.EventHandler(this.xemDanhSáchMônHọcToolStripMenuItem_Click);
            // 
            // pnl_teacher
            // 
            this.pnl_teacher.Location = new System.Drawing.Point(0, 27);
            this.pnl_teacher.Name = "pnl_teacher";
            this.pnl_teacher.Size = new System.Drawing.Size(800, 421);
            this.pnl_teacher.TabIndex = 1;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_teacher);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhậpĐiểmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemDanhSáchMônHọcToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_teacher;
    }
}