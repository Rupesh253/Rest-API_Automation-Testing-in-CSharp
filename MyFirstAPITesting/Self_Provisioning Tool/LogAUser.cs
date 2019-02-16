using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAPITesting.Self_Provisioning_Tool
{
    public class LogAUser
    {
        //resource url= create login session token endpoint 
        //request parameters: username_0r_email,password,domain
        /*{
            "username_or_email":"ashley.akua",
            "password":"P@33w0rd!",
            "subdomain":"jhainc"
         }*/
        //response
        /*
       {
            "status": {
                        "type": "success",
                        "message": "Success",
                        "code": 200,
                        "error": false
                      },
            "data": [
                      {
                       "status": "Authenticated",
              "user": {
               "username": "ashley.akua",
               "email": "ashley.akua@onelogin.com",
               "firstname": "Ashley",
               "id": 88888888,
               "lastname": "Akua"
           },
           "return_to_url": null,
           "expires_at": "2016/01/07 05:56:21 +0000",
           "session_token": "9x8869x31134x7906x6x54474x21x18xxx90857x"
       }
   ]
}*/
    }
}
