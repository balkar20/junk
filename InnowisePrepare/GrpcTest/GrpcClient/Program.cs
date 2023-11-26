using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcClient;

Console.WriteLine("Hello");

// using var channel = GrpcChannel.ForAddress("http://localhost:5190");
// var client = new Greeter.GreeterClient(channel);
// var reply = await client.SayHelloAsync(
//     new HelloRequest { Name = "GreeterClient" });
// var client2 = new Doze.DozeClient(channel);
// var reply2 = await client2.SayDozeAsync(
//     new DozeRequest { Name = "GreeterClient" });
// Console.WriteLine("Greeting: " + reply.Message);
// Console.WriteLine("Greeting: " + reply2.Message);
using var channel = GrpcChannel.ForAddress("http://localhost:5016/");
var client3 = new CreateOrder.CreateOrderClient(channel);
var f = await client3.SayDozeAsync(new CreateOrderRequest()
{
    Name = "Client"
});
Console.WriteLine("Greeting: " + f.Message);
Console.WriteLine("Press any key to exit...");

Console.ReadKey();