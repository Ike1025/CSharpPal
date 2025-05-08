class RequestClient {
    Dictionary<string, Request> requests = [];

    public RequestClient() {
        GolferManager golferManager = new();


        CreateGolfer createGolfer = new("creategolfer", golferManager);
        requests.Add("creategolfer", createGolfer);
    }


}