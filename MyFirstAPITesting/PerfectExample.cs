using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MyFirstAPITesting
{
    public class PerfectExample
    {

    }

    public class TokenRequestPayLoad
    {
        public string grant_type { get; set; }
    }

    public class TokenResponseOKPayload
    {
        public string access_token { get; set; }
        public string created_at { get; set; }
        public string expires_in { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public string account_id { get; set; }
    }

    public class TokenResponseNotOKPayload
    {
        public string error { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public string message { get; set; }
    }

    public class RefreshTokenRequestPayload
    {
        public string grant_type { get; set; }
        public string access_token { get; set; }
        public string refresh_token { get; set; }
    }
    public class RefreshTokenResponseOKPayload
    {
        public string access_token { get; set; }
        public string created_at { get; set; }
        public string expires_in { get; set; }
        public string refresh_token { get; set; }
        public string token_type { get; set; }
        public string account_id { get; set; }
    }
    public class RefreshTokenResponseNotOKPayload
    {
        public string error { get; set; }
        public string code { get; set; }
        public string type { get; set; }
        public string message { get; set; }
    }
}
