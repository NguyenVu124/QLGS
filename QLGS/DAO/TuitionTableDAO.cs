using QLGS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGS.DAO
{
    public class TuitionTableDAO
    {
        private static TuitionTableDAO instance;
        public static TuitionTableDAO Instance
        {
            get { if (instance == null) instance = new TuitionTableDAO(); return instance; }
            private set { TuitionTableDAO.instance = value; }
        }
        private TuitionTableDAO() { }

        public List<TuitionTable> LoadListTuitionByID(int id)
        {
            List<TuitionTable> TuitionList = new List<TuitionTable>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TUITION WHERE idTutor = " + id);

            foreach (DataRow item in data.Rows)
            {
                TuitionTable tuition = new TuitionTable(item);
                TuitionList.Add(tuition);
            }

            return TuitionList;
        }

        public void InsertDefaultTuitionByID(int tutorID)
        {
            string queryTuition = "INSERT INTO TUITION (idTutor, Subject, Grade, tuition) VALUES ('" + tutorID + "', '', '', 0)";
            for (int i = 1; i <= 4; i++)
            {
                DataProvider.Instance.ExecuteNonQuery(queryTuition);
            }
        }

        public int UpdateTuition(TuitionTable tuition)
        {
            string query = "UPDATE TUITION SET Subject = N'" + tuition.Subject + "', Grade = '" + tuition.Grade + "', tuition = " + tuition.Tuition + "  WHERE idTuition = " + tuition.IdTuition;
            int count = DataProvider.Instance.ExecuteNonQuery(query);
            return count;
        }

        public DataTable GetSubjectList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT DISTINCT Subject FROM TUITION ORDER BY Subject ASC");
        }

        public DataTable GetGradeList()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT DISTINCT Grade FROM TUITION ORDER BY Grade ASC");
        }
    }
}
