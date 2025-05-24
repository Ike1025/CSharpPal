class DatabaseManager
{
    Dictionary<int, Course> courses = [];
    Dictionary<int, Course> filteredCourses = [];

    public void SearchCourse(Dictionary<string, string> request)
    {
        Searcher searcher = new SearchAll();
        foreach (string key in request.Keys)
        {
            string searchType = key;
            string targetValue = request[key];

            switch (searchType)
            {
                case "name":
                    searcher = new SearchByName(searcher, targetValue);
                    break;
            }
        }

        Dictionary<int, Course> result = searcher.Search(courses);
        filteredCourses = result;
        PrintFilteredCourses();
    }

    private void PrintFilteredCourses()
    {
        foreach (KeyValuePair<int, Course> pair in filteredCourses)
        {
            Console.WriteLine(pair.Key + ":" + pair.Value);
        }
    }
}