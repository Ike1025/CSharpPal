class DatabaseManager
{
    Dictionary<int, Course> courses = [];
    Dictionary<int, Course> filteredCourses = [];

    public void SearchCourse(Dictionary<string, string> request) {
        foreach (string key in request.Keys)
        {
            string searchType = key;
            string targetValue = request[key];

            


        }
    }
}