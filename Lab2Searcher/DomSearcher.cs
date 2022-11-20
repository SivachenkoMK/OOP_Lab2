using System;
using System.Collections.Generic;
using System.Xml;

namespace Lab2Searcher
{
    public class DomSearcher : IXmlSearcher
    {
        private readonly string _filePath;
        public DomSearcher(string filePath)
        {
            _filePath = filePath;
        }
        public IEnumerable<Student> Search(SearchCriteria criterionToSearch)
        {
            var result = new List<Student>();
            var doc = new XmlDocument();
            var xr = XmlReader.Create(_filePath);
            doc.Load(xr);
            var students = doc.GetElementsByTagName("student");//get all students
            for (int i = 0; i < students.Count; i++)
            {
                var studentsInfo = students.Item(i)?.ChildNodes;//get info of a student
                if (StudentFitToUs(studentsInfo, criterionToSearch, out var student))
                {
                    result.Add(student);
                }
            }
            return result;
        }

        private bool Validate(string criteria, string value)//check whether criteria exists, if so, check this criteria
        {
            return string.IsNullOrEmpty(criteria) || criteria == value;
        }

        private (string name, string faculty, string discipline, int mark, string code) ReadStudent(XmlNodeList studentInfo)
        {
            var faculty = string.Empty;
            var name = string.Empty;
            var discipline = string.Empty;
            int mark = default;
            var code = string.Empty;
            
            for (var i = 0; i < studentInfo.Count; i++)
            {
                var currentNode = studentInfo.Item(i);
                switch (currentNode?.Name)
                {
                    case "name":
                        name = currentNode.InnerText;
                        break;
                    case "faculty":
                        faculty = currentNode.InnerText;
                        break;
                    case "discipline":
                        discipline = currentNode.InnerText;
                        break;
                    case "mark":
                        if (!int.TryParse(currentNode.InnerText, out mark))
                        {
                            throw new InvalidOperationException("Invalid XML file at mark.");//TODO: extract to string constants
                        }
                        break;
                    case "code":
                        code = currentNode.InnerText;
                        break;
                    default:
                        throw new InvalidOperationException("Unknown element type " + currentNode?.Name);
                }
            }
            return (name, faculty, discipline, mark, code);
        }

        private bool StudentFitToUs(XmlNodeList studentInfo, SearchCriteria criteriaToSearch, out Student student)
        {
            student = default;//there will be null

            var (name, faculty, discipline, mark, code) = ReadStudent(studentInfo);

            if (!Validate(criteriaToSearch.Name, name)) { return false; }
            if (!Validate(criteriaToSearch.Faculty, faculty)) { return false; }
            if (!Validate(criteriaToSearch.Discipline, discipline)) { return false; }
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
            if (!Validate(criteriaToSearch.Code, code)) { return false; }

            student = new Student(name, faculty, discipline, mark, code);
            return true;
        }
    }
}
