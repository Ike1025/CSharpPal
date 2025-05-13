class CreateGolfer(string keyword, GolferManager golferManager) : Request {
    public string Keyword {get;} = keyword;
    GolferManager golferManager = golferManager;
    public void Execute() {
        string[] request = new string[3];
        Console.Write("Please enter username: ");
        string? username = Console.ReadLine();
        if (username != null) {
            request[0] = username.Trim();
        } else {
            Console.WriteLine("Please enter a username");
        }
        Console.Write("Please enter full name: ");
        string? fullName = Console.ReadLine();
        if (fullName != null) {
            request[1] = fullName.Trim();
        } else {
            Console.WriteLine("Please enter a full name");
        }
        Console.Write("Please enter password: ");
        string? password = Console.ReadLine();
        if (password != null) {
            request[2] = password.Trim();
        } else {
            Console.WriteLine("Please enter a password");
        }

        golferManager.CreateGolfer(request);
    }
}