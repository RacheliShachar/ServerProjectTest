using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ServerProjectMvcWithoutView.Models
{
    public class CreateQueue
    {
        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("idNumber")]
        public string IdNumber { get; set; }
        
        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("phone")]
        public string Phone { get; set; }

        [BsonElement("date")]
        public DateTime Date { get; set; }

        [BsonElement("status")]
        public string Status { get; set; }


    }
}
