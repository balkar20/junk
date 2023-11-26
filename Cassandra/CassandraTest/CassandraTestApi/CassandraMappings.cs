using Cassandra.Mapping;

namespace CassandraTestApi;

public class CassandraMappings : Mappings
{
    public CassandraMappings()
    {
        For<PostModel>().KeyspaceName("blogs").TableName("posts").PartitionKey(u => u.Id)
            .Column(x => x.Id, map => map.WithName("post_id"))
            .Column(x => x.Title)
            .Column(x => x.Body)
            .Column(x => x.LastUpdated);
    }
}