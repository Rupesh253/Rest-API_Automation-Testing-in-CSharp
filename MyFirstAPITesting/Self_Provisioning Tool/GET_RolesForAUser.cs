using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPITesting
{
    public class GET_RolesForAUser
    {
        string resourceUrl = "https://api.<us_or_eu>.onelogin.com/api/1/users/:id/roles";
        //header parameters: bearer: access_token 
        //query parameter : user id

        public class GET_RolesForAUser_Data //This is the jSON data
        {
            public Int64 user_id { get; set; }
            public string role_name { get; set; }
            public Int64 role_id { get; set; }           
        }

    }
}
