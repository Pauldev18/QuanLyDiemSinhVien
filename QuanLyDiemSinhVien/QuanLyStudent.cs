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
    public partial class QuanLyStudent : Form
    {
        private long? adminId;
        public QuanLyStudent(long? adminID)
        {
            InitializeComponent();
            this.adminId = adminID;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.code = txt_code.Text;
            student.fullname = txt_fullname.Text;
            student.email = txt_email.Text;
            student.phone = txt_phone.Text;
            student.address = txt_address.Text;
            student.gender = Convert.ToByte(txt_gender.Text);
            student.birthday = Convert.ToDateTime(txt_birthday.Text);
            student.created_at = DateTime.Now;
            student.updated_at = DateTime.Now;
            data.Students.InsertOnSubmit(student);
            data.SubmitChanges();
            MessageBox.Show("thêm thành công");
            LoadData();
            txt_code.Text = "";
            txt_address.Text = "";
            txt_birthday.Text = "";
            txt_email.Text = "";
            txt_fullname.Text = "";
            txt_gender.Text = "";
            txt_phone.Text = "";
            txt_status.Text = "";
        }
        private void LoadData()
        {
            data = new DataClasses1DataContext();
            data_qlsv.DataSource = data.Students;
            data_qlsv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void QuanLyStudent_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private int editId;
        private void data_qlsv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_qlsv.Rows[e.RowIndex];
            txt_code.Text = row.Cells["code"].Value.ToString();
            txt_birthday.Text = row.Cells["birthday"].Value.ToString();
            txt_address.Text = row.Cells["address"].Value.ToString();
            txt_email.Text = row.Cells["email"].Value.ToString();
            txt_fullname.Text = row.Cells["fullname"].Value.ToString();
            txt_gender.Text = row.Cells["gender"].Value.ToString();
            txt_status.Text = row.Cells["status"].Value.ToString();
            txt_phone.Text = row.Cells["phone"].Value.ToString();
            editId = Convert.ToInt32(row.Cells["id"].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student editStudent = data.Students.Where(st => st.id == editId).FirstOrDefault();
            if (editStudent != null)
            {
                editStudent.code = txt_code.Text;
                editStudent.birthday = Convert.ToDateTime(txt_birthday.Text);
                editStudent.phone = txt_phone.Text;
                editStudent.email = txt_email.Text;
                editStudent.updated_at = DateTime.Now;
                editStudent.address = txt_address.Text;
                editStudent.status =Convert.ToByte(txt_status.Text);
                editStudent.gender = Convert.ToByte(txt_gender.Text);
                editStudent.fullname = txt_fullname.Text;
                data.SubmitChanges();
                MessageBox.Show("Sua thanh cong");
                LoadData();
            }
            else
            {
                MessageBox.Show("Not found");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student delete = data.Students.Where(st => st.id == editId).FirstOrDefault();
            if (delete != null)
            {
                data.Students.DeleteOnSubmit(delete);
                data.SubmitChanges();
                MessageBox.Show("Xóa thành công");
                LoadData();
            }
        }
    }
}
