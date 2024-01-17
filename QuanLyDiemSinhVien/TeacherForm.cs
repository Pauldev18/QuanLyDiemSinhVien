using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiemSinhVien
{
    public partial class TeacherForm : Form
    {
        private long? teacherId;

        public long? TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }

        public TeacherForm(long? teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
        }
        private Form currentFormChild;
        private void openChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnl_teacher.Controls.Add(childForm);
            pnl_teacher.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new InsertScore(TeacherId));
        }

        private void xemDanhSáchMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ListCourse(TeacherId));
        }
    }
}
