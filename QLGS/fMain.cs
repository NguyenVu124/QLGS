using QLGS.DAO;
using QLGS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGS
{
    public partial class fMain : Form
    {
        public int id;

        public fMain()
        {
            InitializeComponent();
            loadAllTutorList();
            loadSearchComboBox();
        }

        public void loadCurrentTutor(int id)
        {
            Tutor tutor = TutorDAO.Instance.LoadTutorInfoByID(id);
            if (tutor.AccountType == 0)
                StripMenuAdmin.Enabled = true;
            else
                StripMenuTutor.Enabled = true;
        }

        void loadAllTutorList()
        {
            List<Tutor> tableList = TutorDAO.Instance.LoadListTutor();
            loadTutorListOnPanel(tableList);
        }

        void loadSearchComboBox()
        {
            comboBoxSubject.DataSource = TuitionTableDAO.Instance.GetSubjectList();
            comboBoxSubject.DisplayMember = "Subject";

            comboBoxGrade.DataSource = TuitionTableDAO.Instance.GetGradeList();
            comboBoxGrade.DisplayMember = "Grade";

            List<String> gender = new List<string>() { "Tất cả", "Nam", "Nữ" };
            comboBoxGender.DataSource = gender;

            List<String> title = new List<string>() { "Tất cả", "Sinh viên", "Giảng viên" };
            comboBoxTitle.DataSource = title;

            List<String> address = new List<string>() { "Tất cả", "Hải Châu", "Cẩm Lệ", "Thanh Khê", "Liên Chiểu", "Ngũ Hành Sơn", "Sơn Trà", "Hòa Vang" };
            comboBoxAddress.DataSource = address;
        }

        void loadTutorListOnPanel(List<Tutor> tableList)
        {
            foreach (Tutor item in tableList)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel() { Width = 100, Height = 160 };
                FlowLayoutPanel info = new FlowLayoutPanel() { Width = 450, Height = 160 };

                PictureBox pic = new PictureBox();
                pic.Size = new System.Drawing.Size(110, 150);
                MemoryStream memoryStream = new MemoryStream(item.Pic);
                pic.Image = Image.FromStream(memoryStream);
                pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

                Label des = new Label();
                des.Size = new System.Drawing.Size(300, 150);
                des.Text = "\r\nMã gia sư: " + item.ID + "\r\n\r\n" + "Tên gia sư: " + item.Name + "\r\n\r\n" + "Chức vụ: " + item.Title + "\r\n\r\n" + "Nơi làm việc: " + item.WorkPlace;

                Button detail = new Button();
                detail.Text = "Xem chi tiết";
                detail.Size = new System.Drawing.Size(120, 40);
                detail.BackColor = Color.FromArgb(10, 94, 242);
                detail.ForeColor = Color.White;
                detail.Click += buttonDetail_Click;
                detail.Tag = item;

                panel.Controls.Add(pic);
                info.Controls.Add(des);
                info.Controls.Add(detail);
                flowLayoutPanel1.Controls.Add(panel);
                flowLayoutPanel1.Controls.Add(info);
            }
        }

        private void buttonDetail_Click(object sender, EventArgs e)
        {
            int id = ((sender as Button).Tag as Tutor).ID;
            fDetail f = new fDetail();
            f.LoadData(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        string getGenderSearch()
        {
            if (comboBoxGender.Text.ToString() != "Tất cả")
            {
                return " AND TUTOR.gender = N'" + comboBoxGender.Text + "'";
            }
            return "";
        }

        string getTitleSearch()
        {
            if (comboBoxTitle.Text.ToString() != "Tất cả")
            {
                return " AND TUTOR.title = N'" + comboBoxTitle.Text + "'";
            }
            return "";
        }

        string getAddressSearch()
        {
            if (comboBoxAddress.Text.ToString() != "Tất cả")
            {
                return " AND TUTOR.address = N'" + comboBoxAddress.Text + "'";
            }
            return "";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (comboBoxSubject.Text != "" && comboBoxGrade.Text != "")
            {
                flowLayoutPanel1.Controls.Clear();
                
                DataTable listTutor = TutorDAO.Instance.LoadTutorIDSearch(comboBoxSubject.Text, comboBoxGrade.Text, getGenderSearch(), getTitleSearch(), getAddressSearch());
                if (listTutor.Rows.Count != 0)
                {
                    List<Tutor> tableList = TutorDAO.Instance.LoadListTutorByID(listTutor);
                    loadTutorListOnPanel(tableList);
                }
            }
            else
            {
                MessageBox.Show("Chọn môn và khối lớp", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            loadAllTutorList();
        }

        private void StripMenuLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void StripMenuAddICourseInfo_Click(object sender, EventArgs e)
        {
            fCourseInfo f = new fCourseInfo();
            f.LoadCourseInfo(id);
            f.id = id;
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void StripMenuUpdateAccount_Click(object sender, EventArgs e)
        {
            fUpdateData f = new fUpdateData();
            f.LoadTutorInfo(id);
            f.id = id;
            this.Hide();
            f.ShowDialog();
            flowLayoutPanel1.Controls.Clear();
            this.loadAllTutorList();
            this.Show();
        }

        private void StripMenuAdminAddCourse_Click(object sender, EventArgs e)
        {
            fCourse f = new fCourse();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void StripMenustatistics_Click(object sender, EventArgs e)
        {
            fStatistics f = new fStatistics();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void StripMenuAccountManager_Click(object sender, EventArgs e)
        {
            fAccountManager f = new fAccountManager();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
