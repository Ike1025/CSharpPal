class RequestClient {
    Dictionary<string, Request> requests = [];

    public RequestClient() {
        GolferManager golferManager = new();


        CreateGolfer createGolfer = new("createprofile", golferManager);
        requests.Add("createprofile", createGolfer);

        LoadGolfer loadGolfer = new("loadprofile", golferManager);
        requests.Add("loadprofile", loadGolfer);

        AddClub addClub = new("addclub", golferManager);
        requests.Add("addclub", addClub);

        ViewClubs viewClubs = new("viewclubs", golferManager);
        requests.Add("viewclubs", viewClubs);
    }
    public void ExecuteCommand(string input) {
        string command = input.ToLower().Trim();
        command = command.Replace(" ", "");

        bool commandFound = CheckCommand(command);

        if (command.Equals("help")) {
            return;
        }

        if (commandFound == false) {
            Console.WriteLine("Invalid command. Type \"help\" to see list of commands");
            return;
        } else {
            Request request = requests[command];
            
            request.Execute();
        }
    }

    private bool CheckCommand(string command) {
        command = command.ToLower();
        if (requests.ContainsKey(command)) {
            return true;
        }
        return false;
    }

}