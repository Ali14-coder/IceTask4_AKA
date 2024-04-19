using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace prjGuisLogin
{
     class UserDB
    {
        private static User ApprovedUser = new User();


        private static List<User> userList = new List<User>();

        public List<User> GetUser (string Name)
        {
            throw new NotImplementedException();
        }
        public UserDB()
        {
            if (userList.Count == 0)
            {
                User u = new User();
                u.Name = "Jack";
                u.Password = "1234";
                userList.Add(u);
            }
        }

        public void AddUser(User user)
        {//need to add a reference
            using (IDbconnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("FitnessJunkieDB"))) ;
                userList.Add(user);
        }
        public override string ToString()
        {
            String strOutput = "";
            foreach (var item in userList)
            {
                strOutput += "Name :" + item.Name + " , Password: " + item.Password;
            }


            return strOutput;
        }

        public bool CheckUser(User user)
        {
            bool Valid = false;
            foreach(var item in userList)
            {
                if (item.Name.Equals(user.Name))
                {
                    if(item.Password.Equals(user.Password))
                    {
                        Valid = true;
                        ApprovedUser=item;
                        break;
                    }
                }
            }
            return Valid;
        }
        public bool CheckIfExists(string user)
        {
            bool bFound = false;
            foreach(var item in userList)
            {
                if(item.Equals(user))
                {
                    bFound = true;
                    break;
                }
            }
            return bFound;
        }

        internal string CurrentUser()
        {
            return ApprovedUser.Name;
        }


    }
}
