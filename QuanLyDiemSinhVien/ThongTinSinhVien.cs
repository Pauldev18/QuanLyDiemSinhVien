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
    public partial class ThongTinSinhVien : Form
    {
        private long? userId;

        public ThongTinSinhVien(long? userId)
        {
            InitializeComponent();
            this.userId = userId;
            // Now you can use this.userId in the rest of your ThongTinSinhVien form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(userId.ToString());
        }

        private void ThongTinSinhVien_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            var students = data.Students.Where(st => st.id == userId).FirstOrDefault();
            txt_msv.Text = students.code;
            txt_fullname.Text = students.fullname;
            txt_email.Text = students.email;
            txt_birthday.Text = students.birthday.ToString();
            txt_address.Text = students.address;
            txt_gender.Text = students.gender.ToString();
            txt_phone.Text = students.phone;
            txt_status.Text = students.status.ToString();
        }
    }
}
