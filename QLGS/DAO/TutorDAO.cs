using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLGS.DTO;

namespace QLGS.DAO
{
    public class TutorDAO
    {
        private static TutorDAO instance;
        public static TutorDAO Instance
        {
            get { if (instance == null) instance = new TutorDAO(); return instance; }
            private set { TutorDAO.instance = value; }
        }
        private TutorDAO() { }
        public List<Tutor> LoadListTutor()
        {
            List<Tutor> TutorList = new List<Tutor>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TUTOR");
            foreach (DataRow item in data.Rows)
            {
                Tutor Tutor = new Tutor(item);
                TutorList.Add(Tutor);
            }
            TutorList.RemoveAt(0);
            return TutorList;
        }

        public DataTable LoadListTutorGridView()
        {
            string query = "SELECT idTutor as [ID], name as [Họ tên], userName as [Tài khoản], password as [Mật khẩu], phone as [SĐT], address as [Địa chỉ], identityNumber as [CMND] FROM TUTOR";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<Tutor> LoadListTutorByID(DataTable TutorID)
        {
            string query = "SELECT * FROM TUTOR WHERE idTutor = " + TutorID.Rows[0][0].ToString();
            for (int i = 1; i < TutorID.Rows.Count; i++)
            {
                query += " OR idTutor = " + TutorID.Rows[i][0].ToString();
            }
            List<Tutor> TutorList = new List<Tutor>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                Tutor Tutor = new Tutor(item);
                TutorList.Add(Tutor);
            }

            return TutorList;
        }

        public int GetTutorIDByUserName(string userName)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT idTutor FROM TUTOR WHERE userName = '" + userName + "'");
            return int.Parse(data.Rows[0][0].ToString());
        }

        public Tutor LoadTutorInfoByID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM TUTOR WHERE idTutor = " + id);
            Tutor tutor = new Tutor(data.Rows[0]);
            return tutor;
        }

        public bool Login(string userName, string passWord)
        {
            string query = "SELECT * FROM TUTOR WHERE userName = N'" + userName + "' AND password = N'" + passWord + "' ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count > 0;
        }

        public DataTable LoadTutorIDSearch(string subject, string grade, string gender, string title, string address)
        {
            string query = "SELECT DISTINCT TUTOR.idTutor FROM TUTOR INNER JOIN TUITION ON TUTOR.idTutor = TUITION.idTutor WHERE TUITION.Subject = N'" + subject + "' AND TUITION.Grade = '" + grade + "'" + gender + title + address;
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public int InsertTutor(Tutor tutor, string picpath)
        {
            string query = "INSERT INTO TUTOR(name, userName, password, accountType, phone, email, identityNumber, gender, birth, address, status, title, workPlace, description, pic) "
                + "SELECT N'" + tutor.Name + "', '" + tutor.UserName + "', '" + tutor.Password + "', " + tutor.AccountType + ", '" + tutor.Phone + "', '" + tutor.Email + "', " + tutor.IdentityNumber + ", N'" + tutor.Gender + "', " + tutor.Birth + ", N'" + tutor.Address + "', " + tutor.Status + ", N'" + tutor.Title + "', N'" + tutor.WorkPlace + "', N'" + tutor.Description + "', "
                + "BulkColumn FROM Openrowset( Bulk '" + picpath + "', Single_Blob) as img";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int UpdateTutor(Tutor tutor)
        {
            string query = "UPDATE TUTOR SET phone = '" + tutor.Phone + "', address = N'" + tutor.Address + "', email = '" + tutor.Email + "', identityNumber = '" + tutor.IdentityNumber + "', birth = '" + tutor.Birth + "', gender = N'" + tutor.Gender + "', status = " + tutor.Status + ", title = N'" + tutor.Title + "', workPlace = N'" + tutor.WorkPlace + "', description = N'" + tutor.Description + "' WHERE idTutor = " + tutor.ID;
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int UpdatePic(string picpath, int tutorID)
        {
            string query = "UPDATE TUTOR SET pic = (SELECT BulkColumn FROM OPENROWSET(BULK N'" + picpath + "', SINGLE_BLOB) AS img) WHERE idTutor = " + tutorID;
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int CheckPassword(string password, int tutorID)
        {            
            return DataProvider.Instance.ExecuteNonQuery("UPDATE TUTOR SET password = '" + password + "' WHERE idTutor = " + tutorID);
        }

        public DataTable SearchByName(string name)
        {
            return DataProvider.Instance.ExecuteQuery("SELECT idTutor as [ID], name as [Họ tên], userName as [Tài khoản], password as [Mật khẩu], phone as [SĐT], address as [Địa chỉ], identityNumber as [CMND] FROM TUTOR WHERE name LIKE N'%" + name + "%'");
        }

        public int DeleteTutor(int id)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM TUTOR WHERE idTutor = " + id);
        }

        public DataTable LoadAllIDTutor()
        {
            DataTable data = new DataTable();
            data = DataProvider.Instance.ExecuteQuery("SELECT idTutor FROM TUTOR ORDER BY idTutor ASC");
            data.Rows.Remove(data.Rows[0]);
            return data;
        }
    }
}
