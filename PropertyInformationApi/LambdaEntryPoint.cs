using Amazon.Lambda.AspNetCoreServer;
using Microsoft.AspNetCore.Hosting;

namespace PropertyInformationApi
{
    public class LambdaEntryPoint : APIGatewayProxyFunction
    {
        protected override void Init(IWebHostBuilder builder)
        {
            builder
                .UseStartup<Startup>();
        }
    }
}
