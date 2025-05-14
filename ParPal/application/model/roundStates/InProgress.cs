
class InProgress : Status {
    public bool handleAddSwing(Swing swing) {
        return false;
    }

    public string handleGetStatus()
    {
        throw new NotImplementedException();
    }

    public bool handleNextHole()
    {
        throw new NotImplementedException();
    }

    Dictionary<string, double> Status.handleEndRound()
    {
        throw new NotImplementedException();
    }
}