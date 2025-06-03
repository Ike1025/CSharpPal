class RequestClient {
    Dictionary<string, Request> requests = [];

    public RequestClient()
    {
        GolferManager golferManager = new();


        CreateGolfer createGolfer = new("createprofile", golferManager);
        requests.Add(createGolfer.Keyword, createGolfer);

        LoadGolfer loadGolfer = new("loadprofile", golferManager);
        requests.Add(loadGolfer.Keyword, loadGolfer);

        AddClub addClub = new("addclub", golferManager);
        requests.Add(addClub.Keyword, addClub);

        ViewClubs viewClubs = new("viewclubs", golferManager);
        requests.Add(viewClubs.Keyword, viewClubs);

        ViewGolfers viewGolfers = new("viewgolfers", golferManager);
        requests.Add(viewGolfers.Keyword, viewGolfers);
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