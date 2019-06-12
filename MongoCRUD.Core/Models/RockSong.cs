using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoCRUD.Core.Models
{
    public class RockSong : MongoBaseModel
    {
        [BsonElement("Name")]
        public string Name { get; set; }

        [BsonElement("Singer")]
        public string Singer { get; set; }
    }
}
