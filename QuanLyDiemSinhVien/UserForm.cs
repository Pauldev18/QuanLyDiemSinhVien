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
    public partial class UserForm : Form
    {
        private long? userId;

        public long? UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public UserForm(long? userId)
        {
            InitializeComponent();
            this.userId = userId;
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

            pnl_sv.Controls.Add(childForm);
            pnl_sv.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void thôngTinSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new ThongTinSinhVien(userId));
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new learningOutcomes(UserId));
        }
    }


}
