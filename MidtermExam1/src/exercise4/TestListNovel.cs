namespace MidtermExam1.exercise4;

/** Bai 4
 * Tạo class Novel là con của Document, có thêm trường (bool) IsBestSelling, (int) NumberOfCopies (số bản bán ra)
 * với constructor của nó thì luôn set nó là dạng nội dung là Văn học.
 * Thay đổi hàm PrintDocumentInfo với việc thêm thông báo riêng cho sách bán chạy (IsBestSelling).
 * Tạo 10 Novel và nhét chúng vào List, in ra PrintDocumentInfo mới và in ra tên các tác giả có số lượng sách bán nhiều nhất
 * (nếu một tác giả có mặt ở trong nhiều quyển thì tính bằng tổng số copies, coi như các tác giả khác nhau thì tên khác nhau)
 */
public class TestListNovel
{
    public static void TestRun()
    {
        List<Novel> novelsList = new List<Novel>
        {
            new Novel(1, "Novel1", new List<string> { "Author1", "Author2" }, true, 1000),
            new Novel(2, "Novel2", new List<string> { "Author3", "Author4" }, false, 500),
            new Novel(3, "Novel3", new List<string> { "Author5", "Author6" }, true, 1200),
            new Novel(4, "Novel4", new List<string> { "Author7", "Author8" }, false, 800),
            new Novel(5, "Novel5", new List<string> { "Author9", "Author10" }, true, 1500),
            new Novel(6, "Novel6", new List<string> { "Author1", "Author2", "Author3" }, false, 600),
            new Novel(7, "Novel7", new List<string> { "Author4", "Author5", "Author6" }, true, 2000),
            new Novel(8, "Novel8", new List<string> { "Author7", "Author8", "Author9" }, false, 700),
            new Novel(9, "Novel9", new List<string> { "Author10", "Author1", "Author2" }, true, 1800),
            new Novel(10, "Novel10", new List<string> { "Author3", "Author4", "Author5" }, false, 900),
        };

        
        foreach (var novel in novelsList)
        {
            novel.PrintDocumentInfo();
        }
        
        PrintTopAuthorsByCopies(novelsList);
    }

    private static void PrintTopAuthorsByCopies(List<Novel> novelsList)
    {
        
    }
}