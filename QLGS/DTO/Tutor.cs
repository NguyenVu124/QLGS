using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLGS.DTO
{
    public class Tutor
    {
        private string gender;
        public string Gender { get => gender; set => gender = value; }

        private string birth;
        public string Birth { get => birth; set => birth = value; }

        private string address;
        public string Address { get => address; set => address = value; }

        private int id;
        public int ID { get => id; set => id = value; }

        private string name;
        public string Name { get => name; set => name = value; }

        private string workPlace;
        public string WorkPlace { get => workPlace; set => workPlace = value; }

        private string title;
        public string Title { get => title; set => title = value; }

        private Byte[] pic;
        public Byte[] Pic { get => pic; set => pic = value; }

        private string userName;
        public string UserName { get => userName; set => userName = value; }
        
        private string password;
        public string Password { get => password; set => password = value; }

        private int accountType;
        public int AccountType { get => accountType; set => accountType = value; }

        private string phone;
        public string Phone { get => phone; set => phone = value; }

        private string email;
        public string Email { get => email; set => email = value; }

        private string identityNumber;
        public string IdentityNumber { get => identityNumber; set => identityNumber = value; }

        private int status;
        public int Status { get => status; set => status = value; }

        private string description;
        public string Description { get => description; set => description = value; }


        public Tutor() { }

        public Tutor(int id, string userName, string password, int accountType, string name, string phone, string email, string identityNumber, string gender, string birth, string address, int status, string workPlace, string title, string desciption, byte[] pic) 
        {
            this.ID = id;
            this.UserName = userName;
            this.Password = password;
            this.AccountType = accountType;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.IdentityNumber = identityNumber;
            this.Gender = gender;
            this.Birth = birth;
            this.Address = address;
            this.Status = status;
            this.Title = title;
            this.WorkPlace = workPlace;
            this.Description = desciption;
            this.Pic = pic;
        }

        public Tutor(DataRow row)
        {
            this.ID = (int)row["idTutor"];
            this.UserName = row["userName"].ToString();
            this.Password = row["password"].ToString();
            this.AccountType = (int)row["accountType"];
            this.Name = row["name"].ToString();
            this.Phone = row["phone"].ToString();
            this.Email = row["email"].ToString();
            this.IdentityNumber = row["identityNumber"].ToString();
            this.Gender = row["gender"].ToString();
            this.Birth = row["birth"].ToString();
            this.Address = row["address"].ToString();
            this.Status = (int)row["status"];
            this.WorkPlace = row["workPlace"].ToString();
            this.Title = row["title"].ToString();
            this.Description = row["description"].ToString();
            this.Pic = (Byte[])row["pic"];
        }
    }
}
