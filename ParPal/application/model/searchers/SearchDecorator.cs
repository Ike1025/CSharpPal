
abstract class SearchDecorator : Searcher
{
    public Searcher Searcher;

    public SearchDecorator(Searcher searcher)
    {
        
        Searcher = searcher;
    }
    public virtual Dictionary<int, Course> Search(Dictionary<int, Course> courses)
    {
        return Searcher.Search(courses);
    }
}