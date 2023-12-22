namespace MidtermExam2.exercise1;

/** Bai 4
 * Số Fibonacci F(n): F(1) = 1, F(2) = 1, F(n) = F(n-1) + F(n-2) với n > 2.
 * Nhập vào từ bàn phím số X và tìm số n sao cho F(n) > X với n nhỏ nhất có thể.
 */
public class Fibonacci
{
    public static void TestRun()
    {
        int x;
        do
        {
            Console.Write("Nhap so x: ");
        } while (!int.TryParse(Console.ReadLine(), out x));

        int fibo = findFibonacciGreaterThanN(x);
        Console.WriteLine($"F({fibo}) > {x}");
    }

    public static int findFibonacciGreaterThanN(int x)
    {
        long sum1th = 1;
        long sum2th = 1;
        int index = 2;
        while (sum2th <= x)
        {
            index++;
            sum2th += sum1th;
        }
        
        Console.WriteLine(sum2th);
        return index;
    }
}