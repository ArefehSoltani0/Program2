using System;

class Program
{
    // متد بازگشتی: current = عدد جاری، limit = N (حد بالا)
    static void PrintMultiplesOfThree(int current, int limit)
    {
        // پایهٔ بازگشت: وقتی به limit رسیدیم، متوقف شو
        if (current >= limit)
            return;

        // اگر current مضرب ۳ بود، چاپ کن
        if (current % 3 == 0)
        {
            Console.Write(current + " ");
        }

        // فراخوانی بازگشتی برای عدد بعدی
        PrintMultiplesOfThree(current + 1, limit);
    }

    static void Main()
    {
        Console.Write("لطفاً عدد N را وارد کنید: ");
        if (int.TryParse(Console.ReadLine(), out int N))
        {
            if (N <= 0)
            {
                Console.WriteLine("N باید یک عدد صحیح مثبت باشد.");
                return;
            }

            Console.Write($"اعداد مضرب ۳ کوچک‌تر از {N}: ");
            PrintMultiplesOfThree(1, N); // شروع از ۱ تا N‑1
            Console.WriteLine(); // پایان خط
        }
        else
        {
            Console.WriteLine("ورودی نامعتبر است. لطفاً یک عدد صحیح وارد کنید.");
        }
    }
}