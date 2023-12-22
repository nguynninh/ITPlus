namespace MidtermExam1.exercise2;

public class TestDocument
{
    public static void TestRun()
    {
        TestObjectDocument(1,
            "Khoa hoc chung",
            "Toan hoc, Vat ly,  Lich su",
            "MS_Word", 
            "Nguyen Van A", "Nguyen Van B");
        
        TestObjectDocument(2,
            "Khoa hoc tu nhien",
            "Toan hoc, Vat ly, Hoa hoc",
            "MS_Word", 
            "Nguyen Van C", "Nguyen Van D");
        
        TestObjectDocument(3,
            "Khoa hoc nghe thuat",
            " Van hoc, My thuat,  am nhac",
            "Latex", 
            "Nguyen Van A", "Nguyen Van D");
        
        TestObjectDocument(4,
            "Khoa hoc xa hoi",
            "Lich su, Dia ly, Toan hoc",
            "MS_Powerpoint", 
            "Nguyen Van A", "Nguyen Van D");
    }

    private static void TestObjectDocument(
        int id,
        string name,
        string contentGroup,
        string documentType,
        params string[] author)
    {
        Document document = new Document(id, name, new List<string>(author), contentGroup, documentType);
        document.PrintDocumentInfo();
    }
}