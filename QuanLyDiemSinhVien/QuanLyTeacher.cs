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
    public partial class QuanLyTeacher : Form
    {
        private long? adminId;
        public QuanLyTeacher(long? AdminId)
        {
            InitializeComponent();
            this.adminId = AdminId;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void LoadData()
        {
            data = new DataClasses1DataContext();
            var query = from teacher in data.Teachers
                        join subject in data.Subjects on teacher.subject_id equals subject.id
                        select new
                        {
                            id = teacher.id,
                            TenSubject = subject.name,
                            IDSubject = subject.id,
                            Code = teacher.code,
                            email = teacher.email,
                            phone = teacher.phone,
                            fullname = teacher.fullname,
                            address = teacher.address,
                            gender= teacher.gender,
                            status = teacher.status,
                            birthday = teacher.birthday,
                            created_at = teacher.created_at,
                            updated_at = teacher.updated_at
                        };
            data_qltc.DataSource = query.ToList();
            data_qltc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_qltc.Columns["IDSubject"].Visible = false;
            cbx_subject.DataSource = data.Subjects;
            cbx_subject.DisplayMember = "name";
            cbx_subject.ValueMember = "id";


        }
        private void QuanLyTeacher_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            int subjectId = Convert.ToInt32(cbx_subject.SelectedValue);
            teacher.subject_id = subjectId;
            teacher.code = txt_code.Text;
            teacher.email = txt_email.Text;
            teacher.phone = txt_phone.Text;
            teacher.fullname = txt_fullname.Text;
            teacher.address = txt_address.Text;
            teacher.gender = Convert.ToByte(txt_gender.Text);
            teacher.status = Convert.ToByte(txt_status.Text);  
            teacher.birthday = Convert.ToDateTime(txt_birthday.Text);
            teacher.created_at = DateTime.Now;
            teacher.updated_at = DateTime.Now;

            data.Teachers.InsertOnSubmit(teacher);
            data.SubmitChanges();
            MessageBox.Show("Add Success");
            LoadData();
            txt_code.Text = "";
            txt_address.Text = "";
            txt_birthday.Text = "";
            txt_email.Text = "";
            txt_fullname.Text = "";
            txt_gender.Text = "";
            txt_phone.Text = "";
        }

        
        private int editID;
        private void data_qltc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_qltc.Rows[e.RowIndex];
            cbx_subject.Text = row.Cells["TenSubject"].Value.ToString();
            txt_code.Text = row.Cells["Code"].Value.ToString();
            txt_email.Text = row.Cells["email"].Value.ToString();
            txt_phone.Text = row.Cells["phone"].Value.ToString();
            txt_fullname.Text = row.Cells["fullname"].Value.ToString();
            txt_address.Text = row.Cells["address"].Value.ToString();
            txt_gender.Text = row.Cells["gender"].Value.ToString();
            txt_status.Text = row.Cells["status"].Value.ToString();
            txt_birthday.Text = row.Cells["birthday"].Value.ToString();
            editID = Convert.ToInt32(row.Cells["id"].Value.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Teacher edit = data.Teachers.Where(tc => tc.id == editID).FirstOrDefault();
            edit.subject_id = Convert.ToInt32(cbx_subject.SelectedValue);
            edit.code = txt_code.Text;
            edit.email = txt_email.Text;
            edit.phone = txt_phone.Text;
            edit.fullname = txt_fullname.Text;
            edit.address = txt_address.Text;
            edit.gender = Convert.ToByte(txt_gender.Text);
            edit.status = Convert.ToByte(txt_status.Text);
            edit.birthday = Convert.ToDateTime(txt_birthday.Text);
            edit.updated_at = DateTime.Now;
            data.SubmitChanges();
            MessageBox.Show("Edit Success");
            LoadData();
            txt_code.Text = "";
            txt_address.Text = "";
            txt_birthday.Text = "";
            txt_email.Text = "";
            txt_fullname.Text = "";
            txt_gender.Text = "";
            txt_phone.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Teacher delete = data.Teachers.Where(tc => tc.id == editID).FirstOrDefault();
            data.Teachers.DeleteOnSubmit(delete);
            data.SubmitChanges();
            MessageBox.Show("Delete Success");
            LoadData();
        }
    }
}
