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
    public partial class fSignup : Form
    {
        public fSignup()
        {
            InitializeComponent();
            loadAddress();
        }

        void loadAddress()
        {
            List<String> address = new List<string>() { "Hải Châu", "Cẩm Lệ", "Thanh Khê", "Liên Chiểu", "Ngũ Hành Sơn", "Sơn Trà", "Hòa Vang" };
            comboBoxAddress.DataSource = address;
        }

        void resetForm()
        {
            textBoxUserName.Text = "";
            textBoxPassword.Text = "";
            textBoxRePassword.Text = "";
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxIndentityNumber.Text = "";
            textBoxEmail.Text = "";
            textBoxBirth.Text = "";
            textBoxDescription.Text = "";
            textBoxWorkPlace.Text = "";
        }

        private void buttonSignUpAccount_Click(object sender, EventArgs e)
        {
            Tutor tutor = new Tutor();
            tutor.UserName = textBoxUserName.Text;
            tutor.Password = textBoxPassword.Text;
            tutor.AccountType = 1;
            tutor.Name = textBoxName.Text;
            tutor.Phone = textBoxPhone.Text;
            tutor.Email = textBoxEmail.Text;
            tutor.IdentityNumber = textBoxIndentityNumber.Text;
            tutor.Birth = textBoxBirth.Text;
            tutor.Address = comboBoxAddress.Text;
            tutor.Status = 1;
            tutor.WorkPlace = textBoxWorkPlace.Text;
            tutor.Description = textBoxDescription.Text;
            tutor.Gender = (radioButtonNam.Checked) ? radioButtonNam.Text : radioButtonNu.Text;
            tutor.Title = (radioButtonSV.Checked) ? radioButtonSV.Text : radioButtonGV.Text;

            if (tutor.UserName == "" || tutor.Password == "" || tutor.Name == "" || tutor.Phone == "" || tutor.Email == "" || tutor.IdentityNumber.ToString() == "" || tutor.Birth == "" || tutor.WorkPlace == "" || tutor.Address == "" || tutor.Description == "" || textBoxRePassword.Text == "" || textBoxPicPath.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            else if (textBoxPassword.Text != textBoxRePassword.Text) 
            {
                MessageBox.Show("Mật khẩu nhập lại không đúng!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int count = TutorDAO.Instance.InsertTutor(tutor, textBoxPicPath.Text);

                if (count != -1)
                {
                    tutor.ID = TutorDAO.Instance.GetTutorIDByUserName(tutor.UserName);
                    TuitionTableDAO.Instance.InsertDefaultTuitionByID(tutor.ID);
                    MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK);
                    resetForm();
                }
            }
        }

        private void buttonImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "JPEG file|*.jpg";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                textBoxPicPath.Text = oFile.FileName;
            }
        }

        private void buttonExitSignUpForm_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
