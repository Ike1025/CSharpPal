class RoundManager(GolferManager golferManager) {
    GolferManager GolferManager{get; set;} = golferManager;

    RoundLog? CurrentRound{get; set;} = null;

    Status Status = new Finished();
}