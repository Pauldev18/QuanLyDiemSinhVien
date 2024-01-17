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
    public partial class QuanLyCourse : Form
    {
        private long? adminId;
        public QuanLyCourse(long? adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void LoadData()
        {
            data = new DataClasses1DataContext();
            data_course.DataSource = data.Courses;
            data_course.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Course course = new Course();
            course.name = txt_name.Text;
            course.start_date = Convert.ToDateTime(txt_startDate.Text);
            course.end_date = Convert.ToDateTime(txt_endDate.Text);
            course.open_year = Convert.ToDateTime(txt_openYear.Text);
            course.status = Convert.ToByte(txt_status.Text);
            course.created_at = DateTime.Now;
            course.updated_at = DateTime.Now;
            data.Courses.InsertOnSubmit(course);
            data.SubmitChanges();
            MessageBox.Show("Add Success");
            txt_endDate.Text = "";
            txt_startDate.Text = "";
            txt_status.Text = "";
            txt_openYear.Text = "";
            txt_name.Text = "";
            LoadData();
           
        }

        private void QuanLyCourse_Load(object sender, EventArgs e)
        {
            LoadData();
        }

       
        private int editID;
        private void data_course_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = data_course.Rows[e.RowIndex];
            txt_name.Text = row.Cells["name"].Value.ToString();
            txt_startDate.Text = row.Cells["start_date"].Value.ToString();
            txt_endDate.Text = row.Cells["end_date"].Value.ToString();
            txt_openYear.Text = row.Cells["open_year"].Value.ToString();
            txt_status.Text = row.Cells["status"].Value.ToString();
            editID = Convert.ToInt32(row.Cells["id"].Value.ToString());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Course editCourse = data.Courses.Where(c => c.id ==  editID).FirstOrDefault();
            if (editCourse != null)
            {
                editCourse.name = txt_name.Text;
                editCourse.start_date = Convert.ToDateTime(txt_startDate.Text);
                editCourse.end_date = Convert.ToDateTime(txt_endDate.Text);
                editCourse.open_year = Convert.ToDateTime(txt_openYear.Text);
                editCourse.status = Convert.ToByte(txt_status.Text);
                editCourse.updated_at = DateTime.Now;
                data.SubmitChanges();
                MessageBox.Show("Edit Success");
                txt_endDate.Text = "";
                txt_startDate.Text = "";
                txt_status.Text = "";
                txt_openYear.Text = "";
                txt_name.Text = "";
                LoadData();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Course delete = data.Courses.Where(c => c.id == editID).FirstOrDefault();
            if (delete != null)
            {
                data.Courses.DeleteOnSubmit(delete);
                data.SubmitChanges();
                LoadData();
                MessageBox.Show("Delete Sucess");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
