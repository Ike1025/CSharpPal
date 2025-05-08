class RequestClient {
    Dictionary<string, Request> requests = [];

    public RequestClient() {
        GolferManager golferManager = new();


        CreateGolfer createGolfer = new("createprofile", golferManager);
        requests.Add("createprofile", createGolfer);
    }
    public void executeCommand(string input) {
        string command = input.ToLower();
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