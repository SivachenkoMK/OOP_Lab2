using System.Collections.Generic;

namespace Lab2Searcher.Model
{
    public interface IXmlSearcher
    {
        IEnumerable<Student> Search(SearchCriteria criterionToSearch);
    }
}
