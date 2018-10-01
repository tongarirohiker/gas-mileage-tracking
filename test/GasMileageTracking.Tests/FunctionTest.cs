
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
using Xunit;

namespace GasMileageTracking.Tests
{
	public class FunctionTest
    {
        public FunctionTest()
        {
        }

        [Fact]
        public void TetGetMethod()
        {
            TestLambdaContext context;
            APIGatewayProxyRequest request;
            APIGatewayProxyResponse response;

            Functions functions = new Functions();


            request = new APIGatewayProxyRequest();
            context = new TestLambdaContext();
            response = functions.Get(request, context);
            Assert.Equal(200, response.StatusCode);
            Assert.Equal("{\"Name\":\"Chevy\"}", response.Body);
        }
    }
}
