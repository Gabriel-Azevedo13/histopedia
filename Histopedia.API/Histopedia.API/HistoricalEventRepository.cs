using Histopedia.API.Models;
using Histopedia.API.Repositories.Interfaces;
using MongoDB.Driver;

namespace Histopedia.API.Repositories
{
    public class HistoricalEventRepository : IHistoricalEventRepository
    {
        private readonly IMongoCollection<HistoricalEvent> _collection;
        public HistoricalEventRepository()
        {
            
        }
    }
}
