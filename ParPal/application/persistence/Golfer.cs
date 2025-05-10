class Golfer(string username, string fullname, string password) {
    string username = username;
    string fullname = fullname;
    string password = password;
    List<Club> clubs = [];
    Dictionary<int, Course> courses = [];

    public void AddClub(Club club) {
        clubs.Add(club);
    }

    public void PrintClubs() {
        foreach (Club club in clubs) {
            Console.WriteLine(club);
        }
    }
}