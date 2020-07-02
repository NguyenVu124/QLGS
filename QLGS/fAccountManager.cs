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
    public partial class fAccountManager : Form
    {
        public fAccountManager()
        {
            InitializeComponent();
            loadTutorList();
        }

        void loadTutorList()
        {
            dataGridViewListTutor.DataSource = TutorDAO.Instance.LoadListTutorGridView();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            dataGridViewListTutor.DataSource = TutorDAO.Instance.SearchByName(textBoxSearchName.Text);
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            loadTutorList();
        }

        private void dataGridViewListTutor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewListTutor.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString().Trim() != null)
            { 
                labelTutorID.Text = dataGridViewListTutor.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                labelTutorName.Text = dataGridViewListTutor.Rows[e.RowIndex].Cells["Họ tên"].Value.ToString();
            }
        }

        private void buttonUpdateData_Click(object sender, EventArgs e)
        {
            if (labelTutorID.Text.ToString() != "")
            {
                int id = int.Parse(labelTutorID.Text.ToString().Trim());
                fUpdateData f = new fUpdateData();
                f.LoadTutorInfo(id);
                f.id = id;
                this.Hide();
                f.ShowDialog();
                this.loadTutorList();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng gia sư", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void buttonCourseInfo_Click(object sender, EventArgs e)
        {
            if (labelTutorID.Text.ToString() != "")
            {
                int id = int.Parse(labelTutorID.Text.ToString().Trim());
                fCourseInfo f = new fCourseInfo();
                f.LoadCourseInfo(id);
                f.id = id;
                this.Hide();
                f.ShowDialog();
                loadTutorList();
                this.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn đúng gia sư", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void buttonAddAccount_Click(object sender, EventArgs e)
        {
            fSignup f = new fSignup();
            this.Hide();
            f.ShowDialog();
            this.Show();
            loadTutorList();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Thật sự muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                if (labelTutorID.Text.ToString() != "")
                {
                    int id = int.Parse(labelTutorID.Text.ToString().Trim());
                    TutorDAO.Instance.DeleteTutor(id);
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn đúng gia sư", "Thông báo", MessageBoxButtons.OK);
                }
                loadTutorList();
                labelTutorID.Text = "";
                labelTutorName.Text = "";
            }    
        }
    }
}
