
namespace Lab2Searcher
{
    partial class XmlSearcherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.name_check = new System.Windows.Forms.CheckBox();
            this.discipline_check = new System.Windows.Forms.CheckBox();
            this.mark_check = new System.Windows.Forms.CheckBox();
            this.code_check = new System.Windows.Forms.CheckBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.disciplineComboBox = new System.Windows.Forms.ComboBox();
            this.codeComboBox = new System.Windows.Forms.ComboBox();
            this.sax_api_radioBtn = new System.Windows.Forms.RadioButton();
            this.dom_api_radioBtn = new System.Windows.Forms.RadioButton();
            this.linq_to_xml_radioBtn = new System.Windows.Forms.RadioButton();
            this.resultsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.to_html_btn = new System.Windows.Forms.Button();
            this.fromMark_tb = new System.Windows.Forms.TextBox();
            this.toMark_tb = new System.Windows.Forms.TextBox();
            this.facultyComboBox = new System.Windows.Forms.ComboBox();
            this.faculty_check = new System.Windows.Forms.CheckBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name_check
            // 
            this.name_check.AutoSize = true;
            this.name_check.Location = new System.Drawing.Point(27, 156);
            this.name_check.Margin = new System.Windows.Forms.Padding(4);
            this.name_check.Name = "name_check";
            this.name_check.Size = new System.Drawing.Size(67, 21);
            this.name_check.TabIndex = 0;
            this.name_check.Text = "Name";
            this.name_check.UseVisualStyleBackColor = true;
            // 
            // discipline_check
            // 
            this.discipline_check.AutoSize = true;
            this.discipline_check.Location = new System.Drawing.Point(433, 102);
            this.discipline_check.Margin = new System.Windows.Forms.Padding(4);
            this.discipline_check.Name = "discipline_check";
            this.discipline_check.Size = new System.Drawing.Size(90, 21);
            this.discipline_check.TabIndex = 1;
            this.discipline_check.Text = "Discipline";
            this.discipline_check.UseVisualStyleBackColor = true;
            // 
            // mark_check
            // 
            this.mark_check.AutoSize = true;
            this.mark_check.Location = new System.Drawing.Point(843, 128);
            this.mark_check.Margin = new System.Windows.Forms.Padding(4);
            this.mark_check.Name = "mark_check";
            this.mark_check.Size = new System.Drawing.Size(61, 21);
            this.mark_check.TabIndex = 2;
            this.mark_check.Text = "Mark";
            this.mark_check.UseVisualStyleBackColor = true;
            // 
            // code_check
            // 
            this.code_check.AutoSize = true;
            this.code_check.Location = new System.Drawing.Point(435, 156);
            this.code_check.Margin = new System.Windows.Forms.Padding(4);
            this.code_check.Name = "code_check";
            this.code_check.Size = new System.Drawing.Size(63, 21);
            this.code_check.TabIndex = 3;
            this.code_check.Text = "Code";
            this.code_check.UseVisualStyleBackColor = true;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(117, 154);
            this.nameComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(285, 24);
            this.nameComboBox.TabIndex = 4;
            // 
            // disciplineComboBox
            // 
            this.disciplineComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplineComboBox.FormattingEnabled = true;
            this.disciplineComboBox.Location = new System.Drawing.Point(531, 96);
            this.disciplineComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.disciplineComboBox.Name = "disciplineComboBox";
            this.disciplineComboBox.Size = new System.Drawing.Size(291, 24);
            this.disciplineComboBox.TabIndex = 5;
            // 
            // codeComboBox
            // 
            this.codeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.codeComboBox.FormattingEnabled = true;
            this.codeComboBox.Location = new System.Drawing.Point(531, 146);
            this.codeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.codeComboBox.Name = "codeComboBox";
            this.codeComboBox.Size = new System.Drawing.Size(291, 24);
            this.codeComboBox.TabIndex = 7;
            // 
            // sax_api_radioBtn
            // 
            this.sax_api_radioBtn.AutoSize = true;
            this.sax_api_radioBtn.Location = new System.Drawing.Point(27, 36);
            this.sax_api_radioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.sax_api_radioBtn.Name = "sax_api_radioBtn";
            this.sax_api_radioBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sax_api_radioBtn.Size = new System.Drawing.Size(81, 21);
            this.sax_api_radioBtn.TabIndex = 8;
            this.sax_api_radioBtn.TabStop = true;
            this.sax_api_radioBtn.Text = "SAX API";
            this.sax_api_radioBtn.UseVisualStyleBackColor = true;
            // 
            // dom_api_radioBtn
            // 
            this.dom_api_radioBtn.AutoSize = true;
            this.dom_api_radioBtn.Location = new System.Drawing.Point(135, 36);
            this.dom_api_radioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.dom_api_radioBtn.Name = "dom_api_radioBtn";
            this.dom_api_radioBtn.Size = new System.Drawing.Size(86, 21);
            this.dom_api_radioBtn.TabIndex = 9;
            this.dom_api_radioBtn.TabStop = true;
            this.dom_api_radioBtn.Text = "DOM API";
            this.dom_api_radioBtn.UseVisualStyleBackColor = true;
            // 
            // linq_to_xml_radioBtn
            // 
            this.linq_to_xml_radioBtn.AutoSize = true;
            this.linq_to_xml_radioBtn.Location = new System.Drawing.Point(261, 36);
            this.linq_to_xml_radioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.linq_to_xml_radioBtn.Name = "linq_to_xml_radioBtn";
            this.linq_to_xml_radioBtn.Size = new System.Drawing.Size(109, 21);
            this.linq_to_xml_radioBtn.TabIndex = 10;
            this.linq_to_xml_radioBtn.TabStop = true;
            this.linq_to_xml_radioBtn.Text = "LINQ to XML";
            this.linq_to_xml_radioBtn.UseVisualStyleBackColor = true;
            // 
            // resultsRichTextBox
            // 
            this.resultsRichTextBox.Location = new System.Drawing.Point(27, 201);
            this.resultsRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.resultsRichTextBox.Name = "resultsRichTextBox";
            this.resultsRichTextBox.ReadOnly = true;
            this.resultsRichTextBox.Size = new System.Drawing.Size(1271, 474);
            this.resultsRichTextBox.TabIndex = 11;
            this.resultsRichTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1008, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "from";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1008, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "to";
            // 
            // to_html_btn
            // 
            this.to_html_btn.Location = new System.Drawing.Point(1332, 289);
            this.to_html_btn.Margin = new System.Windows.Forms.Padding(4);
            this.to_html_btn.Name = "to_html_btn";
            this.to_html_btn.Size = new System.Drawing.Size(257, 36);
            this.to_html_btn.TabIndex = 15;
            this.to_html_btn.Text = "transform to html";
            this.to_html_btn.UseVisualStyleBackColor = true;
            this.to_html_btn.Click += new System.EventHandler(this.to_html_btn_Click);
            // 
            // fromMark_tb
            // 
            this.fromMark_tb.Location = new System.Drawing.Point(1052, 96);
            this.fromMark_tb.Margin = new System.Windows.Forms.Padding(4);
            this.fromMark_tb.Name = "fromMark_tb";
            this.fromMark_tb.Size = new System.Drawing.Size(132, 22);
            this.fromMark_tb.TabIndex = 16;
            // 
            // toMark_tb
            // 
            this.toMark_tb.Location = new System.Drawing.Point(1052, 143);
            this.toMark_tb.Margin = new System.Windows.Forms.Padding(4);
            this.toMark_tb.Name = "toMark_tb";
            this.toMark_tb.Size = new System.Drawing.Size(132, 22);
            this.toMark_tb.TabIndex = 17;
            // 
            // facultyComboBox
            // 
            this.facultyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.facultyComboBox.FormattingEnabled = true;
            this.facultyComboBox.Location = new System.Drawing.Point(117, 97);
            this.facultyComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.facultyComboBox.Name = "facultyComboBox";
            this.facultyComboBox.Size = new System.Drawing.Size(285, 24);
            this.facultyComboBox.TabIndex = 19;
            // 
            // faculty_check
            // 
            this.faculty_check.AutoSize = true;
            this.faculty_check.Location = new System.Drawing.Point(27, 100);
            this.faculty_check.Margin = new System.Windows.Forms.Padding(4);
            this.faculty_check.Name = "faculty_check";
            this.faculty_check.Size = new System.Drawing.Size(75, 21);
            this.faculty_check.TabIndex = 18;
            this.faculty_check.Text = "Faculty";
            this.faculty_check.UseVisualStyleBackColor = true;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(1332, 201);
            this.search_btn.Margin = new System.Windows.Forms.Padding(4);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(257, 36);
            this.search_btn.TabIndex = 20;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(1332, 245);
            this.clear_btn.Margin = new System.Windows.Forms.Padding(4);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(257, 36);
            this.clear_btn.TabIndex = 21;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // XMLSearcherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1668, 740);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.facultyComboBox);
            this.Controls.Add(this.faculty_check);
            this.Controls.Add(this.toMark_tb);
            this.Controls.Add(this.fromMark_tb);
            this.Controls.Add(this.to_html_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsRichTextBox);
            this.Controls.Add(this.linq_to_xml_radioBtn);
            this.Controls.Add(this.dom_api_radioBtn);
            this.Controls.Add(this.sax_api_radioBtn);
            this.Controls.Add(this.codeComboBox);
            this.Controls.Add(this.disciplineComboBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.code_check);
            this.Controls.Add(this.mark_check);
            this.Controls.Add(this.discipline_check);
            this.Controls.Add(this.name_check);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "XmlSearcherForm";
            this.Text = "XMLSearcherForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.CheckBox name_check;
        private System.Windows.Forms.CheckBox discipline_check;
        private System.Windows.Forms.CheckBox mark_check;
        private System.Windows.Forms.CheckBox code_check;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.ComboBox disciplineComboBox;
        private System.Windows.Forms.ComboBox codeComboBox;
        private System.Windows.Forms.RadioButton sax_api_radioBtn;
        private System.Windows.Forms.RadioButton dom_api_radioBtn;
        private System.Windows.Forms.RadioButton linq_to_xml_radioBtn;
        private System.Windows.Forms.RichTextBox resultsRichTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button to_html_btn;
        private System.Windows.Forms.TextBox fromMark_tb;
        private System.Windows.Forms.TextBox toMark_tb;
        private System.Windows.Forms.ComboBox facultyComboBox;
        private System.Windows.Forms.CheckBox faculty_check;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button clear_btn;
    }
}

