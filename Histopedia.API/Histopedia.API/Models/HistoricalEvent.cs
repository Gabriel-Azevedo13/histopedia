using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Histopedia.API.Models
{
    public class HistoricalEvent
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
        public string Title { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateTime Date { get; set; }
        public List<string> Categories { get; set; } = new();
        public string Source { get; set; } = default!;
    }
}
