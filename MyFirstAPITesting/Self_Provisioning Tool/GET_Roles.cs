using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPITesting.Self_Provisioning_Tool
{
    public class GET_Roles
    {
        string resourceUrl = "https://api.<us_or_eu>.onelogin.com/api/1/roles";
        //header parameters: Authorization=bearer: access_token 

        public class GET_Roles_Data //This is the jSON data
        {         
            public string role_name { get; set; }
            public Int64 role_id { get; set; }
            
        }

    }
}
