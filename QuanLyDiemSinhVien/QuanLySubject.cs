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
    public partial class QuanLySubject : Form
    {
        private long? adminId;
        public QuanLySubject(long? adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void LoadData()
        {
            data = new DataClasses1DataContext();
            var query = from subject in data.Subjects
                        join course in data.Courses on subject.course_id equals course.id
                        select new
                        {
                            IDCourse = course.id,
                            IDSubject = subject.id,
                            Course = course.name,
                            Name = subject.name
                        };
          
            data_subject.DataSource = query.ToList();
            data_subject.Columns["IDCourse"].Visible = false;
            data_subject.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //
            cbx_course.DataSource = query.ToList();
            cbx_course.DisplayMember = "Course";
            cbx_course.ValueMember = "IDCourse";

        }
        private void button1_Click(object sender, EventArgs e)
        {
           Subject subject = new Subject();
            subject.course_id = Convert.ToInt32(cbx_course.SelectedValue);
            subject.name = txt_name.Text;
            subject.created_at = DateTime.Now;
            subject.updated_at = DateTime.Now;
            data.Subjects.InsertOnSubmit(subject);
            data.SubmitChanges();
            MessageBox.Show("Add Success");
            txt_name.Text = "";
            LoadData();
        }

        private void QuanLySubject_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private int editID;
        private void data_subject_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_subject.Rows[e.RowIndex];
            cbx_course.Text = row.Cells["Course"].Value.ToString();
            txt_name.Text = row.Cells["Name"].Value.ToString();
            editID = Convert.ToInt32(row.Cells["IDSubject"].Value.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subject subject = data.Subjects.Where(s => s.id == editID).FirstOrDefault();
            if (subject != null)
            {
                subject.course_id = Convert.ToInt32(cbx_course.SelectedValue);
                subject.name = txt_name.Text;
                subject.updated_at = DateTime.Now;
                data.SubmitChanges();
                MessageBox.Show("Edit Success");
                txt_name.Text = "";
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subject delete = data.Subjects.Where(s => s.id == editID).FirstOrDefault();
            if(delete != null)
            {
                data.Subjects.DeleteOnSubmit(delete);
                data.SubmitChanges();
                MessageBox.Show("Delete Success");
                LoadData();
            }
        }
    }
}
