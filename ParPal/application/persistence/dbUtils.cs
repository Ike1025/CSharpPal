
using System.Data.Common;
using System.Reflection.Metadata;
using MongoDB.Bson;
using MongoDB.Driver;
class MongoDbUtils
{
    static MongoUrl mongoURL = new("mongodb+srv://myAtlasDBUser:123@myatlasclusteredu.fudhd81.mongodb.net/?retryWrites=true&w=majority");
    static MongoClient? client;
    static IMongoDatabase? database;
    static IMongoCollection<BsonDocument>? users;
    static IMongoCollection<Course>? courses;
    static IMongoCollection<RoundLog>? stats;


    public static void Connect()
    {
        client = new MongoClient(mongoURL);
        database = client.GetDatabase("ParPalDB");
        users = database.GetCollection<BsonDocument>("users");
        courses = database.GetCollection<Course>("courses");
        stats = database.GetCollection<RoundLog>("stats");

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

        users.InsertOne(golfer.ToBsonDocument());
    }

    public static Dictionary<string, Golfer>? LoadUsers()
    {
        if (users is null)
        {
            Console.WriteLine("Error in connecting to Database");
            return null;
        }
        List<BsonDocument>? userDocs = users.Find(new BsonDocument()).ToList();
        Dictionary<string, Golfer> golferMap = [];

        foreach (BsonDocument? golferDoc in userDocs)
        {
            if (golferDoc.IsBsonNull)
            {
                continue;
            }
            Golfer? golfer = new(golferDoc["username"].ToString(), golferDoc["fullname"].ToString(), golferDoc["password"].ToString());
            golferMap.Add(golfer.Username, golfer);
        }

        return golferMap;
    }
}
