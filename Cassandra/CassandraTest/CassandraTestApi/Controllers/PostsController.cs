using Cassandra.Mapping;
using Microsoft.AspNetCore.Mvc;

namespace CassandraTestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PostsController : ControllerBase
{
    private readonly IMapper _mapper;
    public PostsController(IMapper mapper)
    {
        _mapper = mapper;
    }
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    
    [HttpGet(Name = "GetPosts")]
    public IEnumerable<PostModel> Get()
    {
        var result = _mapper.Fetch<PostModel>();
        return result;
    }
}