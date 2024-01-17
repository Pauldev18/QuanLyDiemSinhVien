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
    public partial class InsertScore : Form
    {
        private long? teacherID;
        public InsertScore(long? teacherID)
        {
            InitializeComponent();
            this.teacherID = teacherID;
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void InsertScore_Load(object sender, EventArgs e)
        {
            data = new DataClasses1DataContext();
            var query = from grading in data.Gradings
                        join subject in data.Subjects on grading.subject_id equals subject.id
                        join student in data.Students on grading.student_id equals student.id
                        where grading.teacher_id == teacherID
                        select new
                        {
                            IDSubject = subject.id,
                            TenSubject = subject.name,
                            TenStudent = student.fullname,
                            Grade = grading.grade,
                            Criteria = grading.criteria
                        };
            data_insertScore.DataSource = query.ToList();
            data_insertScore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            var distinctQuery = query.GroupBy(q => q.IDSubject)
                          .Select(g => g.First());
            cbx_Subject.DataSource = distinctQuery.ToList();
            cbx_Subject.DisplayMember = "TenSubject";
            cbx_Subject.ValueMember = "IDSubject";


        }

        private void cbx_Subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if there is a selected item
            if (cbx_Subject.SelectedItem != null)
            {
                // Access the actual value you want to use as SubjectId
                var selectedSubject = (dynamic)cbx_Subject.SelectedItem;
                int subjectId = Convert.ToInt32(selectedSubject.IDSubject);
                var query = from grading in data.Gradings
                            join subject in data.Subjects on grading.subject_id equals subject.id
                            join student in data.Students on grading.student_id equals student.id
                            where grading.teacher_id == teacherID && grading.subject_id == subjectId
                            select new
                            {
                                tenStudent = student.fullname,
                                idStudent = student.id
                            };
                cbx_Student.DataSource = query.ToList();
                cbx_Student.DisplayMember = "tenStudent";
                cbx_Student.ValueMember = "idStudent";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            int selectedSubjectId = Convert.ToInt32(cbx_Subject.SelectedValue);
            int selectedStudentId = Convert.ToInt32(cbx_Student.SelectedValue);

            int grade = Convert.ToInt32(txt_score.Text);
            Grading grading = new Grading();
            if(grade > 90 && grade <100)
            {
                grading.criteria = "distinction";
            }
            if(grade <85 && grade > 70)
            {
                grading.criteria = "merit";
            }
            if(grade <65 && grade > 60)
            {
                grading.criteria = "pass";
            }
            if(grade <60 && grade > 0)
            {
                grading.criteria = "failed";
            }
            else
            {
                MessageBox.Show("Error");
            }
            grading.student_id = selectedStudentId;
            grading.subject_id = selectedSubjectId;
            grading.teacher_id = Convert.ToInt32(teacherID);
            grading.grade = grade.ToString();
            grading.created_at = DateTime.Now;
            grading.updated_at = DateTime.Now;
            data.Gradings.InsertOnSubmit(grading);
            data.SubmitChanges();
            MessageBox.Show("Thêm thành công");

        }
    }
}
