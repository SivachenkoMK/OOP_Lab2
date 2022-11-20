using System;
using System.Collections.Generic;
using System.Xml;
using Lab2Searcher.Model;

namespace Lab2Searcher
{
    class SaxSearcher : IXmlSearcher
    {
        private readonly string _filePath;
        public SaxSearcher(string filePath)
        {
            _filePath = filePath;
        }
        public IEnumerable<Student> Search(SearchCriteria criterionToSearch)
        {
            List<Student> result = new List<Student>();
            using (var xr = XmlReader.Create(_filePath))
            {
                while (xr.Read())
                {
                    if (xr.NodeType != XmlNodeType.Element) continue;
                    
                    if (xr.Name == "student" &&
                        IsRequestedStudent(xr, criterionToSearch,
                            out var student)) //if element is student, check student by criteria
                    {
                        result.Add(student); //if student is appropriate add it to result
                    }
                }
            }
            return result;
        }

        private (string faculty, string name, string discipline, int mark, string code) ReadStudent(XmlReader xr)
        {
            var currentElement = string.Empty;
            var faculty = string.Empty;
            var name = string.Empty;
            var discipline = string.Empty;
            int mark = default;
            var code = string.Empty;

            while (xr.Read() && xr.Name != "student")
            {
                switch (xr.NodeType)
                {
                    case XmlNodeType.Element:
                        currentElement = xr.Name;
                        break;
                    case XmlNodeType.Text:
                        switch (currentElement)
                        {
                            case "name":
                                name = xr.Value;
                                break;
                            case "faculty":
                                faculty = xr.Value;
                                break;
                            case "discipline":
                                discipline = xr.Value;
                                break;
                            case "mark":
                                if (!int.TryParse(xr.Value, out mark))
                                {
                                    throw new InvalidOperationException("Invalid XML file at mark.");
                                }
                                break;
                            case "code":
                                code = xr.Value;
                                break;
                            default:
                                throw new InvalidOperationException("Unknown element type " + currentElement);
                        }
                        break;
                }

            }

            return (faculty, name, discipline, mark, code);
        }

        private bool IsRequestedStudent(XmlReader xr, SearchCriteria criteriaToSearch, out Student student)
        {
            student = default;//there will be null
            
            var (faculty, name, discipline, mark, code) = ReadStudent(xr);
            
            if (!Validate(criteriaToSearch.Name, name)) { return false; }
            if (!Validate(criteriaToSearch.Faculty, faculty)){ return false; }
            if (!Validate(criteriaToSearch.Discipline, discipline)){ return false; }
            if (criteriaToSearch.FromMark.HasValue &&
                mark < criteriaToSearch.FromMark)
            {
                return false;
            }
            if (criteriaToSearch.ToMark.HasValue &&
                mark > criteriaToSearch.ToMark)
            {
                return false;
            }
            if (!Validate(criteriaToSearch.Code, code)){ return false; }

            student = new Student(name, faculty, discipline, mark, code);
            return true;
        }

        bool Validate(string criteria, string value)//check whether criteria exists, if so, check this criteria
        {
            return string.IsNullOrEmpty(criteria) || criteria == value;
        }
    }
}