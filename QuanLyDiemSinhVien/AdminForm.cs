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
    public partial class AdminForm : Form
    {
        private long? adminId;

        public long? AdminId
        {
            get { return adminId; }
            set { adminId = value; }
        }

        public AdminForm(long? adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
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

            pnl_Admin.Controls.Add(childForm);
            pnl_Admin.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyStudent(AdminId));
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyTeacher(AdminId));
        }

        private void quảnLýLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLyCourse(AdminId));
        }

        private void quảnLýSubjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new QuanLySubject(AdminId));
        }

        private void pnl_Admin_Resize(object sender, EventArgs e)
        {
            FormCollection fc = Application.OpenForms;
            foreach (Form f in fc)
            {
                if (f.Name == "QuanLyStudent")
                {
                    f.Height = pnl_Admin.Height;
                    f.Width = pnl_Admin.Width;
                }
              
            }
        }
    }
}
