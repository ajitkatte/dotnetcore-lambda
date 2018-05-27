using System;
using Amazon.Lambda.Core;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace LambdaTestApp
{
    public class LambdaHandler
    {
        public string Handler(string request, ILambdaContext context)
        {
            context.Logger.LogLine($"Request : {request}");
            return $"HELLO {request.ToUpper()}";
        }
    }
}
