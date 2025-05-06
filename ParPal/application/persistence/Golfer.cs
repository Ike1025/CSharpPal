using System.Data.Common;

class Golfer(int ID, string username, string fullname)
{
    int id = ID;
    string username = username;
    string fullname = fullname;
    Dictionary<int, Club> clubs = new Dictionary<int, Club>();
}