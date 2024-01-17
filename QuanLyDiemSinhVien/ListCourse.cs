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
    public partial class ListCourse : Form
    {
        private long? teacherID;
        public ListCourse(long? teacherID)
        {
            InitializeComponent();
            this.teacherID = teacherID;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();

        private void ListCourse_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var query = from grading in data.Gradings
                        join subject in data.Subjects on grading.subject_id equals subject.id
                        join course in data.Courses on subject.id equals course.id
                        where grading.teacher_id == teacherID
                        select new
                        {
                            IDSubject = subject.id,
                            subject = subject.name,
                            course = course.name,
                            start = course.start_date,
                            end = course.end_date
                        };
            var distinctQuery = query.GroupBy(q => q.IDSubject)
                           .Select(g => g.First());

            data_listCourse.DataSource = distinctQuery.ToList();
            data_listCourse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

    }
}
