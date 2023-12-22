namespace MidtermExam1.exercise2;

/** Bài 2
 * Tạo một class Document chứa các thông tin: ID (int), tên (string), tên tác giả (List<string),
 * nhóm nội dung (string), loại document; với ID và name là read only.
 * Class cần phải có 1 constructor chứa tham số để khởi tạo cho các trường tương ứng.
 * Tạo hàm PrintDocumentInfo in ra theo định dạng: ID - tên - nhóm nội dung - tên các tác giả.
 * Ghi chú: nhóm nội dung bao gồm: Lịch sử, Địa lý, Toán học, Vật lý, Hóa học, Văn học, Mỹ thuật,  am nhạc.
 */
public class Document
{
    private readonly int id;
    private readonly string name;
    public List<string> Author { get; set; }
    public string ContentGroup { get; set; }
    public string DocumentType { get; set; }

    public Document(int id, string name, List<string> author, string contentGroup, string documentType)
    {
        this.id = id;
        this.name = name;
        this.Author = author;
        this.ContentGroup = contentGroup;
        this.DocumentType = documentType;
    }

    public virtual void PrintDocumentInfo()
    {
        Console.WriteLine($"{id} - {name} - {ContentGroup} - {string.Join(", ", Author)}");
    }
}