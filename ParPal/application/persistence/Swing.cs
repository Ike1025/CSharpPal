class Swing(double distance, Club club) {

    private double Distance {get;} = distance;
    private Club club = club;

    public static void method() {
        Swing swing = new Swing(5.0, new Club(ClubType.DRIVER_1, new Golfer(0, "ash", "charle")));
        Console.WriteLine(swing.Distance);
    }
}