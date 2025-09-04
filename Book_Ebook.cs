class Book
{
    public string Title, author;
}
class EBook : Book
{
    public double Filesize;
    public string Format;
    public void Show()
    {
        Console.WriteLine(Title + "by" + author + ",size" + Filesize + "MB, format:" + Format);
    }
}
