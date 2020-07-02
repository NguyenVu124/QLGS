using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGS.DTO
{
    public class TuitionTable
    {
        private int idTuition;
        private int idTutor;
        private string subject;
        private string grade;
        private float tuition;
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public string Subject { get => subject; set => subject = value; }
        public string Grade { get => grade; set => grade = value; }
        public float Tuition { get => tuition; set => tuition = value; }
        public int IdTuition { get => idTuition; set => idTuition = value; }

        public TuitionTable(int idTuition, int idTutor, string subject, string grade, float tuition)
        {
            this.IdTuition = idTuition;
            this.IdTutor = idTutor;
            this.Subject = subject;
            this.Grade = grade;
            this.Tuition = tuition;
        }

        public TuitionTable(DataRow row)
        {
            this.idTuition = (int)row["idTuition"];
            this.IdTutor = (int)row["idTutor"];
            this.Subject = row["Subject"].ToString();
            this.Grade = row["Grade"].ToString();
            this.Tuition = float.Parse(row["tuition"].ToString());
        }
    }
}
