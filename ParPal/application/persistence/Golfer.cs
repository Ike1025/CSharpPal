using MongoDB.Bson.Serialization.Attributes;

class Golfer(string username, string fullname, string password)
{
    [BsonElement("username")]
    public string Username { get; } = username;
    [BsonElement("fullname")]
    string Fullname { get; } = fullname;
    [BsonElement("password")]
    string Password { get; } = password;
    [BsonElement("clubs")]
    List<Club> Clubs { get; } = [];
    [BsonElement("courses")]
    Dictionary<int, Course> Courses { get; } = [];

    public void AddClub(Club club)
    {
        Clubs.Add(club);
    }

    public void PrintClubs()
    {
        foreach (Club club in Clubs)
        {
            Console.WriteLine(club);
        }
    }
    
    public override string ToString()
    {
        return Username + " | " + Password + " | " + Fullname;
    }
}