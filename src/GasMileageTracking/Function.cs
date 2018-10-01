using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

using Amazon.Lambda.Core;
using Amazon.Lambda.APIGatewayEvents;
using Newtonsoft.Json;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace GasMileageTracking
{
    public class Functions
    {
		ICarProcessor carProcessor = new CarProcessor();

        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public Functions()
        {
        }


        /// <summary>
        /// A Lambda function to respond to HTTP Get methods from API Gateway
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The list of blogs</returns>
        public APIGatewayProxyResponse Get(APIGatewayProxyRequest request, ILambdaContext context)
        {
	        var result = carProcessor.GetCar("Chevy");

	        return _CreateResponse(result);
        }

	    private APIGatewayProxyResponse _CreateResponse(Car result)
	    {
		    int statusCode = (result != null) ?
			    (int)HttpStatusCode.OK :
			    (int)HttpStatusCode.InternalServerError;

		    string body = (result != null) ?
			    JsonConvert.SerializeObject(result) : string.Empty;

		    var response = new APIGatewayProxyResponse
		    {
			    StatusCode = statusCode,
			    Body = body,
			    Headers = new Dictionary<string, string>
			    {
				    { "Content-Type", "application/json" },
				    { "Access-Control-Allow-Origin", "*" }
			    }
		    };

		    return response;
	    }
	}
}
