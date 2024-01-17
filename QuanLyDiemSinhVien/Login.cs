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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        DataClasses1DataContext data = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            var username = txt_user.Text;
            var pass = txt_pass.Text;
            var user = data.Users.Where(u => u.email == username && u.password == pass).FirstOrDefault();

            if (user != null)
            {              
                    switch (user.role_id)
                    {
                        case 1:
                            int userId = (int)user.student_id;
                            OpenUserForm(userId);
                            break;
                   
                        case 2:
                            int admin = (int)user.admin_id;
                            OpenAdminForm(admin);
                            break;
                        case 3:
                                int teacherId = (int)user.teacher_id;
                                OpenTeacherForm(teacherId);
                            break;
                    }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void OpenUserForm(long? userId)
        {
            // Mở form của User và truyền userId
            UserForm userForm = new UserForm(userId);
            userForm.Show();
            this.Hide();
        }
        private void OpenTeacherForm(long? teacherId)
        {
            TeacherForm teacherForm = new TeacherForm(teacherId);
            teacherForm.Show();
            this.Hide();
        }
        private void OpenAdminForm(long? adminId)
        {
            AdminForm adminForm = new AdminForm(adminId);
            adminForm.Show();
            this.Hide();
        }


    }
}

