class LoadGolfer(string keyword, GolferManager golferManager) : Request {
    public string Keyword {get;} = keyword;
    GolferManager golferManager = golferManager;
    public void Execute() {
        string[] request = new string[1];
        Console.Write("Please enter username: ");
        string? username = Console.ReadLine();
        if (username != null) {
            request[0] = username.Trim();
        } else {
            Console.WriteLine("Please enter a username");
        }

        golferManager.LoadGolfer(request);
    }
}