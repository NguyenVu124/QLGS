using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGS.DTO
{
    public class Course
    {
        private int courseID;
        public int CourseID { get => courseID; set => courseID = value; }

        private int tutorID;
        public int TutorID { get => tutorID; set => tutorID = value; }

        private string parentsName;
        public string ParentsName { get => parentsName; set => parentsName = value; }

        private string parentsPhone;
        public string ParentsPhone { get => parentsPhone; set => parentsPhone = value; }

        private int realTuition;
        public int RealTuition { get => realTuition; set => realTuition = value; }

        private DateTime signUpDate;
        public DateTime SignUpDate { get => signUpDate; set => signUpDate = value; }


        public Course() { }
        
        public Course(int courseID, int tutorID, string parentsName, string parentsPhone, int realTuition, DateTime signUpDate)
        {
            this.CourseID = courseID;
            this.TutorID = tutorID;
            this.ParentsName = parentsName;
            this.ParentsPhone = parentsPhone;
            this.RealTuition = realTuition;
            this.SignUpDate = signUpDate;
        }


        public Course(DataRow row)
        {
            this.CourseID = (int)row["idCourse"];
            this.TutorID = (int)row["idTutor"];
            this.ParentsName = row["nameOfParents"].ToString();
            this.ParentsPhone = row["phoneOfParents"].ToString();
            this.RealTuition = (int)row["realTuition"];
            this.SignUpDate = (DateTime)row["signUpDate"];
        }
    }
}
