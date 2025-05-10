class Club(ClubType clubType, Golfer golfer, string manufacturer, string name) {
    private ClubType clubType = clubType;
    private Golfer golfer = golfer;
    private string manufacturer = manufacturer;
    private string name = name;

    public override string ToString() {
        return "Name: " + name + ", Manufacturer: " + manufacturer + ", Club Type: " + clubType.ToString();
    }
}