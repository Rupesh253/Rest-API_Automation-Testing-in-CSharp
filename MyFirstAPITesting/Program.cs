using System;
using System.Net;
using System.Net.Http;
using System.Net.Cache;
using System.IO;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth;
using RestSharp.Deserializers;
using RestSharp.Extensions;
using RestSharp.Serializers;
using RestSharp.Validation;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Net.Security;
using Newtonsoft.Json.Linq;
using System.Web;

namespace FirstAPITesting
{
    public static class FirstAPITesting
    {
        public static void Main(string[] args)
        {
            SomeMethod();
            //SomeMethod1();
            //SomeMethod2();
            //SomeMethod3();
            //SomeMethod4();
            //SomeMethod5();
            //SomeMethod6();
            //SomeMethod7();
            //SomeMethod8();
        }


        public static void SomeMethod()
        {
            Console.WriteLine("SomeMethod");
            Console.WriteLine("==========");
            RestClient client = new RestClient("https://www.google.co.in");
            //client
            bool clientAllowMultipleDefaultParametersWithSameName = client.AllowMultipleDefaultParametersWithSameName;
            IAuthenticator clientAuthenticator = client.Authenticator;
            bool clientAutomaticDecompression = client.AutomaticDecompression;
            string clientBaseHost = client.BaseHost;
            Uri clientBaseUrl = client.BaseUrl;
            var clientCachePolicy = client.CachePolicy;
            X509CertificateCollection clientClientCertificates = client.ClientCertificates;
            string clientConnectionGroupName = client.ConnectionGroupName;
            CookieContainer clientCookieContainer = client.CookieContainer;
            IList<Parameter> clientDefaultParameters = client.DefaultParameters;
            Encoding clientEncoding = client.Encoding;
            bool clientFollowRedirects = client.FollowRedirects;
            int? clientMaxRedirects = client.MaxRedirects;
            bool clientPipelined = client.Pipelined;
            bool clientPreAuthenticate = client.PreAuthenticate;
            IWebProxy clientProxy = client.Proxy;
            int clientReadWriteTimeout = client.ReadWriteTimeout;
            RemoteCertificateValidationCallback clientRemoteCertificateValidationCallback = client.RemoteCertificateValidationCallback;
            int clientTimeout = client.Timeout;
            bool clientUnsafeAuthenticatedConnectionSharing = client.UnsafeAuthenticatedConnectionSharing;
            string clientUserAgent = client.UserAgent;
            bool clientUseSynchronizationContext = client.UseSynchronizationContext;

            for (int i = 1; i < 2; i++)
                Console.Beep();

            Console.WriteLine("clientAllowMultipleDefaultParametersWithSameName " + clientAllowMultipleDefaultParametersWithSameName + "\n");
            Console.WriteLine("clientAuthenticator " + clientAuthenticator + "\n");
            Console.WriteLine("clientAutomaticDecompression " + clientAutomaticDecompression + "\n");
            Console.WriteLine("clientBaseHost " + clientBaseHost + "\n");
            /**/
            Console.WriteLine("clientBaseUrl " + clientBaseUrl + "\n");
            Console.WriteLine(" clientCachePolicy" + clientCachePolicy + "\n");
            Console.WriteLine("clientClientCertificates " + clientClientCertificates + "\n");
            Console.WriteLine("clientConnectionGroupName " + clientConnectionGroupName + "\n");
            Console.WriteLine(" clientCookieContainer" + clientCookieContainer + "\n");

            foreach (Parameter p in clientDefaultParameters)
            {
                Console.WriteLine("clientCookieContainer " + p + "\n");
            }

            Console.WriteLine("clientEncoding " + clientEncoding + "\n");
            Console.WriteLine(" clientFollowRedirects" + clientFollowRedirects + "\n");
            Console.WriteLine(" clientMaxRedirects" + clientMaxRedirects + "\n");
            Console.WriteLine("clientPipelined " + clientPipelined + "\n");
            Console.WriteLine("clientPreAuthenticate " + clientPreAuthenticate + "\n");
            Console.WriteLine("clientProxy " + clientProxy + "\n");
            Console.WriteLine("clientReadWriteTimeout " + clientReadWriteTimeout + "\n");
            Console.WriteLine("clientRemoteCertificateValidationCallback " + clientRemoteCertificateValidationCallback + "\n");
            Console.WriteLine("clientTimeout " + clientTimeout + "\n");
            Console.WriteLine("clientUnsafeAuthenticatedConnectionSharing " + clientUnsafeAuthenticatedConnectionSharing + "\n");
            Console.WriteLine("clientUserAgent " + clientUserAgent + "\n");
            Console.WriteLine("clientUseSynchronizationContext " + clientUseSynchronizationContext + "\n");

            RestRequest request = new RestRequest("/search?q={query}", Method.GET);
            request.AddParameter("query", "King", ParameterType.UrlSegment);
            request.RequestFormat = DataFormat.Json;

            IRestResponse response = client.Execute(request);
            //response
            string responseContent = response.Content;
            string responseContentEncoding = response.ContentEncoding;
            long responseContentLength = response.ContentLength;
            string responseContentType = response.ContentType;
            IList<RestResponseCookie> responseCookies = response.Cookies;
            Exception responseErrorException = response.ErrorException;
            string responseErrorMessage = response.ErrorMessage;
            IList<Parameter> responseHeaders = response.Headers;
            bool responseIsSuccessful = response.IsSuccessful;
            Version responseProtocolVersion = response.ProtocolVersion;
            Byte[] responseRawBytes = response.RawBytes;
            IRestRequest responseRequest = response.Request;
            ResponseStatus responseResponseStatus = response.ResponseStatus;
            Uri responseResponseUri = response.ResponseUri;
            string responseServer = response.Server;
            HttpStatusCode responseStatusCode = response.StatusCode;
            string responseStatusDescription = response.StatusDescription;

            for (int i = 1; i < 2; i++)
                Console.Beep();


            Console.WriteLine("responseContent \n" + responseContent + "\n");
            Console.WriteLine("responseContentEncoding " + responseContentEncoding + "\n");
            Console.WriteLine("responseContentLength " + responseContentLength + "\n");
            Console.WriteLine("responseContentType " + responseContentType + "\n");

            foreach (RestResponseCookie c in responseCookies)
            {
                Console.WriteLine("responseCookies " + c + "\n");
            }

            Console.WriteLine("responseErrorException " + responseErrorException + "\n");
            Console.WriteLine("responseErrorMessage " + responseErrorMessage + "\n");

            foreach (Parameter p in responseHeaders)
            {
                Console.WriteLine("responseHeaders " + p + "\n");
            }
            Console.WriteLine("responseIsSuccessful " + responseIsSuccessful + "\n");
            Console.WriteLine("responseProtocolVersion " + responseProtocolVersion + "\n");

            //foreach (Byte b in responseRawBytes)
            //{
            //    Console.WriteLine("responseRawBytes " + b + "\n");
            //}
            Console.WriteLine("responseRequest " + responseRequest + "\n");
            /**/
            Console.WriteLine("responseResponseStatus " + responseResponseStatus + "\n");
            /**/
            Console.WriteLine("responseResponseUri " + responseResponseUri + "\n");
            /**/
            Console.WriteLine("responseServer " + responseServer + "\n");
            /**/
            Console.WriteLine("responseStatusCode " + responseStatusCode + "\n");
            /**/
            Console.WriteLine("responseStatusDescription " + responseStatusDescription + "\n"); /**/

            //string json = JsonConvert.SerializeObject(responseContent);
            //Console.WriteLine("responseContentInJson " + json + "\n");

        }

        public static void SomeMethod1()
        {
            Console.WriteLine("SomeMethod1");
            Console.WriteLine("===========");
            RestClient client1 = new RestClient();
            client1.BaseUrl = new Uri("https://maps.googleapis.com");

            #region ClientParameters
            Console.WriteLine("client1.BaseUrl= " + client1.BaseUrl + "\n");
            Console.WriteLine("client1.Authenticator= " + client1.Authenticator + "\n");
            Console.WriteLine("client1AllowMultipleDefaultParametersWithSameName.= " + client1.AllowMultipleDefaultParametersWithSameName + "\n");
            Console.WriteLine("client1.AutomaticDecompression= " + client1.AutomaticDecompression + "\n");
            Console.WriteLine("client1.BaseHost= " + client1.BaseHost + "\n");
            Console.WriteLine("client1.BaseUrl= " + client1.BaseUrl + "\n");
            Console.WriteLine("client1.CachePolicy= " + client1.CachePolicy + "\n");
            Console.WriteLine("client1.ClientCertificates= " + client1.ClientCertificates + "\n");
            Console.WriteLine("client1.ConnectionGroupName= " + client1.ConnectionGroupName + "\n");
            Console.WriteLine("client1.CookieContainer= " + client1.CookieContainer + "\n");
            Console.WriteLine("client1.DefaultParameters= " + client1.DefaultParameters + "\n");
            Console.WriteLine("client1.Encoding= " + client1.Encoding + "\n");
            Console.WriteLine("client1.FollowRedirects= " + client1.FollowRedirects + "\n");
            Console.WriteLine("client1.MaxRedirects= " + client1.MaxRedirects + "\n");
            Console.WriteLine("client1.Pipelined= " + client1.Pipelined + "\n");
            Console.WriteLine("client1.PreAuthenticate= " + client1.PreAuthenticate + "\n");
            Console.WriteLine("client1.Proxy= " + client1.Proxy + "\n");
            Console.WriteLine("client1.ReadWriteTimeout= " + client1.ReadWriteTimeout + "\n");
            Console.WriteLine("client1.RemoteCertificateValidationCallback= " + client1.RemoteCertificateValidationCallback + "\n");
            Console.WriteLine("client1.Timeout= " + client1.Timeout + "\n");
            Console.WriteLine("client1.UnsafeAuthenticatedConnectionSharing= " + client1.UnsafeAuthenticatedConnectionSharing + "\n");
            Console.WriteLine("client1.UserAgent= " + client1.UserAgent + "\n");
            Console.WriteLine("client1.UseSynchronizationContext= " + client1.UseSynchronizationContext + "\n");
            #endregion

            RestRequest request1 = new RestRequest("/maps/api/place/details/json", Method.GET);
            request1.AddParameter("placeid", "ChIJN1t_tDeuEmsRUsoyG83frY4");
            request1.AddParameter("key", "XXXXXYYYYYYYYZZZZZZZZZZZ");

            #region RequestParameters
            int request1Attempts = request1.Attempts; Console.WriteLine("request1Attempts= " + request1Attempts + "\n");

            ICredentials request1Credentials = request1.Credentials; Console.WriteLine("request1Credentials= " + request1Credentials + "\n");

            string request1DateFormat = request1.DateFormat; Console.WriteLine("request1DateFormat= " + request1DateFormat + "\n");

            List<FileParameter> request1Files = request1.Files; Console.WriteLine("request1Files= " + request1Files + "\n");

            ISerializer request1JsonSerializer = request1.JsonSerializer; Console.WriteLine("request1JsonSerializer= " + request1JsonSerializer + "\n");

            Method request1Method = request1.Method; Console.WriteLine("request1Files= " + request1Files + "\n");

            Action<IRestResponse> request1OnBeforeDeserialization = request1.OnBeforeDeserialization; Console.WriteLine("request1Files= " + request1Files + "\n");

            List<Parameter> request1Parameters = request1.Parameters; Console.WriteLine("request1Parameters= " + request1Parameters + "\n");

            int request1ReadWriteTimeout = request1.ReadWriteTimeout; Console.WriteLine("request1ReadWriteTimeout= " + request1ReadWriteTimeout + "\n");

            DataFormat request1RequestFormat = request1.RequestFormat;

            Console.WriteLine("request1RequestFormat= " + request1RequestFormat + "\n");

            string request1Resource = request1.Resource;

            Console.WriteLine("request1Resource= " + request1Resource + "\n");

            Action<Stream> request1ResponseWriter = request1.ResponseWriter;

            Console.WriteLine("request1ResponseWriter= " + request1ResponseWriter + "\n");

            string request1RootElement = request1.RootElement;
            Console.WriteLine("request1RootElement= " + request1RootElement + "\n");
            int request1Timeout = request1.Timeout;
            Console.WriteLine("request1Timeout= " + request1Timeout + "\n");
            bool request1UseDefaultCredentials = request1.UseDefaultCredentials;
            Console.WriteLine("request1UseDefaultCredentials= " + request1UseDefaultCredentials + "\n");
            object request1UserState = request1.UserState;
            Console.WriteLine("request1UserState= " + request1UserState + "\n");
            string request1XmlNamespace = request1.XmlNamespace;
            Console.WriteLine("request1XmlNamespace= " + request1XmlNamespace + "\n");
            ISerializer request1XmlSerializer = request1.XmlSerializer;
            Console.WriteLine("request1XmlSerializer= " + request1XmlSerializer + "\n");
            #endregion

            IRestResponse response1 = client1.Execute(request1);

            #region ResponseParameters
            Console.WriteLine("\n \n response1 \n" + response1 + "\n \n");
            string repsonse1Content = response1.Content; Console.WriteLine("repsonse1Content= \n" + repsonse1Content + "\n");
            //string response1ContentEncoding= response1.ContentEncoding;     Console.WriteLine("response1ContentEncoding= " + response1ContentEncoding + "\n");
            //long response1ContentLength=response1.ContentLength;            Console.WriteLine("response1ContentLength= " + response1ContentLength + "\n");
            string response1ContentType = response1.ContentType; Console.WriteLine("response1ContentType= " + response1ContentType + "\n");
            IList<Parameter> response1Headers = response1.Headers;
            foreach (Parameter p in response1Headers)
            {
                Console.WriteLine("response1Headers= " + p + "\n");
            }

            bool response1IsSuccessful = response1.IsSuccessful; Console.WriteLine("response1IsSuccessful= " + response1IsSuccessful + "\n");
            // Version response1ProtocolVersion =response1.ProtocolVersion; Console.WriteLine("response1ProtocolVersion= " + response1ProtocolVersion + "\n");
            IRestRequest response1Request = response1.Request; Console.WriteLine("response1Request= " + response1Request + "\n");
            ResponseStatus response1ResponseStatus = response1.ResponseStatus; Console.WriteLine("response1ResponseStatus= " + response1ResponseStatus + "\n");
            Uri response1ResponseUri = response1.ResponseUri; Console.WriteLine("response1ResponseUri= " + response1ResponseUri + "\n");
            string response1Server = response1.Server; Console.WriteLine("response1Server= " + response1Server + "\n");
            HttpStatusCode response1StatusCode = response1.StatusCode; Console.WriteLine("response1StatusCode= " + response1StatusCode + "\n");
            string response1StatusDescription = response1.StatusDescription; Console.WriteLine("response1StatusDescription= " + response1StatusDescription + "\n");
            #endregion

            string responseInJSONToString = response1.Content;


            // var myString = (JObject)JsonConvert.DeserializeObject(responseInJSONToString);
            //JToken some = myString["result"]["address_components"]["long_name"].Value<Int32>();


            //JObject jobject = JObject.Parse(responseInJSONToString);
            //JToken jresult = jobject["result.address_components"];
            // string some = jresult["long_name"].ToString();
            //string some = o["result.address_components[0].long_name[0]"].ToString();
            //dynamic jsonObject = JsonConvert.DeserializeObject<dynamic>(responseInJSONToString);
            //string some = jsonObject["result.address_components[1].long_name[0]"];

            //Console.WriteLine("\n you \n" + some);

        }

        public static void SomeMethod2()
        {
            Console.WriteLine("SomeMethod2");
            Console.WriteLine("===========");
            RestClient restClient = new RestClient();
            restClient.BaseUrl = new Uri("https://maps.googleapis.com");
            restClient.BaseHost = "maps.googleapis.com";
            RestRequest restRequest = new RestRequest();
            restRequest.Method = Method.POST;
            restRequest.RequestFormat = DataFormat.Json;

            restRequest.Resource = "/maps/api/place/add/json";
            restRequest.AddQueryParameter("key", "XXXXXXYYYYYYYYYYYZZZZZZZZZZZ");

            //or

            //restRequest.Resource = "/maps/api/place/add/json?key={keyValue}";
            //restRequest.AddParameter("keyValue", "XXXXXXYYYYYYYZZZZZZZZZZZZ", ParameterType.UrlSegment);

            //or 

            //restRequest.Resource = "/maps/api/place/add/json";
            //restRequest.AddParameter("key", "XXXXXXXXXYYYYYYYYYYZZZZZZZZZ");

            string jsonBody = "{" +
 "\"location\": {" +
                "\"lat\": -33.8669710," +
    "\"lng\": 151.1958750" +
  "}," +
  "\"accuracy\": 50," +
  "\"name\": \"Google Shoes!\"," +
  "\"phone_number\": \"(02) 9374 4000\",\"" +
  "\"address\": \"48 Pirrama Road, Pyrmont, NSW 2009, Australia\"," +
  "\"types\": [\"shoe_store\"]," +
  "\"website\": \"http://www.google.com.au/\"," +
  "\"language\": \"en-AU\"" +
"}";

            restRequest.AddJsonBody(jsonBody);

            IRestResponse restResponse = restClient.Execute(restRequest);

            Console.WriteLine("\n restClient.BaseHost = " + restClient.BaseHost + "\n");
            Console.WriteLine("\n restClient.BaseUrl = " + restClient.BaseUrl + "\n");
            Console.WriteLine("\n restRequest.Resource = " + restRequest.Resource + "\n");

            foreach (Parameter p in restRequest.Parameters)
            {
                Console.WriteLine("\n restRequest.Parameters = " + restRequest.Parameters + "\n");
            }

            Console.WriteLine("\n restRequest.RequestFormat = " + restRequest.RequestFormat + "\n");
            Console.WriteLine("\n restRequest.jsonBody = \n" + jsonBody + "\n");
            Console.WriteLine("\n restResponse.Content = \n" + restResponse.Content + "\n");
            Console.WriteLine("\n restResponse.Server = " + restResponse.Server + "\n");
            Console.WriteLine("\n restResponse.ResponseUri = " + restResponse.ResponseUri + "\n");
            Console.WriteLine("\n restResponse.StatusCode = " + restResponse.StatusCode + "\n");
            Console.WriteLine("\n restResponse.StatusDescription = " + restResponse.StatusDescription + "\n");
            Console.WriteLine("\n restResponse.ResponseStatus = " + restResponse.ResponseStatus + "\n");
        }


        public static void SomeMethod3()
        {

            Console.WriteLine("SomeMethod3");
            Console.WriteLine("===========");
            RestClient restClient = new RestClient();
            restClient.BaseUrl = new Uri("https://maps.googleapis.com");
            restClient.BaseHost = " maps.googleapis.com";

            RestRequest restRequest = new RestRequest();
            restRequest.Method = Method.POST;
            restRequest.RequestFormat = DataFormat.Json;

            restRequest.Resource = "/maps/api/place/delete/json";
            restRequest.AddQueryParameter("key", "XXXXXXYYYYYYYZZZZZZZZZZZZ");

            //or

            //restRequest.Resource = "/maps/api/place/add/json?key={keyValue}";
            //restRequest.AddParameter("keyValue", "XXXXXXXYYYYYYYYYZZZZZZZZ", ParameterType.UrlSegment);

            //or 

            //restRequest.Resource = "/maps/api/place/add/json";
            //restRequest.AddParameter("key", "XXXXXXYYYYYYZZZZZZZZZZZZZZ");

            string jsonBody = "{" +
  "\"place_id\": \"CdIJN2t_tDeuEmsRUsoyG83frY4\"" +
"}";

            restRequest.AddJsonBody(jsonBody);

            IRestResponse restResponse = restClient.Execute(restRequest);

            Console.WriteLine("\n restClient.BaseHost = " + restClient.BaseHost + "\n");
            Console.WriteLine("\n restClient.BaseUrl = " + restClient.BaseUrl + "\n");

            Console.WriteLine("\n restRequest.Resource = " + restRequest.Resource + "\n");

            foreach (Parameter p in restRequest.Parameters)
            {
                Console.WriteLine("\n restRequest.Parameters = " + restRequest.Parameters + "\n");
            }

            Console.WriteLine("\n restRequest.RequestFormat = " + restRequest.RequestFormat + "\n");
            Console.WriteLine("\n restRequest.jsonBody = \n" + jsonBody + "\n");
            Console.WriteLine("\n restResponse.Content = \n" + restResponse.Content + "\n");
            Console.WriteLine("\n restResponse.Server = " + restResponse.Server + "\n");
            Console.WriteLine("\n restResponse.ResponseUri = " + restResponse.ResponseUri + "\n");
            Console.WriteLine("\n restResponse.StatusCode = " + restResponse.StatusCode + "\n");
            Console.WriteLine("\n restResponse.StatusDescription = " + restResponse.StatusDescription + "\n");
            Console.WriteLine("\n restResponse.ResponseStatus = " + restResponse.ResponseStatus + "\n");
        }


        public static void SomeMethod4()
        {
            RestClient restClient = new RestClient();
            restClient.BaseHost = "login.live.com";
            restClient.BaseUrl = new Uri("https://login.live.com");
            restClient.Authenticator = new HttpBasicAuthenticator("XXYYZZ@outlook.com", "XXXYYYYZZZZZZ");
            restClient.Authenticator = new NtlmAuthenticator();
            restClient.Authenticator = new OAuth1Authenticator();
            restClient.Authenticator = new JwtAuthenticator("");


            RestRequest restRequest = new RestRequest("/oauth20_authorize.srf", Method.GET);
            restRequest.AddQueryParameter("client_id", "XXXXXXXYYYYYYXXXXXXXXXXZZZZZZZZ");
            restRequest.AddParameter("scope", "wl.signin%20wl.basic");
            restRequest.AddParameter("response_type", "code");

            IRestResponse restResponse = restClient.Execute(restRequest);

            Console.WriteLine("\n restClient.BaseHost = " + restClient.BaseHost + "\n");
            Console.WriteLine("\n restClient.BaseUrl = " + restClient.BaseUrl + "\n");

            Console.WriteLine("\n restRequest.Resource = " + restRequest.Resource + "\n");

            foreach (Parameter p in restRequest.Parameters)
            {
                Console.WriteLine("\n restRequest.Parameters = " + restRequest.Parameters + "\n");
            }

            Console.WriteLine("\n restRequest.RequestFormat = " + restRequest.RequestFormat + "\n");
            Console.WriteLine("\n restResponse.Content = \n" + restResponse.Content + "\n");
            Console.WriteLine("\n restResponse.Server = " + restResponse.Server + "\n");
            Console.WriteLine("\n restResponse.ResponseUri = " + restResponse.ResponseUri + "\n");
            Console.WriteLine("\n restResponse.StatusCode = " + restResponse.StatusCode + "\n");
            Console.WriteLine("\n restResponse.StatusDescription = " + restResponse.StatusDescription + "\n");
            Console.WriteLine("\n restResponse.ResponseStatus = " + restResponse.ResponseStatus + "\n");
        }


        public static void SomeMethod5()
        {
            RestClient restClient = new RestClient();
            restClient.BaseUrl = new Uri("https://XXXXXXYYYYYYYZZZZZZ.visualstudio.com");
            //restClient.BaseUrl = new Uri("https://fabrikam-fiber-inc.visualstudio.com/");

            RestRequest restRequest = new RestRequest();
            restRequest.Resource = "/DefaultCollection/Test1/_apis/wit/workItemTypes?api-version={version}";
            restRequest.AddParameter("version", "1.0", ParameterType.UrlSegment);
            //restRequest.Resource = "/DefaultCollection/Fabrikam-Fiber-Git/_apis/wit/workItemTypes?api-version={version}";
            //restRequest.AddParameter("version", "1.0", ParameterType.UrlSegment);
            restRequest.Method = Method.GET;
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse restResponse = restClient.Execute(restRequest);
            Console.WriteLine("\n restClient.BaseHost = " + restClient.BaseHost + "\n");
            Console.WriteLine("\n restClient.BaseUrl = " + restClient.BaseUrl + "\n");

            Console.WriteLine("\n restRequest.Resource = " + restRequest.Resource + "\n");

            foreach (Parameter p in restRequest.Parameters)
            {
                Console.WriteLine("\n restRequest.Parameters = " + restRequest.Parameters + "\n");
            }

            Console.WriteLine("\n restRequest.RequestFormat = " + restRequest.RequestFormat + "\n");
            Console.WriteLine("\n restResponse.Content = \n" + restResponse.Content + "\n");
            Console.WriteLine("\n restResponse.Server = " + restResponse.Server + "\n");
            Console.WriteLine("\n restResponse.ResponseUri = " + restResponse.ResponseUri + "\n");
            Console.WriteLine("\n restResponse.StatusCode = " + restResponse.StatusCode + "\n");
            Console.WriteLine("\n restResponse.StatusDescription = " + restResponse.StatusDescription + "\n");
            Console.WriteLine("\n restResponse.ResponseStatus = " + restResponse.ResponseStatus + "\n");
        }

        public static void SomeMethod6()
        {
            RestClient restClient = new RestClient();
            restClient.BaseUrl = new Uri("http://api.openweathermap.org");
            restClient.BaseHost = "api.openweathermap.org";

            RestRequest restRequest = new RestRequest();
            restRequest.Resource = "/data/2.5/weather?q={city name},{country code}";
            restRequest.AddParameter("city name", "London", ParameterType.UrlSegment);
            restRequest.AddParameter("country code", "uk", ParameterType.UrlSegment);
            restRequest.AddHeader("x-api-key", "XXXXXXYYYYYZZZZZZZZZZZ");

            restRequest.Method = Method.GET;
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse restResponse = restClient.Execute(restRequest);
            Console.WriteLine("\n restClient.BaseHost = " + restClient.BaseHost + "\n");
            Console.WriteLine("\n restClient.BaseUrl = " + restClient.BaseUrl + "\n");

            Console.WriteLine("\n restRequest.Resource = " + restRequest.Resource + "\n");

            foreach (Parameter p in restRequest.Parameters)
            {
                Console.WriteLine("\n restRequest.Parameters = " + restRequest.Parameters + "\n");
            }

            Console.WriteLine("\n restRequest.RequestFormat = " + restRequest.RequestFormat + "\n");
            Console.WriteLine("\n restResponse.Content = \n" + restResponse.Content + "\n");
            Console.WriteLine("\n restResponse.Server = " + restResponse.Server + "\n");
            Console.WriteLine("\n restResponse.ResponseUri = " + restResponse.ResponseUri + "\n");
            Console.WriteLine("\n restResponse.StatusCode = " + restResponse.StatusCode + "\n");
            Console.WriteLine("\n restResponse.StatusDescription = " + restResponse.StatusDescription + "\n");
            Console.WriteLine("\n restResponse.ResponseStatus = " + restResponse.ResponseStatus + "\n");

            //Coord coord = JsonConvert.DeserializeObject<Coord>(restResponse.Content.ToString());
            //Console.WriteLine("Coord" + coord.lat + "\t " + coord.lon);


            //Sys sys = JsonConvert.DeserializeObject<Sys>(restResponse.Content.ToString());
            //Console.WriteLine("Sys" + sys.country + "\t " + sys.sunrise +"\t"+sys.sunset);

            //dynamic data = JsonConvert.DeserializeObject<dynamic>(restResponse.Content.ToString());
            //dynamic data = JObject.Parse(restResponse.Content.ToString()).ToString();
            //Console.WriteLine(data.lon);
            //Console.WriteLine(data.lat);
            //Console.WriteLine(data.country);
            //Console.WriteLine(data.sunrise);
            //Console.WriteLine(data.sunset);

            JObject mainObject = JObject.Parse(restResponse.Content);
            Console.WriteLine("mainObject.Count\n" + mainObject.Count + "\n");
            Console.WriteLine("mainObject.First\n" + mainObject.First + "\n");
            Console.WriteLine("mainObject.HasValues\n" + mainObject.HasValues + "\n");
            Console.WriteLine("mainObject.Last\n" + mainObject.Last + "\n");
            Console.WriteLine("mainObject.Next\n" + mainObject.Next + "\n");
            Console.WriteLine("mainObject.Parent\n" + mainObject.Parent + "\n");
            Console.WriteLine("mainObject.Path\n" + mainObject.Path + "\n");
            Console.WriteLine("mainObject.Previous\n" + mainObject.Previous + "\n");
            Console.WriteLine("mainObject.Root\n" + mainObject.Root + "\n");
            Console.WriteLine("mainObject.Type\n" + mainObject.Type + "\n");

            JObject subObjectCoord = (JObject)mainObject["coord"];

            Console.WriteLine("subObjectCoord.Count\n" + subObjectCoord.Count + "\n");
            Console.WriteLine("subObjectCoord.First\n" + subObjectCoord.First + "\n");
            Console.WriteLine("subObjectCoord.HasValues\n" + subObjectCoord.HasValues + "\n");
            Console.WriteLine("subObjectCoord.Last\n" + subObjectCoord.Last + "\n");
            Console.WriteLine("subObjectCoord.Next\n" + subObjectCoord.Next + "\n");
            Console.WriteLine("subObjectCoord.Parent\n" + subObjectCoord.Parent + "\n");
            Console.WriteLine("subObjectCoord.Path\n" + subObjectCoord.Path + "\n");
            Console.WriteLine("subObjectCoord.Previous\n" + subObjectCoord.Previous + "\n");
            Console.WriteLine("subObjectCoord.Root\n" + subObjectCoord.Root + "\n");
            Console.WriteLine("subObjectCoord.Type\n" + subObjectCoord.Type + "\n");



            JValue jvalue = (JValue)subObjectCoord["lon"].ToString();
            Console.WriteLine("lon\n" + jvalue + "\n");

            JArray subObjectArrayWeather = (JArray)mainObject["weather"];
            Console.WriteLine("subObjectArrayWeather:" + subObjectArrayWeather + "\n");
            Console.WriteLine("subObjectArrayWeather[0]:" + subObjectArrayWeather[0] + "\n");

            JValue jid = (JValue)subObjectArrayWeather[0]["id"].ToString();
            Console.WriteLine("jid:" + jid + "\n");

            JValue jmain = (JValue)subObjectArrayWeather[0]["main"].ToString();
            Console.WriteLine("jmain:" + jmain + "\n");

            JValue jdescription = (JValue)subObjectArrayWeather[0]["description"].ToString();
            Console.WriteLine("jdescription:" + jdescription + "\n");

            JValue jbase = (JValue)mainObject["base"].ToString();
            Console.WriteLine("base:" + jbase + "\n");

            JValue jdt = (JValue)mainObject["dt"].ToString();
            Console.WriteLine("dt:" + jdt + "\n");

            //ANother way of fetching values from JSON
            var qs = HttpUtility.ParseQueryString(restResponse.Content);
            string main = qs["main"].ToString();



        }

        public static void SomeMethod7()
        {
            RestClient restClient = new RestClient();
            restClient.BaseHost = "googleapis.com";
            restClient.BaseUrl = new Uri("https://www.googleapis.com");


            RestRequest restRequest = new RestRequest("/gmail/v1/users/XXXXXXYYYYYYYZZZZZZZ@gmail.com/profile", Method.GET);
            restRequest.AddQueryParameter("access_token", "XXXXXYYYYYZZZZZZZZZ");
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse restResponse = restClient.Execute(restRequest);

            Console.WriteLine("\n restClient.BaseHost = " + restClient.BaseHost + "\n");
            Console.WriteLine("\n restClient.BaseUrl = " + restClient.BaseUrl + "\n");

            Console.WriteLine("\n restRequest.Resource = " + restRequest.Resource + "\n");

            foreach (Parameter p in restRequest.Parameters)
            {
                Console.WriteLine("\n restRequest.Parameters = " + restRequest.Parameters + "\n");
            }

            Console.WriteLine("\n restRequest.RequestFormat = " + restRequest.RequestFormat + "\n");
            Console.WriteLine("\n restResponse.Content = \n" + restResponse.Content + "\n");
            Console.WriteLine("\n restResponse.Server = " + restResponse.Server + "\n");
            Console.WriteLine("\n restResponse.ResponseUri = " + restResponse.ResponseUri + "\n");
            Console.WriteLine("\n restResponse.StatusCode = " + restResponse.StatusCode + "\n");
            Console.WriteLine("\n restResponse.StatusDescription = " + restResponse.StatusDescription + "\n");
            Console.WriteLine("\n restResponse.ResponseStatus = " + restResponse.ResponseStatus + "\n");




        }

        public static void SomeMethod8()
        {
            string consumerKey = "XXXXXXXXXXXXXXXXYYYYYYYYYYYY";
            string consumerSecret = "XXXXXXXXXYYYYYYYYYYYYYZZZZZZZZZZZ";
            string accessToken = "FFFFFFFFFFFFTTTTTTTTTTTTRRRRRRRRRRRRRRRRRRRDDDDDDDDD";
            string accessTokenSecret = "EEEEEEEEEEEEERRRRRRRRRRRTTTTTTTTTTYYYYYYYYUUUUIIII";


            RestClient restClient = new RestClient();
            restClient.BaseHost = "api.twitter.com";
            restClient.BaseUrl = new Uri("https://api.twitter.com");
            restClient.Authenticator = new OAuth1Authenticator();
            {
                OAuth1Authenticator.ForRequestToken(consumerKey, consumerSecret);
                //OAuth1Authenticator.ForRequestToken(consumerKey, consumerSecret);
                //OAuth1Authenticator.ForProtectedResource(consumerKey, consumerSecret, accessToken, accessTokenSecret);
                //OAuth1Authenticator.ForClientAuthentication(consumerKey, consumerSecret,"XXXXXYYYYYYYY","XXXXYYYYZZZZ");

            }




            RestRequest restRequest = new RestRequest();
            restRequest.Resource = "/oauth/request_token";
            restRequest.Method = Method.POST;
            restRequest.RequestFormat = DataFormat.Json;

            IRestResponse restResponse = restClient.Execute(restRequest);


            Console.WriteLine("\n restClient.BaseHost = " + restClient.BaseHost + "\n");
            Console.WriteLine("\n restClient.BaseUrl = " + restClient.BaseUrl + "\n");

            Console.WriteLine("\n restRequest.Resource = " + restRequest.Resource + "\n");

            foreach (Parameter p in restRequest.Parameters)
            {
                Console.WriteLine("\n restRequest.Parameters = " + restRequest.Parameters + "\n");
            }

            Console.WriteLine("\n restRequest.RequestFormat = " + restRequest.RequestFormat + "\n");
            Console.WriteLine("\n restResponse.Content = \n" + restResponse.Content + "\n");
            Console.WriteLine("\n restResponse.Server = " + restResponse.Server + "\n");
            Console.WriteLine("\n restResponse.ResponseUri = " + restResponse.ResponseUri + "\n");
            Console.WriteLine("\n restResponse.StatusCode = " + restResponse.StatusCode + "\n");
            Console.WriteLine("\n restResponse.StatusDescription = " + restResponse.StatusDescription + "\n");
            Console.WriteLine("\n restResponse.ResponseStatus = " + restResponse.ResponseStatus + "\n");

        }

        public static void SomeMethod9()
        {
            


        }
    }

    /*var client = new RestClient("https://XXXXX-dev-restapi.onbmc.com/api/jwt/login");

    var request = new RestRequest(Method.POST);

    request.AddHeader("postman-token", "97dfa8fe-f575-339c-3376-09a836ea25b9");

    request.AddHeader("cache-control", "no-cache");

    request.AddHeader("content-type", "application/x-www-form-urlencoded");

    request.AddParameter("application/x-www-form-urlencoded", "username=XXXXX&password=XXXXXXXX", ParameterType.RequestBody);

I   RestResponse response = client.Execute(request);*/
    public static class MySuccessfulBreakdownJSON
    {
        /* JSON Starts from here
        {
  "coord": {
    "lon": -0.13,
    "lat": 51.51
  },
  "weather": [
    {
      "id": 721,
      "main": "Haze",
      "description": "haze",
      "icon": "50d"
    }
  ],
  "base": "stations",
  "main": {
    "temp": 278.95,
    "pressure": 1027,
    "humidity": 84,
    "temp_min": 278.15,
    "temp_max": 280.15
  },
  "visibility": 7000,
  "wind": {
    "speed": 2.6,
    "deg": 30
  },
  "clouds": {
    "all": 8
  },
  "dt": 1519217400,
  "sys": {
    "type": 1,
    "id": 5091,
    "message": 0.0161,
    "country": "GB",
    "sunrise": 1519196497,
    "sunset": 1519234040
  },
  "id": 2643743,
  "name": "London",
  "cod": 200
}  JSON ends from here */

    }


}

