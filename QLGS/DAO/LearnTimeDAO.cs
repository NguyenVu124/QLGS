using QLGS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGS.DAO
{
    public class LearnTimeDAO
    {
        private static LearnTimeDAO instance;
        public static LearnTimeDAO Instance
        {
            get { if (instance == null) instance = new LearnTimeDAO(); return instance; }
            private set { LearnTimeDAO.instance = value; }
        }
        private LearnTimeDAO() { }

        public List<LearnTime> LoadListLearnTimeByID(int id)
        {
            List<LearnTime> TuitionList = new List<LearnTime>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM LEARNTIME WHERE idTutor = " + id);

            foreach (DataRow item in data.Rows)
            {
                LearnTime lt = new LearnTime(item);
                TuitionList.Add(lt);
            }

            return TuitionList;
        }

        public void DeleteLearnTime(int tutorID)
        {
            string query = "DELETE FROM LEARNTIME WHERE idTutor = " + tutorID;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int UpdateLearnTime(LearnTime learnTime)
        {
            string query = "INSERT INTO LEARNTIME (idTutor, session, day) VALUES ('" + learnTime.IdTutor + "', N' "+ learnTime.Session + "', N'" + learnTime.Day + "')";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

    }
}
