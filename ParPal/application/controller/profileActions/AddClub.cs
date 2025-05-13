class AddClub(string keyword, GolferManager golferManager) : Request {
    public string Keyword {get;} = keyword;
    GolferManager golferManager = golferManager;
    public void Execute() {
        if (golferManager.CurrentGolfer == null) {
            Console.WriteLine("Please log in before adding club");
            return;
        }

        Console.WriteLine("Please select club type from list");
        Console.WriteLine("DRIVER_1\tDRIVER_WOOD\tWOOD_3\tWOOD_4\t" +
        "WOOD_5\nIRON_3\tIRON_4\tIRON_5\tIRON_6\tIRON_7\tIRON_8\tIRON_9\n" + 
        "HYBRID\tPITCHING_WEDGE\tSAND_WEDGE\tGAP_WEDGE\tLOB_WEDGE\tPUTTER");
        string? input = Console.ReadLine();

        if (input == null) {
            Console.WriteLine("Please enter value");
            return;
        }

        bool converted = Enum.TryParse(input.Trim().ToUpper(), out ClubType type);

        if (!converted) {
            Console.WriteLine("invalid club type");
            return;
        }

        Console.Write("Please enter Manufacturer: ");

        input = Console.ReadLine();

        if (input == null) {
            Console.WriteLine("Please enter value");
            return;
        }

        string manufacturer = input.Trim();

        Console.Write("Please enter club name: ");

        input = Console.ReadLine();

        if (input == null) {
            Console.WriteLine("Please enter value");
            return;
        }

        string name = input.Trim();

        Club club = new(type, golferManager.CurrentGolfer, manufacturer, name);

        golferManager.AddClub(club);


    }
}