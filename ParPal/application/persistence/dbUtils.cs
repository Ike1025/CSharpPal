
using MongoDB.Driver;
class MongoDbUtils {
    static MongoUrl mongoURL = new MongoUrl("mongodb+srv://myAtlasDBUser:123@myatlasclusteredu.fudhd81.mongodb.net/?retryWrites=true&w=majority");
    static MongoClient? client = null;


    public static void Connect() {
        client = new MongoClient(mongoURL);
    }
}
