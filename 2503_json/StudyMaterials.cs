namespace _2503_json
{
    public class StudyMaterials
    {
        public Books Books { get; set; }

        public Lectures Lectures { get; set; }

        public Abstracts Abstracts { get; set; }
    }

    public class Books
    {
        public Book[] BookArray { get; set; }
    }

    public class Lectures
    {
        public Lecture[] LectureArray { get; set; }
    }

    public class Abstracts
    {
        public Abstract[] AbstractArray { get; set; }
    }

    public class Keywords
    {
        public string[] KeywordsArray { get; set; }
    }

    public class Book
    {
        public int bId { get; set; }

        public string bTitle { get; set; }

        public string bAuthor { get; set; }

        public string bSection { get; set; }

        public int bYear { get; set; }

        public int bPages { get; set; }
    }

    public class Lecture
    {
        public int lId { get; set; }

        public string lTitle { get; set; }

        public string lAuthor { get; set; }

        public string lSection { get; set; }

        public int lDuration { get; set; }

        public string lLink { get; set; }

        public string lFormat { get; set; }
    }

    public class Abstract
    {
        public int aId { get; set; }

        public string aTitle { get; set; }

        public string aAuthor { get; set; }

        public string aSection { get; set; }

        public Keywords aKeywords { get; set; }

        public string aSource { get; set; }
    }
}
