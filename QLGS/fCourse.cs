using QLGS.DAO;
using QLGS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGS
{
    public partial class fCourse : Form
    {
        public fCourse()
        {
            InitializeComponent();
            loadComboBoxIDTutor();
        }

        void loadComboBoxIDTutor()
        {
            comboBoxIDTutor.DataSource = TutorDAO.Instance.LoadAllIDTutor();
            comboBoxIDTutor.DisplayMember = "idTutor";
        }
        private void buttonSignupCourse_Click(object sender, EventArgs e)
        {
            Course newCourse = new Course();
            try
            {
                newCourse.TutorID = int.Parse(comboBoxIDTutor.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai ID gia sư", "Thông báo", MessageBoxButtons.OK);
            }
            newCourse.ParentsName = textBoxParentsName.Text;
            newCourse.ParentsPhone = textBoxParentsPhone.Text;
            try
            {
                newCourse.RealTuition = int.Parse(textBoxRealTution.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai học phí", "Thông báo", MessageBoxButtons.OK);
            }
            newCourse.SignUpDate = dateTimePickerSigupDate.Value.Date;

            int available = 0; 
            List<Tutor> listTutorID = TutorDAO.Instance.LoadListTutor();
            for (int i = 0; i < listTutorID.Count; i++)
            {
                if (newCourse.TutorID == listTutorID[i].ID)
                {
                    available = 1;
                    break;
                }
            }

            if (newCourse.TutorID.ToString() == "" || newCourse.ParentsName == "" || newCourse.ParentsPhone == "" || newCourse.RealTuition.ToString() == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else if (available == 0)
            {
                MessageBox.Show("Vui lòng kiểm tra lại ID gia sư", "Thông báo", MessageBoxButtons.OK);
            }
            else if (CourseDAO.Instance.AddCourse(newCourse) != -1)
                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
            else
                MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
