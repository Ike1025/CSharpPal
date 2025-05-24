class SearchByName(Searcher searcher, string target) : SearchDecorator(searcher)
{
    readonly string target = target;

    public override Dictionary<int, Course> Search(Dictionary<int, Course> courses)
    {
        Dictionary<int, Course> previousResult = Searcher.Search(courses);
        Dictionary<int, Course> result = [];

        foreach (KeyValuePair<int, Course> pair in previousResult) {
            if (pair.Value.Name.Equals(target, StringComparison.CurrentCultureIgnoreCase))
            {
                result.Add(pair.Key, pair.Value);
            }
        }

        return result;
    }
}