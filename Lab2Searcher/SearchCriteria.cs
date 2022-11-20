using System;

namespace Lab2Searcher
{
    public class SearchCriteria
    {
        private int? _fromMark;
        private int? _toMark;

        public string Name { get; set; }
        public string Faculty { get; set; }
        public string Discipline { get; set; }
        public string Code { get; set; }
        public int? FromMark 
        {
            get => _fromMark; 
            set
            {
                if(value < 0)
                {
                    _fromMark = 0;
                }
                _fromMark = value;
            }
        }
        public int? ToMark
        {
            get => _toMark;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Wrong mark!");
                }
                _toMark = value;
            }
        }
    }
}
