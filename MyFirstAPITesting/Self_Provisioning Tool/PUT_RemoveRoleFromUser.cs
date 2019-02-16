using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPITesting
{
    public class PUT_RemoveRoleFromUser
    {
        string resourceUrl = "https://api.<us_or_eu>.onelogin.com/api/1/users/:id/remove_roles";
        //header parameters: Authorization=bearer: access_token &
        //header parameters: Content-Type = application/json
        //resource parameter: user_id
        //request parameter: role_name,role_id
        //request body
        /*{
             "role_name":"Admin",
             "role_id":"1",
        }*/


    }
}
}
