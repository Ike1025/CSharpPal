class RoundLog {
    Course? course;
    int currentHole;
    int numOfHoles;
    string username;
    DateTime date;
    List<Hole> holes;

    public RoundLog(Course course, int currentHole, DateTime date, string username) {
        this.course = course;
        this.currentHole = currentHole;
        this.date = date;
        this.username = username;
        holes = [];

        for (int i = 0; i < course.NumOfHoles; i++) {
            holes.Add(new(i));
        }
    }
}