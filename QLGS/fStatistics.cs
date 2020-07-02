using QLGS.DAO;
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
    public partial class fStatistics : Form
    {
        public fStatistics()
        {
            InitializeComponent();
            loadCourseList();
        }

        void loadCourseList()
        {
            dataGridViewListCourse.DataSource = CourseDAO.Instance.LoadCourseList();
        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            dataGridViewListCourse.Controls.Clear();
            dataGridViewListCourse.DataSource = CourseDAO.Instance.LoadCourseList(dateTimePicker1.Value, dateTimePicker2.Value);
        }

        private void buttonRevenue_Click(object sender, EventArgs e)
        {
            DataTable data = CourseDAO.Instance.LoadCourseList(dateTimePicker1.Value, dateTimePicker2.Value);
            int revenue = 0;
            for (int i = 0; i < data.Rows.Count; i++)
            {
                revenue += int.Parse(data.Rows[i][6].ToString());
            }

            CultureInfo culture = new CultureInfo("vi-VN");
            textBoxRevenue.Text = revenue.ToString("c", culture);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            loadCourseList();
        }
    }
}
