using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPITesting
{
    public class GET_Users
    {
        string resourceUrl = "https://api.<us_or_eu>.onelogin.com/api/1/users";
        //header parameters: bearer: access_token 
        //multiple query parameters : email,alias, domain, first name , last name ,role id, role name 

        public class GET_Users_Data //This is the jSON data
        {
            public string domain { get; set; }
            public string email { get; set; }
            public string alias { get; set; }
            public string username { get; set; }
            public string firstname { get; set; }
            public string lastname { get; set; }
            public Int64 user_id { get; set; }
            public DateTime created_at { get; set; }
            public DateTime updated_at { get; set; }
            public string role_name { get; set; }
            public Int64 role_id { get; set; }
            public string company { get; set; }
            public string message { get; set; }
        }

        

    }
}
