namespace CassandraTestApi;

public class PostModel
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Body { get; set; }
    public DateTime LastUpdated { get; set; }
}