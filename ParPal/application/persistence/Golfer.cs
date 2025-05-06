using System.Data.Common;

class Golfer(int ID, string username, string fullname)
{
    private int id = ID;
    private string username = username;
    private string fullname = fullname;
    private Dictionary<int, Club> clubs = new Dictionary<int, Club>();
}