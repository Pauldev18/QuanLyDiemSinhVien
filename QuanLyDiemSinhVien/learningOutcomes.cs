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
    public partial class learningOutcomes : Form
    {
        private long? userId;
        public learningOutcomes(long? userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void learningOutcomes_Load(object sender, EventArgs e)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            var query = from Grading in data.Gradings
                        join mh in data.Subjects on Grading.subject_id equals mh.id
                        join gv in data.Teachers on Grading.teacher_id equals gv.id
                        where Grading.student_id == userId
                        select new
                        {
                            Subject = mh.name,
                            Teacher = gv.fullname,
                            Grade = Grading.grade,
                            Criteria = Grading.criteria
                        };
            dataGrading.DataSource = query.ToList();
            dataGrading.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
