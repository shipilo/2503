using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace _2503_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StudyMaterials data = null;
            try
            {
                DirectoryInfo directory = new DirectoryInfo(Environment.CurrentDirectory);
                MemoryStream ms = new MemoryStream(File.ReadAllBytes(directory.Parent.Parent.FullName + "\\data.xml"));
                XmlSerializer serializer = new XmlSerializer(typeof(StudyMaterials));
                data = (StudyMaterials)serializer.Deserialize(ms);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (data != null)
            {
                foreach (Book book in data.Books.BookArray)
                {
                    dgv1.Rows.Add(book.bId, book.bTitle, book.bAuthor, book.bSection, book.bYear, book.bPages);
                }
                foreach (Lecture lecture in data.Lectures.LectureArray)
                {
                    dgv2.Rows.Add(lecture.lId, lecture.lTitle, lecture.lAuthor, lecture.lSection, lecture.lDuration, lecture.lLink, lecture.lFormat);
                }
                foreach (Abstract @abstract in data.Abstracts.AbstractArray)
                {
                    dgv3.Rows.Add(@abstract.aId, @abstract.aTitle, @abstract.aAuthor, @abstract.aSection, String.Join(", ", @abstract.aKeywords.KeywordsArray), @abstract.aSource);
                }
            }
        }
    }
}
