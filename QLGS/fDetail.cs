using QLGS.DAO;
using QLGS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLGS
{
    public partial class fDetail : Form
    {
        public fDetail()
        {
            InitializeComponent();
        }

        public void LoadData(int id)
        {
            Tutor tutor = TutorDAO.Instance.LoadTutorInfoByID(id);
            labelTutorIDC.Text = tutor.ID.ToString();
            labelNameC.Text = tutor.Name;
            labelWorkPlaceC.Text = tutor.WorkPlace;
            labelTitleC.Text = tutor.Title;
            MemoryStream memoryStream = new MemoryStream(tutor.Pic);
            pictureBox.Image = Image.FromStream(memoryStream);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            labelGenderC.Text = tutor.Gender;
            labelBirthC.Text = tutor.Birth;
            labelAddressC.Text = tutor.Address;
            richTextBoxDiscription.Text = tutor.Description;

            CultureInfo culture = new CultureInfo("vi-VN");
            List<TuitionTable> tuitionList = TuitionTableDAO.Instance.LoadListTuitionByID(id);
            textBoxSubject1.Text = tuitionList[0].Subject;
            textBoxGrade1.Text = tuitionList[0].Grade;
            textBoxTuition1.Text = tuitionList[0].Tuition.ToString("c", culture);
            textBoxSubject2.Text = tuitionList[1].Subject;
            textBoxGrade2.Text = tuitionList[1].Grade;
            textBoxTuition2.Text = tuitionList[1].Tuition.ToString("c", culture);
            textBoxSubject3.Text = tuitionList[2].Subject;
            textBoxGrade3.Text = tuitionList[2].Grade;
            textBoxTuition3.Text = tuitionList[2].Tuition.ToString("c", culture);
            textBoxSubject4.Text = tuitionList[3].Subject;
            textBoxGrade4.Text = tuitionList[3].Grade;
            textBoxTuition4.Text = tuitionList[3].Tuition.ToString("c", culture);

            List<LearnTime> learntimeList = LearnTimeDAO.Instance.LoadListLearnTimeByID(id);
            for (int i = 0; i < learntimeList.Count; i++)
            {
                string daysession = (learntimeList[i].Session.ToString() + " " + learntimeList[i].Day.ToString()).Trim();
                switch (daysession)
                {
                    case "Sáng Thứ 2":
                        checkBoxMonMor.Checked = true;
                        checkBoxMonMor.Enabled = true;
                        break;
                    case "Chiều Thứ 2":
                        checkBoxMonAft.Checked = true;
                        checkBoxMonAft.Enabled = true;
                        break;
                    case "Tối Thứ 2":
                        checkBoxMonEve.Checked = true;
                        checkBoxMonEve.Enabled = true;
                        break;
                    case "Sáng Thứ 3":
                        checkBoxTueMor.Checked = true;
                        checkBoxTueMor.Enabled = true;
                        break;
                    case "Chiều Thứ 3":
                        checkBoxTueAft.Checked = true;
                        checkBoxTueAft.Enabled = true;
                        break;
                    case "Tối Thứ 3":
                        checkBoxTueEve.Checked = true;
                        checkBoxTueEve.Enabled = true;
                        break;
                    case "Sáng Thứ 4":
                        checkBoxWedMor.Checked = true;
                        checkBoxWedMor.Enabled = true;
                        break;
                    case "Chiều Thứ 4":
                        checkBoxWedAft.Checked = true;
                        checkBoxWedAft.Enabled = true;
                        break;
                    case "Tối Thứ 4":
                        checkBoxWedEve.Checked = true;
                        checkBoxWedEve.Enabled = true;
                        break;
                    case "Sáng Thứ 5":
                        checkBoxThuMor.Checked = true;
                        checkBoxThuMor.Enabled = true;
                        break;
                    case "Chiều Thứ 5":
                        checkBoxThuAft.Checked = true;
                        checkBoxThuAft.Enabled = true;
                        break;
                    case "Tối Thứ 5":
                        checkBoxThuEve.Checked = true;
                        checkBoxThuEve.Enabled = true;
                        break;
                    case "Sáng Thứ 6":
                        checkBoxFriMor.Checked = true;
                        checkBoxFriMor.Enabled = true;
                        break;
                    case "Chiều Thứ 6":
                        checkBoxFriAft.Checked = true;
                        checkBoxFriAft.Enabled = true;
                        break;
                    case "Tối Thứ 6":
                        checkBoxFriEve.Checked = true;
                        checkBoxFriEve.Enabled = true;
                        break;
                    case "Sáng Thứ 7":
                        checkBoxSatMor.Checked = true;
                        checkBoxSatMor.Enabled = true;
                        break;
                    case "Chiều Thứ 7":
                        checkBoxSatAft.Checked = true;
                        checkBoxSatAft.Enabled = true;
                        break;
                    case "Tối Thứ 7":
                        checkBoxSatEve.Checked = true;
                        checkBoxSatEve.Enabled = true;
                        break;
                    case "Sáng Chủ nhật":
                        checkBoxSunMor.Checked = true;
                        checkBoxSunMor.Enabled = true;
                        break;
                    case "Chiều Chủ nhật":
                        checkBoxSunAft.Checked = true;
                        checkBoxSunAft.Enabled = true;
                        break;
                    case "Tối Chủ nhật":
                        checkBoxSunEve.Checked = true;
                        checkBoxSunEve.Enabled = true;
                        break;
                }
            }

            /*List<LearnTime> learntimeList = LearnTimeDAO.Instance.LoadListLearnTimeByID(id);
            for (int i = 0; i < learntimeList.Count; i++)
            {
                string daysession = learntimeList[i].Session.ToString() + " " + learntimeList[i].Day.ToString();
                if (daysession == "Sáng Thứ 2") checkBoxMonMor.Checked = true;
                if (daysession == "Chiều Thứ 2") checkBoxMonAft.Checked = true;
                if (daysession == "Tối Thứ 2") checkBoxMonEve.Checked = true;
                if (daysession == "Sáng Thứ 3") checkBoxTueMor.Checked = true;
                if (daysession == "Chiều Thứ 3") checkBoxTueAft.Checked = true;
                if (daysession == "Tối Thứ 3") checkBoxTueEve.Checked = true;
                if (daysession == "Sáng Thứ 4") checkBoxWedMor.Checked = true;
                if (daysession == "Chiều Thứ 4") checkBoxWedAft.Checked = true;
                if (daysession == "Tối Thứ 4") checkBoxWedEve.Checked = true;
                if (daysession == "Sáng Thứ 5") checkBoxThuMor.Checked = true;
                if (daysession == "Chiều Thứ 5") checkBoxThuAft.Checked = true;
                if (daysession == "Tối Thứ 5") checkBoxThuEve.Checked = true;
                if (daysession == "Sáng Thứ 6") checkBoxFriMor.Checked = true;
                if (daysession == "Chiều Thứ 6") checkBoxFriAft.Checked = true;
                if (daysession == "Tối Thứ 6") checkBoxFriEve.Checked = true;
                if (daysession == "Sáng Thứ 7") checkBoxSatMor.Checked = true;
                if (daysession == "Chiều Thứ 7") checkBoxSatAft.Checked = true;
                if (daysession == "Tối Thứ 7") checkBoxSatEve.Checked = true;
                if (daysession == "Sáng Chủ nhật") checkBoxSunMor.Checked = true;
                if (daysession == "Chiều Chủ nhật") checkBoxSunAft.Checked = true;
                if (daysession == "Tối Chủ nhật") checkBoxSunEve.Checked = true;
            }*/
        }
    }
}
