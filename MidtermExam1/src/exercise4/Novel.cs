using MidtermExam1.exercise2;

namespace MidtermExam1.exercise4;

public class Novel : Document
{
    public bool IsBestSelling { get; set; }
    public int NumberOfCopies { get; set; }

    public Novel(int id, string name, List<string> author, bool isBestSelling, int numberOfCopies)
        : base(id, name, author, "Van hoc", "Novel")
    {
        this.IsBestSelling = isBestSelling;
        this.NumberOfCopies = numberOfCopies;
    }

    public override void PrintDocumentInfo()
    {
        base.PrintDocumentInfo();
        Console.WriteLine($"Best Selling: {IsBestSelling}, Copies Sold: {NumberOfCopies}");
    }
}