
using System.Data.Common;
using System.Reflection.Metadata;
using MongoDB.Bson;
using MongoDB.Driver;
class MongoDbUtils
{
    static MongoUrl mongoURL = new("mongodb+srv://myAtlasDBUser:123@myatlasclusteredu.fudhd81.mongodb.net/?retryWrites=true&w=majority");
    static MongoClient? client = null;
    static IMongoDatabase? database = null;
    static IMongoCollection<Golfer>? users = null;
    static IMongoCollection<Course>? courses = null;
    static IMongoCollection<RoundLog>? stats = null;


    public static void Connect()
    {
        client = new MongoClient(mongoURL);
        database = client.GetDatabase("ParPalDB");
        users = database.GetCollection<Golfer>("users");
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

        users.InsertOne(golfer);
    }

    public static Dictionary<string, Golfer> LoadUsers()
    {
        if (users is null)
        {
            
        }
        List<Golfer> userDocs = users.Find(new BsonDocument()).ToList();
        Dictionary<string, Golfer> golferMap = [];

        foreach (Golfer golfer in userDocs)
        {
            golferMap.Add(golfer.Username, golfer);
        }

        return golferMap;
    }
}
