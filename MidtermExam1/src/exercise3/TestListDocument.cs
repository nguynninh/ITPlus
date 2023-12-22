using MidtermExam1.exercise2;

namespace MidtermExam1.exercise3;

/** Bai 3
 * Tạo một List<Document> gồm 10 Document (là class ở bài 2).
 * In ra danh sách các Document từ hàm PrintDocumentInfo.
 * Tìm Document có nhiều tác giả tham gia nhất và in ra
 * (nếu như có nhiều Document cùng có nhiều tác giả tham gia thì in các Document đó)
 */
public class TestListDocument
{
    public static void TestRun()
    {
        List<Document> documentList = new List<Document>
        {
            new Document(1, "Lich su phong kien", new List<string> { "Nguyen Van An" }, "Lich Su", "MS_Powerpoint"),
            new Document(2, "Toan cao cap", new List<string> { "Le Van Luong", "Nguyen Van An" }, "Toan hoc", "Latex"),
            new Document(3, "Dao dông co", new List<string> { "Le Van Luong", "Tran Thi Tac Gia", "Ngo Van Tung" },
                "Vat ly", "Latex"),
            new Document(4, "Dia ly Viet Nam", new List<string> { "Tran Thi Tac Gia", "Ngo Van Tung" }, "Dia ly",
                "MS_Word"),
            new Document(5, "Van hoc hien dai",
                new List<string> { "Ngo Tat To", "Nguyen Minh Tu", "Nguyen Thi Van Anh" }, "Van hoc", "MS_Word"),
            new Document(6, "Dia ly the gioi", new List<string> { "Ngo Nhu Vui", "Nguyen Van Dat", "Tran Khanh Du" },
                "Dia ly", "MS_Word"),
            new Document(7, "Hoi hoa", new List<string> { "Ngo Nhu Vui", "Nguyen Thi Van Anh" }, "My thuat",
                "MS_Powerpoint"),
            new Document(8, "Giao huong", new List<string> { "Tran Thi Tac Gia", "Nguyen Van Dat" }, "Am nhac",
                "MS_Word"),
            new Document(9, "The gioi hien dại", new List<string> { "Nguyen Van Dat" }, "Van hoc", "MS_Powerpoint"),
            new Document(10, "Dai so tuyen tinh", new List<string> { "Ngo Tat To", "Nguyen Minh Tu" }, "Toan hoc",
                "Latex"),
        };

        foreach (var document in documentList)
        {
            document.PrintDocumentInfo();
        }

        FindAndPrintDocumentsWithMostAuthors(documentList);
    }

    static void FindAndPrintDocumentsWithMostAuthors(List<Document> documents)
    {
        int maxAuthorsCount = 0;

        foreach (var document in documents)
        {
            maxAuthorsCount = Math.Max(maxAuthorsCount, document.Author.Count);
        }

        Console.WriteLine("\nTai lieu co nhieu tac gia nhat:");
        foreach (var document in documents)
        {
            if (document.Author.Count == maxAuthorsCount)
            {
                document.PrintDocumentInfo();
            }
        }
    }
}