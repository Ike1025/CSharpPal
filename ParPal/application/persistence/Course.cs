class Course(int id, string name, float difficulty, string city, string state, int numOfHoles, int totalPar, List<int> parPerHole) {
    int Id{get;} = id;
    string Name{get;} = name;
    float Difficulty{get;} = difficulty;
    string City{get;} = city;
    string State{get;} = state;
    public int NumOfHoles{get;} = numOfHoles;
    int TotalPar{get;} = totalPar;
    List<int> ParPerHole{get;} = parPerHole;
}