using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPITesting.Self_Provisioning_Tool
{
    public class PUT_UpdateUserById
    {
        string resourceUrl = "https://api.<us_or_eu>.onelogin.com/api/1/users/:id";
        //header parameters: Authorization=bearer: access_token 
        //header parameters: Content-Type = application/json
        //query/resource parameter : user id  
        //request parameters: any fields of user data
    }
}
