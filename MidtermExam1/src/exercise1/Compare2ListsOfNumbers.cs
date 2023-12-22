namespace MyApp.exercise1;

/** Bai 1
 * Tạo 2 list số nguyên với số phần tử nhập từ bàn phím, dùng try catch.
 * Nhập các phần tử cho mỗi dãy số từ bàn phím, dùng try catch.
 *  So sánh 2 list đó, bắt đầu bằng việc so sánh số đầu tiên của list 1 với số đầu tiên của list 2,
 * nếu 2 số bằng nhau thì so sánh tiếp số thứ 2,... và in ra kết quả (list nào lớn hơn hay bằng nhau)
 */
public class Compare2ListsOfNumbers
{
    public static void TestRun()
    {
        List<int> list1 = InputList();
        
        List<int> list2 = InputList();
        
        CompareLists(list1, list2);
    }
    
    static void CompareLists(List<int> list1, List<int> list2)
    {
        int minLength = Math.Min(list1.Count, list2.Count);

        for (int i = 0; i < minLength; i++)
        {
            if (list1[i] < list2[i])
            {
                Console.WriteLine("List 2 lon hon List 1.");
                return;
            }
            else if (list1[i] > list2[i])
            {
                Console.WriteLine("List 1 lon hon List 2.");
                return;
            }
        }
        
        if (list1.Count < list2.Count)
        {
            Console.WriteLine("List 1 nho hon List 2.");
        }
        else if (list1.Count > list2.Count)
        {
            Console.WriteLine("List 1 lon hon List 2.");
        }
        else
        {
            Console.WriteLine("Ca hai list bang nhau.");
        }
    }

    static List<int> InputList()
    {
        Console.Write("Nhap so luong phan tu cho list: ");
        int n = Compare2ListsOfNumbers.isNumber();

        List<int> list = new List<int>();

        Console.WriteLine($"Nhap {n} phan tu: ");

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Phan tu {i + 1}: ");
            int element = Compare2ListsOfNumbers.isNumber();

            list.Add(element);
        }

        return list;
    }

    private static int isNumber()
    {
        int n;
        if (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Loi: Nhap khong dung dinh dang so nguyen.");
            Environment.Exit(1);
        }

        return n;
    }
}