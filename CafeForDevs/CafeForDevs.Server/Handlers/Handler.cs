using Newtonsoft.Json;
using System;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;

namespace CafeForDevs.Server.Handlers
{
    public abstract class Handler
    {

        protected T GetRequestBody<T>(HttpListenerContext context)
        {
            var inputstream = context.Request.InputStream;
            var inputBytes = new byte[context.Request.ContentLength64];
            inputstream.Read(inputBytes, 0, (int)context.Request.ContentLength64);

            // preobrazovat stroku zaprosa k modelke.
            var bodyString = Encoding.UTF8.GetString(inputBytes);
            return JsonConvert.DeserializeObject<T>(bodyString);
            // return result;
        }
        protected void SetResponse<T>(T model, HttpListenerContext context)
        {
            var outputStream = context.Response.OutputStream;
            // preobrazovat menu k stro4nomu vidu.

            var jsonString = JsonConvert.SerializeObject(model);
            var outputBytes = Encoding.UTF8.GetBytes(jsonString);
            outputStream.Write(outputBytes, 0, outputBytes.Length);
        }
    }
}
