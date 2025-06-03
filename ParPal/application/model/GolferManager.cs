using System.Collections.ObjectModel;

class GolferManager {
    Dictionary<string, Golfer>? golfers;

    public Golfer? CurrentGolfer { get; set; }
    public GolferManager() {
        golfers = MongoDbUtils.LoadUsers();
    }


    public void LoadGolfer(string[] request)
    {
        string username = request[0];

        if (golfers is null)
        {
            Console.WriteLine("error database did not load");
            return;
        }

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

        Golfer golfer = new(username, fullname, password);

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

    public void ViewGolfers()
    {
        if (golfers is null)
        {
            Console.WriteLine("no golfers in application");
            return;
        }
        foreach (Golfer golfer in golfers.Values)
        {
            Console.WriteLine(golfer.ToString());
        }
    }


    public void AddClub(Club club)
    {
        if (CurrentGolfer == null)
        {
            return;
        }

        CurrentGolfer.AddClub(club);

        Console.WriteLine("Successfully add club");
    }
}