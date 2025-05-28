
using System.Data.Common;
using System.Reflection.Metadata;
using MongoDB.Bson;
using MongoDB.Driver;
class MongoDbUtils
{
    static MongoUrl mongoURL = new MongoUrl("mongodb+srv://myAtlasDBUser:123@myatlasclusteredu.fudhd81.mongodb.net/?retryWrites=true&w=majority");
    static MongoClient? client = null;
    static IMongoDatabase? database = null;
    static IMongoCollection<BsonDocument>? users = null;
    static IMongoCollection<BsonDocument>? courses = null;
    static IMongoCollection<BsonDocument>? stats = null;


    public static void Connect()
    {
        client = new MongoClient(mongoURL);
        database = client.GetDatabase("ParPalDB");
        users = database.GetCollection<BsonDocument>("users");
        courses = database.GetCollection<BsonDocument>("courses");
        stats = database.GetCollection<BsonDocument>("stats");

        foreach (var db in client.ListDatabases().ToList())
        {
            Console.WriteLine(db);
        }
    }

    public static void AddUser(Golfer golfer)
    {
        if (users is null)
        {
            Console.WriteLine("Error in connecting to Database");
            return;
        }
        BsonDocument doc = golfer.ToBsonDocument();
        users.InsertOne(doc);
    }

    public static Dictionary<int, Golfer> LoadUsers()
    {
        List<BsonDocument> userDocs = users.Find(null).ToList();
        Dictionary<int, Golfer> golferMap = [];

        foreach (BsonDocument doc in userDocs)
        {
            Golfer golfer = new(doc["_id"].AsInt32, doc["username"].AsString, doc["fullname"].AsString, doc["password"].AsString);
            golferMap.Add(golfer.ID, golfer);
        }

        return golferMap;
    }
}
