using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Lab2Searcher
{
    class LinqToXmlSearcher : IXmlSearcher
    {
        private readonly string _filePath;
        public LinqToXmlSearcher(string filePath)
        {
            _filePath = filePath;
        }
        bool Validate(string criteria, string value)//check whether criteria exists, if so, check this criteria
        {
            return string.IsNullOrEmpty(criteria) || criteria == value;
        }

        private bool IsAppropriateStudent(SearchCriteria criteriaToSearch, string name, string faculty, string discipline,
            int mark, string code)
        {
            return Validate(criteriaToSearch.Name, name) &&
                Validate(criteriaToSearch.Faculty, faculty) &&
                Validate(criteriaToSearch.Discipline, discipline) &&
                !(criteriaToSearch.ToMark.HasValue &&
                mark > criteriaToSearch.ToMark) &&
                !(criteriaToSearch.FromMark.HasValue &&
                mark < criteriaToSearch.FromMark) &&
                Validate(criteriaToSearch.Code, code);
        }
        public IEnumerable<Student> Search(SearchCriteria criterionToSearch)
        {
            var document = XDocument.Load(_filePath);
            var result = from student in document.Element("read_students")?.Elements("student")
                         where IsAppropriateStudent(criterionToSearch, student.Element("name")?.Value, student.Element("faculty")?.Value,
                          student.Element("discipline")?.Value, Convert.ToInt32(student.Element("mark")?.Value), student.Element("code")?.Value)
                         select new Student(student.Element("name")?.Value, student.Element("faculty")?.Value,
                          student.Element("discipline")?.Value, Convert.ToInt32(student.Element("mark")?.Value), student.Element("code")?.Value);
            return result;
        }
    }
}
