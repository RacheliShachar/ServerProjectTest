using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServerProjectMvcWithoutView.Models
{
    public class Users
    {
        // [BsonId]
        // [BsonRepresentation(BsonType.ObjectId)]
        // public string Id { get; set; }

        // [BsonElement("name")]
        // public string Name { get; set; }

        // [BsonElement("age")]
        // public int Age { get; set; }

        public string Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }  // Store Date as DateTime


    }
}
