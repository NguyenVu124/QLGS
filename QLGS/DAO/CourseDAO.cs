using QLGS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGS.DAO
{
    public class CourseDAO
    {
        private static CourseDAO instance;
        public static CourseDAO Instance
        {
            get { if (instance == null) instance = new CourseDAO(); return instance; }
            private set { CourseDAO.instance = value; }
        }
        private CourseDAO() { }

        public int AddCourse(Course course)
        {
            string query = "INSERT INTO COURSE (idTutor, nameOfParents, phoneOfParents, realTuition, signUpDate) VALUES ('" + course.TutorID + "', N'" + course.ParentsName + "', '" + course.ParentsPhone + "', " + course.RealTuition + ", '" + course.SignUpDate + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable LoadCourseList()
        {
            string query = "SELECT idCourse as [ID Khóa học], TUTOR.idTutor as [ID Gia sư], name as [Tên gia sư] , TUTOR.phone as [SĐT gia sư], nameOfParents as [Tên phụ huynh], phoneOfParents as [SĐT phụ huynh], realTuition as [Học phí], signUpDate as [Ngày đăng ký] FROM COURSE, TUTOR WHERE COURSE.idTutor = TUTOR.idTutor";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LoadCourseList(DateTime before, DateTime after)
        {
            string query = "SELECT idCourse as [ID Khóa học], TUTOR.idTutor as [ID Gia sư], name as [Tên gia sư] , TUTOR.phone as [SĐT gia sư], nameOfParents as [Tên phụ huynh], phoneOfParents as [SĐT phụ huynh], realTuition as [Học phí], signUpDate as [Ngày đăng ký] FROM COURSE, TUTOR WHERE COURSE.idTutor = TUTOR.idTutor AND signUpDate >= '" + before + "' AND signUpDate <= '" + after + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
