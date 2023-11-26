// See https://aka.ms/new-console-template for more information

using Microsoft.Spark.Sql;

var sparkSession = SparkSession.Builder().GetOrCreate();
var scvFile = sparkSession.Read()
    .Format("csv")
    .Options();