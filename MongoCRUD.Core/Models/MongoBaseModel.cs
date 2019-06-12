using MongoDB.Bson;

namespace MongoCRUD.Core.Models
{
    public abstract class MongoBaseModel
    {
        public ObjectId Id { get; set; }
    }
}
