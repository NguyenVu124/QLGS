using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGS.DTO
{
    public class LearnTime
    {
        private int idLearnTime;
        private int idTutor;
        private string session;
        private string day;
        public int IdLearnTime { get => idLearnTime; set => idLearnTime = value; }
        public int IdTutor { get => idTutor; set => idTutor = value; }
        public string Session { get => session; set => session = value; }
        public string Day { get => day; set => day = value; }

        public LearnTime(int idLearnTime, int idTutor, string session, string day)
        {
            this.IdLearnTime = idLearnTime;
            this.IdTutor = idTutor;
            this.Session = session;
            this.Day = day;
        }

        public LearnTime(int idTutor, string session, string day)
        {
            this.IdTutor = idTutor;
            this.Session = session;
            this.Day = day;
        }

        public LearnTime(DataRow row)
        {
            this.IdLearnTime = (int)row["idLearnTime"];
            this.idTutor = (int)row["idTutor"];
            this.Session = row["session"].ToString();
            this.Day = row["day"].ToString();
        }
    }


}
