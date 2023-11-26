// See https://aka.ms/new-console-template for more information

using Microsoft.Spark;
using Microsoft.Spark.Sql;
using static Microsoft.Spark.Sql.Functions;

// SparkConf sparkConf = new SparkConf();
// sparkConf.Set("spark.local.dir", "C:\\Preparation\\InnowisePrepare\\SparkTrain\\Temp");
SparkSession spark =
    SparkSession
        .Builder()
        .AppName("word_count_sample")
        .("localhost:5567")
        .GetOrCreate();


// Create initial DataFrame
string filePath = args[0];
DataFrame dataFrame = spark.Read().Text(filePath);

//Count words
DataFrame words =
    dataFrame
        .Select(Split(Col("value")," ").Alias("words"))
        .Select(Explode(Col("words")).Alias("word"))
        .GroupBy("word")
        .Count()
        .OrderBy(Col("count").Desc());

// Display results
words.Show();

// Stop Spark sessio
spark.Stop();
