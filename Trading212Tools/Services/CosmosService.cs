using System.Net;
using Microsoft.Azure.Cosmos;
using Trading212Tools.Constants;
using Trading212Tools.Models;

namespace Trading212Tools.Services
{
    public class CosmosService: IDisposable
    {
        private readonly CosmosClient cosmosClient;

        private Database database;
        private Container container;
        
        public CosmosService()
        {
            cosmosClient = new CosmosClient(Trading212Constants.EndpointUri, Trading212Constants.PrimaryKey, new CosmosClientOptions() { ApplicationName = "Trading212Tools" });
        }

        public async Task CreateDDBB()
        {
            await CreateDatabaseIfNotExistAsync();
            await CreateContainerIfNotExistAsync();
            await ScaleContainerAsync();
        }

        private async Task CreateDatabaseIfNotExistAsync()
        {
            database = await cosmosClient.CreateDatabaseIfNotExistsAsync(Trading212Constants.DatabaseId);
        }

        private async Task CreateContainerIfNotExistAsync()
        {
            container = await database.CreateContainerIfNotExistsAsync(Trading212Constants.containerId, "/partitionKey");
        }

        private async Task ScaleContainerAsync()
        {
            try
            {
                var throughput = await container.ReadThroughputAsync();
                if (throughput.HasValue)
                {
                    var newThroughput = throughput.Value + 100;
                    await container.ReplaceThroughputAsync(newThroughput);
                }
            }
            catch (CosmosException cosmosException) when (cosmosException.StatusCode == HttpStatusCode.BadRequest)
            {
                throw;
            }
        }

        public async Task AddItemsToContainerAsync(InputLine line)
        {
            await container.CreateItemAsync(line, new PartitionKey(line.PartitionKey));
        }

        public async Task DeleteDatabaseAndCleanupAsync()
        {
            database = cosmosClient.GetDatabase(Trading212Constants.DatabaseId);
            await database.DeleteAsync();
        }

        public void Dispose()
        {
            cosmosClient.Dispose();
        }
    }
}
