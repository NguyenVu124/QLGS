using QLGS.DAO;
using QLGS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGS
{
    public partial class fCourseInfo : Form
    {
        public int id;
        public fCourseInfo()
        {
            InitializeComponent();
        }

        public void LoadCourseInfo(int id)
        {
            Tutor tutor = TutorDAO.Instance.LoadTutorInfoByID(id);
            labelCurrentTutorID.Text = tutor.ID.ToString();
            labelCurrentName.Text = tutor.Name;

            List<TuitionTable> tuitionList = TuitionTableDAO.Instance.LoadListTuitionByID(id);
            List<String> subject1 = new List<string>() { tuitionList[0].Subject.ToString(), "Toán", "Lý", "Hóa", "Sinh", "Văn", "Tiếng Anh", "Tiếng Việt", "Lịch Sử", "Địa Lý", "Tiếng Việt", "Tiếng Pháp", "" };
            comboBoxSubject1.DataSource = subject1;
            List<String> subject2 = new List<string>() { tuitionList[1].Subject.ToString(), "Toán", "Lý", "Hóa", "Sinh", "Văn", "Tiếng Anh", "Tiếng Việt", "Lịch Sử", "Địa Lý", "Tiếng Việt", "Tiếng Pháp", "" };
            comboBoxSubject2.DataSource = subject2;
            List<String> subject3 = new List<string>() { tuitionList[2].Subject.ToString(), "Toán", "Lý", "Hóa", "Sinh", "Văn", "Tiếng Anh", "Tiếng Việt", "Lịch Sử", "Địa Lý", "Tiếng Việt", "Tiếng Pháp", "" };
            comboBoxSubject3.DataSource = subject3;
            List<String> subject4 = new List<string>() { tuitionList[3].Subject.ToString(), "Toán", "Lý", "Hóa", "Sinh", "Văn", "Tiếng Anh", "Tiếng Việt", "Lịch Sử", "Địa Lý", "Tiếng Việt", "Tiếng Pháp", "" };
            comboBoxSubject4.DataSource = subject4;

            List<String> grade1 = new List<string>() { tuitionList[0].Grade.ToString(), "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "" };
            comboBoxGrade1.DataSource = grade1;
            List<String> grade2 = new List<string>() { tuitionList[1].Grade.ToString(), "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", ""};
            comboBoxGrade2.DataSource = grade2;
            List<String> grade3 = new List<string>() { tuitionList[2].Grade.ToString(), "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "" };
            comboBoxGrade3.DataSource = grade3;
            List<String> grade4 = new List<string>() { tuitionList[3].Grade.ToString(), "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "" };
            comboBoxGrade4.DataSource = grade4;

            textBoxTuition1.Text = tuitionList[0].Tuition.ToString();
            textBoxTuition2.Text = tuitionList[1].Tuition.ToString();
            textBoxTuition3.Text = tuitionList[2].Tuition.ToString();
            textBoxTuition4.Text = tuitionList[3].Tuition.ToString();

            List<LearnTime> learntimeList = LearnTimeDAO.Instance.LoadListLearnTimeByID(id);
            for (int i = 0; i < learntimeList.Count; i++)
            {
                string daysession = (learntimeList[i].Session.ToString() + " " + learntimeList[i].Day.ToString()).Trim();
                if (daysession == "Sáng Thứ 2") checkBox1.Checked = true;
                if (daysession == "Chiều Thứ 2") checkBox2.Checked = true;
                if (daysession == "Tối Thứ 2") checkBox3.Checked = true;
                if (daysession == "Sáng Thứ 3") checkBox4.Checked = true;
                if (daysession == "Chiều Thứ 3") checkBox5.Checked = true;
                if (daysession == "Tối Thứ 3") checkBox6.Checked = true;
                if (daysession == "Sáng Thứ 4") checkBox7.Checked = true;
                if (daysession == "Chiều Thứ 4") checkBox8.Checked = true;
                if (daysession == "Tối Thứ 4") checkBox9.Checked = true;
                if (daysession == "Sáng Thứ 5") checkBox10.Checked = true;
                if (daysession == "Chiều Thứ 5") checkBox11.Checked = true;
                if (daysession == "Tối Thứ 5") checkBox12.Checked = true;
                if (daysession == "Sáng Thứ 6") checkBox13.Checked = true;
                if (daysession == "Chiều Thứ 6") checkBox14.Checked = true;
                if (daysession == "Tối Thứ 6") checkBox15.Checked = true;
                if (daysession == "Sáng Thứ 7") checkBox16.Checked = true;
                if (daysession == "Chiều Thứ 7") checkBox17.Checked = true;
                if (daysession == "Tối Thứ 7") checkBox18.Checked = true;
                if (daysession == "Sáng Chủ nhật") checkBox19.Checked = true;
                if (daysession == "Chiều Chủ nhật") checkBox20.Checked = true;
                if (daysession == "Tối Chủ nhật") checkBox21.Checked = true;
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            List<TuitionTable> tuitionList = TuitionTableDAO.Instance.LoadListTuitionByID(id);
            tuitionList[0].Subject = comboBoxSubject1.Text;
            tuitionList[0].Grade = comboBoxGrade1.Text;
            tuitionList[0].Tuition = int.Parse(textBoxTuition1.Text);
            tuitionList[1].Subject = comboBoxSubject2.Text;
            tuitionList[1].Grade = comboBoxGrade2.Text;
            tuitionList[1].Tuition = int.Parse(textBoxTuition2.Text);
            tuitionList[2].Subject = comboBoxSubject3.Text;
            tuitionList[2].Grade = comboBoxGrade3.Text;
            tuitionList[2].Tuition = int.Parse(textBoxTuition3.Text);
            tuitionList[3].Subject = comboBoxSubject4.Text;
            tuitionList[3].Grade = comboBoxGrade4.Text;
            tuitionList[3].Tuition = int.Parse(textBoxTuition4.Text);
            string[] queryTuition = new string[4];
            int check = 0;
            for (int i = 0; i <= 3; i++)
            {
                if ((tuitionList[i].Subject != "") && ((tuitionList[i].Grade == "") || (tuitionList[i].Tuition.ToString() == "0")))
                {
                    MessageBox.Show("Nhập đầy đủ thông tin khóa học", "Thông báo", MessageBoxButtons.OK);
                    check--;
                }
            }

            List<LearnTime> listLearnTime = new List<LearnTime>()
            {
                new LearnTime(id, "Sáng", "Thứ 2"),
                new LearnTime(id, "Chiều", "Thứ 2"),
                new LearnTime(id, "Tối", "Thứ 2"),
                new LearnTime(id, "Sáng", "Thứ 3"),
                new LearnTime(id, "Chiều", "Thứ 3"),
                new LearnTime(id, "Tối", "Thứ 3"),
                new LearnTime(id, "Sáng", "Thứ 4"),
                new LearnTime(id, "Chiều", "Thứ 4"),
                new LearnTime(id, "Tối", "Thứ 4"),
                new LearnTime(id, "Sáng", "Thứ 5"),
                new LearnTime(id, "Chiều", "Thứ 5"),
                new LearnTime(id, "Tối", "Thứ 5"),
                new LearnTime(id, "Sáng", "Thứ 6"),
                new LearnTime(id, "Chiều", "Thứ 6"),
                new LearnTime(id, "Tối", "Thứ 6"),
                new LearnTime(id, "Sáng", "Thứ 7"),
                new LearnTime(id, "Chiều", "Thứ 7"),
                new LearnTime(id, "Tối", "Thứ 7"),
                new LearnTime(id, "Sáng", "Chủ nhật"),
                new LearnTime(id, "Chiều", "Chủ nhật"),
                new LearnTime(id, "Tối", "Chủ nhật")
            };

            LearnTimeDAO.Instance.DeleteLearnTime(id);

            if (check >= 0)
            {
                for (int i = 0; i <= 3; i++)
                {
                    {
                        TuitionTableDAO.Instance.UpdateTuition(tuitionList[i]);
                    }
                }
                if (checkBox1.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[0]);
                }
                if (checkBox2.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[1]);
                }
                if (checkBox3.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[2]);
                }
                if (checkBox4.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[3]);
                }
                if (checkBox5.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[4]);
                }
                if (checkBox6.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[5]);
                }
                if (checkBox7.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[6]);
                }
                if (checkBox8.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[7]);
                }
                if (checkBox9.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[8]);
                }
                if (checkBox10.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[9]);
                }
                if (checkBox11.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[10]);
                }
                if (checkBox12.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[11]);
                }
                if (checkBox13.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[12]);
                }
                if (checkBox14.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[13]);
                }
                if (checkBox15.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[14]);
                }
                if (checkBox16.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[15]);
                }
                if (checkBox17.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[16]);
                }
                if (checkBox18.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[17]);
                }
                if (checkBox19.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[18]);
                }
                if (checkBox20.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[19]);
                }
                if (checkBox21.Checked == true)
                {
                    LearnTimeDAO.Instance.UpdateLearnTime(listLearnTime[20]);
                }

                MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK);
            }

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void comboBoxSubject1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubject1.Text != "")
            {
                comboBoxGrade1.Enabled = true;
                textBoxTuition1.Enabled = true;
            }
            else
            {
                comboBoxGrade1.Text = "";
                comboBoxGrade1.Enabled = false;
                textBoxTuition1.Text = "0";
                textBoxTuition1.Enabled = false;
            }
        }

        private void comboBoxSubject2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubject2.Text != "")
            {
                comboBoxGrade2.Enabled = true;
                textBoxTuition2.Enabled = true;
            }
            else
            {
                comboBoxGrade2.Text = "";
                comboBoxGrade2.Enabled = false;
                textBoxTuition2.Text = "0";
                textBoxTuition2.Enabled = false;
            }
        }

        private void comboBoxSubject3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubject3.Text != "")
            {
                comboBoxGrade3.Enabled = true;
                textBoxTuition3.Enabled = true;
            }
            else
            {
                comboBoxGrade3.Text = "";
                comboBoxGrade3.Enabled = false;
                textBoxTuition3.Text = "0";
                textBoxTuition3.Enabled = false;
            }
        }

        private void comboBoxSubject4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSubject4.Text != "")
            {
                comboBoxGrade4.Enabled = true;
                textBoxTuition4.Enabled = true;
            }
            else
            {
                comboBoxGrade4.Text = "";
                comboBoxGrade4.Enabled = false;
                textBoxTuition4.Text = "0";
                textBoxTuition4.Enabled = false;
            }
        }
    }
}
