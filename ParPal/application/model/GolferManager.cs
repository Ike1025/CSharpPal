using System.Collections.ObjectModel;

class GolferManager {
    Dictionary<string, Golfer> golfers;
    Golfer? currentGolfer;
    public GolferManager() {
        golfers = [];
    }

    public void LoadGolfer(string[] request) {
        string username = request[0];

        if (!golfers.TryGetValue(username, out Golfer? value)) {
            Console.WriteLine("User does not exist");
            return;
        }

        currentGolfer = value;
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

        currentGolfer = golfer;

        Console.WriteLine("Profile succesfully created");
        Console.WriteLine("Welcome " + username + "!");
    } 
}