using System.Text;

namespace AQA_Brilo_CSharp
{
    public class Algorithm
    {
        public static void Hello()
        {
            Console.WriteLine("Введите целое число:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (num > 7)
                Console.WriteLine("Привет");
            Console.WriteLine();
        }

        public static void HelloPerson()
        {
            Console.WriteLine("Введите Ваше имя:");
            Console.InputEncoding = Encoding.Unicode;
            string name = Console.ReadLine();
            Console.WriteLine();
            if (name.Equals("Вячеслав"))
                Console.WriteLine("Привет, Вячеслав");
            else
                Console.WriteLine("Нет такого имени");
            Console.WriteLine();
        }

        public static void ArrayNums()
        {
            Console.WriteLine("Задайте размер массива:");
            int numLength = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int[] nums = new int[numLength];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Введите значение {i} элемента массива:");
                int newNum = int.Parse(Console.ReadLine());
                nums[i] = newNum;
                Console.WriteLine();
            }
            Console.WriteLine("Ниже представлены элементы массива, кратные 3:");
            foreach (int num in nums)
            {
                if (num % 3 == 0)
                    Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
