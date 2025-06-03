class ViewGolfers(string keyword, GolferManager golferManager) : Request {
    public string Keyword {get;} = keyword;
    GolferManager golferManager = golferManager;
    public void Execute() {
        golferManager.ViewGolfers();
    }
}