using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace MongoDBIntIdGenerator.Tests.Stubs
{
    public class StubInt32Entity
    {
        [BsonId(IdGenerator = typeof(Int32IdGenerator<StubInt32Entity>))]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}