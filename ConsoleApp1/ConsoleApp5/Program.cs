class Book
{
    String title;
    decimal isbn13;
    string author;

    public Book(string title) : this (title,0)
    {
    }

    public Book(string title, decimal isbn13): this(title, isbn13, String.Empty) { }

    public Book(string title, decimal isbn13, string author)
    {
        this.title = title;
        this.isbn13 = isbn13;
        this.author = author;
    }

    public Book() : this(string.Empty, 0, string.Empty) 
    {
    }
}