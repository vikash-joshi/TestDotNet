using System.Net.Mime;

namespace core_web_api.middlewares
{
    public class FirstMiddlewareClass
    {
        public readonly RequestDelegate requestDelegate;

        public FirstMiddlewareClass(RequestDelegate request)
        {
            requestDelegate = request;
        }

        public async Task Invoke(HttpContext http)
        {
             Console.WriteLine($"Request Path: {http.Request.Path} and my first middle ware");
             Console.WriteLine(http.Request.Headers);
             await requestDelegate(http); // Call the next middleware
   
        }
    }


     public class SecondMiddlewareClass
    {
        public readonly RequestDelegate requestDelegate1;

        public SecondMiddlewareClass(RequestDelegate request1)
        {
            requestDelegate1 = request1;
        }

        public async Task Invoke(HttpContext http)
        {
             Console.WriteLine($"Request Path: {http.Request.Path} and my second middle ware");
             Console.WriteLine("object",http);
             if(http.Request.Headers.ContainsKey("youtube")){
             await requestDelegate1(http); // Call the next middleware
   
             }
             else{
                http.Response.StatusCode = StatusCodes.Status400BadRequest;
                http.Response.ContentType = "application/json";
                  await http.Response.WriteAsync("Bad Request: Missing required header.");
            return; 
             }
        }
    }
}