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
    public partial class fUpdateData : Form
    {
        public int id;
        public fUpdateData()
        {
            InitializeComponent();

        }

        public void LoadTutorInfo(int id)
        {
            Tutor tutor = TutorDAO.Instance.LoadTutorInfoByID(id);
            labelName.Text = tutor.Name;
            textBoxPhone.Text = tutor.Phone;
            textBoxEmail.Text = tutor.Email;
            textBoxIdentityNumber.Text = tutor.IdentityNumber.ToString();
            textBoxWorkPlace.Text = tutor.WorkPlace;
            textBoxDescription.Text = tutor.Description;
            List<String> address = new List<string>() { tutor.Address, "Hải Châu", "Cẩm Lệ", "Thanh Khê", "Liên Chiểu", "Ngũ Hành Sơn", "Sơn Trà", "Hòa Vang" };
            comboBoxAddress.DataSource = address;
            textBoxBirth.Text = tutor.Birth;
            if (tutor.Gender == "Nam")
                radioButtonNam.Checked = true;
            else
                radioButtonNu.Checked = true;
            if (tutor.Status == 1)
                radioButtonStatus1.Checked = true;
            else
                radioButtonStatus0.Checked = true;
            if (tutor.Title == "Sinh viên")
                radioButtonSV.Checked = true;
            else
                radioButtonGV.Checked = true;

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            Tutor tutor = TutorDAO.Instance.LoadTutorInfoByID(id);
            tutor.Phone = textBoxPhone.Text;
            tutor.Address = comboBoxAddress.Text;
            tutor.Email = textBoxEmail.Text;
            tutor.IdentityNumber = textBoxIdentityNumber.Text;
            tutor.Birth = textBoxBirth.Text;
            tutor.Gender = radioButtonNam.Checked == true ? radioButtonNam.Text : radioButtonNu.Text;
            tutor.Status = radioButtonStatus1.Checked == true ? 1 : 0;
            tutor.Title = radioButtonSV.Checked == true ? radioButtonSV.Text : radioButtonGV.Text;
            tutor.WorkPlace = textBoxWorkPlace.Text;
            tutor.Description = textBoxDescription.Text;

            
            if (textBoxImagePath.Text == "")
            {
                int count = TutorDAO.Instance.UpdateTutor(tutor);
                if (count != -1)
                    MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Thay đổi không thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                int count1 = TutorDAO.Instance.UpdateTutor(tutor);          
                int count2 = TutorDAO.Instance.UpdatePic(textBoxImagePath.Text, tutor.ID);
                if (count1 != -1 && count2 != -1)
                    MessageBox.Show("Thay đổi thành công", "Thông báo", MessageBoxButtons.OK);
                else
                    MessageBox.Show("Thay đổi không thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog oFile = new OpenFileDialog();
            oFile.Filter = "JPEG file|*.jpg";
            if (oFile.ShowDialog() == DialogResult.OK)
            {
                textBoxImagePath.Text = oFile.FileName;
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            Tutor tutor = TutorDAO.Instance.LoadTutorInfoByID(id);
            if (textBoxPassword.Text == "" || textBoxNewPassword.Text == "" || textBoxReNewPassword.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }

            else if (textBoxPassword.Text.ToString() != tutor.Password.Trim())
            {
                MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (textBoxNewPassword.Text != textBoxReNewPassword.Text)
                {
                    MessageBox.Show("Mật khẩu mới nhập lại không đúng", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    tutor.Password = textBoxNewPassword.Text;
                    int count = TutorDAO.Instance.CheckPassword(tutor.Password, tutor.ID);
                    if (count != -1)
                    {
                        MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                    
                }
            }
            
        }
    }
}
