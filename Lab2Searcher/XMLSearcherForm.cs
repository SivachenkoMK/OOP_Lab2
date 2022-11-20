using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Xsl;
using Lab2Searcher.Model;

namespace Lab2Searcher
{
    public partial class XmlSearcherForm : Form
    {
        private const string FilePath = "Students.xml";
        private IXmlSearcher _searcher;
        private void FillComboBoxes()
        {

            var document = XDocument.Load(FilePath);
            var students = from student in document.Element("read_students")?.Elements("student")
                        select new Student(student.Element("name")?.Value, student.Element("faculty")?.Value,
                          student.Element("discipline")?.Value, Convert.ToInt32(student.Element("mark")?.Value), student.Element("code")?.Value);
            foreach(var student in students)
            {

                if (!nameComboBox.Items.Contains(student.Name))
                {
                    nameComboBox.Items.Add(student.Name);
                }
                if (!facultyComboBox.Items.Contains(student.Faculty))
                {
                    facultyComboBox.Items.Add(student.Faculty);
                }
                if (!disciplineComboBox.Items.Contains(student.Discipline))
                {
                    disciplineComboBox.Items.Add(student.Discipline);
                }
                if (!codeComboBox.Items.Contains(student.Code))
                {
                    codeComboBox.Items.Add(student.Code);
                }
            }
        }

        private void SetDefaultComboBoxes()
        {
            nameComboBox.SelectedItem = nameComboBox.Items[0];
            facultyComboBox.SelectedItem = facultyComboBox.Items[0];
            disciplineComboBox.SelectedItem = disciplineComboBox.Items[0];
            codeComboBox.SelectedItem = codeComboBox.Items[0];
        }
        public XmlSearcherForm()
        {
            InitializeComponent();
            FillComboBoxes();
            SetDefaultComboBoxes();
        }

        private bool DefineSearcher()
        {
            if (sax_api_radioBtn.Checked)
            {
                _searcher = new SaxSearcher(FilePath);
            }
            else if (dom_api_radioBtn.Checked)
            {
                _searcher = new DomSearcher(FilePath);
            }
            else if (linq_to_xml_radioBtn.Checked)
            {
                _searcher = new LinqToXmlSearcher(FilePath);
            }
            else
            {
                return false;
            }
            return true;
        }

        private void SetMarkCriteria(SearchCriteria criteriaToSearch)
        {
            if (!mark_check.Checked) return;
            try
            {
                if (!string.IsNullOrEmpty(fromMark_tb.Text))
                {
                    int? fromMark = Convert.ToInt32(fromMark_tb.Text);
                    criteriaToSearch.FromMark = fromMark;
                }

                if (string.IsNullOrEmpty(toMark_tb.Text)) return;
                int? toMark = Convert.ToInt32(toMark_tb.Text);
                criteriaToSearch.ToMark = toMark;
            }
            catch (FormatException)
            {
                criteriaToSearch.FromMark = null;
                criteriaToSearch.FromMark = null;
                mark_check.Checked = false;
                MessageBox.Show("Wrong mark!");
            }
        }
        private void FillCriteria(out SearchCriteria criteriaToSearch)
        {
            criteriaToSearch = new SearchCriteria();

            if(name_check.Checked)
            {
                criteriaToSearch.Name = nameComboBox.SelectedItem.ToString();
            }

            if (faculty_check.Checked)
            {
                criteriaToSearch.Faculty = facultyComboBox.SelectedItem.ToString();
            }

            if (discipline_check.Checked)
            {
                    criteriaToSearch.Discipline = disciplineComboBox.SelectedItem.ToString();
            }
            if (code_check.Checked)
            {
                criteriaToSearch.Code = codeComboBox.SelectedItem.ToString();
            }
            SetMarkCriteria(criteriaToSearch);
        }

        private void PrintResult(IEnumerable<Student> students)
        {
            var text = new StringBuilder();

            foreach(var student in students)
            {
                text.Append("Name: " + student.Name + "\n");
                text.Append("Faculty: " + student.Faculty + "\n");
                text.Append("Discipline: " + student.Discipline + "\n");
                text.Append("Mark: " + student.Mark + "\n");
                text.Append("Code: " + student.Code + "\n");
                text.Append("\n\n");
            }
            resultsRichTextBox.Text = text.ToString();
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            if(!DefineSearcher())
            {
                MessageBox.Show("Choose search strategy!");
                return;
            }
            FillCriteria(out var criteriaToSearch);

            var students = _searcher.Search(criteriaToSearch);
            PrintResult(students);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            resultsRichTextBox.Text = string.Empty;
        }

        private void to_html_btn_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xct = new XslCompiledTransform();
            xct.Load("IntermedFile.xsl");
            string htmlPath = "Students.html";
            xct.Transform(FilePath, htmlPath);
            Process.Start(htmlPath);
        }
    }
}
