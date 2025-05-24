class Course(int id, string name, float difficulty, string city, string state, int numOfHoles, int totalPar, List<int> parPerHole)
{
    public int Id { get; } = id;
    public string Name { get; } = name;
    public float Difficulty { get; } = difficulty;
    public string City { get; } = city;
    public string State { get; } = state;
    public int NumOfHoles { get; } = numOfHoles;
    public int TotalPar { get; } = totalPar;
    public List<int> ParPerHole { get; } = parPerHole;

    public override string ToString()
    {
        string holes = "";
        for (int i=0; i < ParPerHole.Count; i++) {
            if (i < ParPerHole.Count-1) {
                holes += ParPerHole.Count + ";";
            } else {
                holes += ParPerHole.Count;
            }
        }
        return Name + ", " + Difficulty + ", " + City + ", " + State + ", " + NumOfHoles + ", " + TotalPar + ", " + holes;
    }
}