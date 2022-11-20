using System.Collections.Generic;

namespace Lab2Searcher
{
    public interface IXmlSearcher
    {
        IEnumerable<Student> Search(SearchCriteria criterionToSearch);
    }
}
