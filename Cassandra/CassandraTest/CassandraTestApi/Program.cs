using Cassandra;
using Cassandra.Mapping;
using CassandraTestApi;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Configure Cassandra mappings
var mappingConfig = new MappingConfiguration();
mappingConfig.Define<CassandraMappings>(); // Add more tables if needed
var cluster = Cluster.Builder()
    .AddContactPoints("localhost")// Replace with your Cassandra node IP addresses or hostnames
    .Build();
var session = cluster.Connect();
    var mapper = new Mapper(session, mappingConfig);
builder.Services.AddSingleton<IMapper>(mapper);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();