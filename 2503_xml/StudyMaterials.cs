using System.Xml.Serialization;

namespace _2503_xml
{
    /*public abstract class StudyMaterial
    {
        public string Title;
        public Person Author;
        public string Section;
    }*/

    [XmlRoot("StudyMaterials")]
    public class StudyMaterials
    {
        [XmlElement("books")]
        public Books Books { get; set; }

        [XmlElement("lectures")]
        public Lectures Lectures { get; set; }

        [XmlElement("abstracts")]
        public Abstracts Abstracts { get; set; }
    }

    public class Books
    {
        [XmlElement("book")]
        public Book[] BookArray { get; set; }
    }

    public class Lectures
    {
        [XmlElement("lecture")]
        public Lecture[] LectureArray { get; set; }
    }

    public class Abstracts
    {
        [XmlElement("abstract")]
        public Abstract[] AbstractArray { get; set; }
    }

    public class Keywords
    {
        [XmlElement("keyword")]
        public string[] KeywordsArray { get; set; }
    }

    public class Book
    {
        [XmlAttribute("id")]
        public int bId { get; set; }

        [XmlElement("title")]
        public string bTitle { get; set; }

        [XmlElement("author")]
        public string bAuthor { get; set; }

        [XmlElement("section")]
        public string bSection { get; set; }

        [XmlElement("year")]
        public int bYear { get; set; }

        [XmlElement("pages")]
        public int bPages { get; set; }
    }

    public class Lecture
    {
        [XmlAttribute("id")]
        public int lId { get; set; }

        [XmlElement("title")]
        public string lTitle { get; set; }

        [XmlElement("author")]
        public string lAuthor { get; set; }

        [XmlElement("section")]
        public string lSection { get; set; }

        [XmlElement("duration")]
        public int lDuration { get; set; }

        [XmlElement("link")]
        public string lLink { get; set; }

        [XmlElement("format")]
        public string lFormat { get; set; }
    }

    public class Abstract
    {
        [XmlAttribute("id")]
        public int aId { get; set; }

        [XmlElement("title")]
        public string aTitle { get; set; }

        [XmlElement("author")]
        public string aAuthor { get; set; }

        [XmlElement("section")]
        public string aSection { get; set; }

        [XmlElement("keywords")]
        public Keywords aKeywords { get; set; }

        [XmlElement("source")]
        public string aSource { get; set; }
    }    
}
