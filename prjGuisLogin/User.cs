using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjGuisLogin
{
    public  class User
    {
        private string name;
        private string password;

        public User(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public string Name { get; set; }
        public string Password { get; set; }

    }

    //public string FullInfo
    //{
    //    get
    //    {
    //        return $" {Name} {Password}";
    //}
}
