class ViewClubs(string keyword, GolferManager golferManager) : Request {
    public string Keyword {get;} = keyword;
    GolferManager golferManager = golferManager;
    public void Execute() {
        if (golferManager.CurrentGolfer == null) {
            Console.WriteLine("Please log in before viewing club");
            return;
        }

        golferManager.CurrentGolfer.PrintClubs();
    }
}