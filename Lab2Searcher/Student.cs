using System;

namespace Lab2Searcher
{
    public class Student
    {
        private const int HighestMark = 100;
        public string Name { get; private set; }
        public string Faculty { get; private set; }
        public string Discipline { get; private set; }
        public int Mark { get; private set; }
        public string Code { get; private set; }
        public Student(string name, string faculty, string discipline, int mark, string code)
        {
            if(mark >= 0 && mark <= HighestMark)
            {
                Mark = mark;
            }
            else
            {
                throw new ArgumentException("Inappropriate mark");
            }
            Name = name;
            Faculty = faculty;
            Discipline = discipline;
            Code = code;
        }
    }
}
