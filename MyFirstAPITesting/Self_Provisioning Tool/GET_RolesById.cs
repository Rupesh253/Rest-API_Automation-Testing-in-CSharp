using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPITesting
{
    public class GET_RolesById
    {
        string resourceUrl = "https://api.<us_or_eu>.onelogin.com/api/1/roles/:id";
        //header parameters: Authorization=bearer: access_token 
        //query/resource parameter : user id   
        public class GET_RolesById_Data //This is the jSON data
        {
            public Int64 user_id { get; set; }
            public string role_name { get; set; }
            public Int64 role_id { get; set; }

        }
    }
}
