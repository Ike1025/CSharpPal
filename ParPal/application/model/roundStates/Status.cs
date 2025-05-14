interface Status {
    public bool handleAddSwing(Swing swing);
    public bool handleNextHole();
    public Dictionary<string, double> handleEndRound();
    public string handleGetStatus();
}