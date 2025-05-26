using System.Collections.ObjectModel;

class GolferManager {
    Dictionary<string, Golfer> golfers;
    int userId = 0;

    public Golfer? CurrentGolfer { get; set; }
    public GolferManager() {
        golfers = [];
    }

    private int NextId()
    {
        int id = userId;
        userId++;
        return id;
    }

    public void LoadGolfer(string[] request)
    {
        string username = request[0];

        if (!golfers.TryGetValue(username, out Golfer? value))
        {
            Console.WriteLine("User does not exist");
            return;
        }

        CurrentGolfer = value;
        Console.WriteLine("Welcome " + username + "!");
    }

    public void CreateGolfer(string[] request) {
        string username = request[0];
        string fullname = request[1];
        string password = request[2];

        Golfer golfer = new(NextId(), username, fullname, password);

        if (golfers.ContainsKey(username)) {
            Console.WriteLine("Username is already taken. Please pick a different username");
            return;
        }

        golfers.Add(username, golfer);

        CurrentGolfer = golfer;

        MongoDbUtils.AddUser(golfer);

        Console.WriteLine("Profile succesfully created");
        Console.WriteLine("Welcome " + username + "!");
    } 


    public void AddClub(Club club) {
        if (CurrentGolfer == null) {
            return;
        }

        CurrentGolfer.AddClub(club);

        Console.WriteLine("Successfully add club");
    }
}