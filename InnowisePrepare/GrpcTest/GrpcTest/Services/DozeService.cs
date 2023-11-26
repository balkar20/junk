using Grpc.Core;

namespace GrpcTest.Services;

public class DozeService: Doze.DozeBase
{
    private readonly ILogger<DozeService> _logger;

    public DozeService(ILogger<DozeService> logger)
    {
        _logger = logger;
    }

    public override Task<DozeReply> SayDoze(DozeRequest request, ServerCallContext context)
    {
        return Task.FromResult(new DozeReply
        {
            Message = "Hello From Doze to " + request.Name
        });
    }
}