using System;
using System.Data.SqlClient;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;


namespace IceTask4Cloud
{
    public class QueueFunction
    {
        

public static class QueueToDatabaseFunction
    {
        [FunctionName("QueueToDatabase")]
        public static void Run(
            [QueueTrigger("your-queue-name")] string queueMessage,
            ILogger log,
            ExecutionContext context)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(context.FunctionAppDirectory)
                .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            string sqlConnectionString = config.GetConnectionString("sqldb_connection");

            using (SqlConnection connection = new SqlConnection(sqlConnectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO YourTable (ColumnName) VALUES (@Value)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Value", queueMessage);
                    cmd.ExecuteNonQuery();
                }
            }

            log.LogInformation($"C# Queue trigger function processed: {queueMessage}");
        }
    }

}
}

