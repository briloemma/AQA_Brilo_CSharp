using System.Text;

namespace AQA_Brilo_CSharp
{
    public class Algorithm
    {
        public static void Hello()
        {
            Console.WriteLine("Введите целое число:");
            double num;
            bool isFormatCorrect;
            do
            {
                isFormatCorrect = double.TryParse(Console.ReadLine(), out num);
                if (!isFormatCorrect)
                {
                    Console.WriteLine("Неверный формат введённого значения. Введите ещё раз.");
                }
            }
            while (!isFormatCorrect);
            Console.WriteLine();
            if (num > 7)
                Console.WriteLine("Привет");
            Console.WriteLine();
        }

        public static void HelloPerson()
        {
            Console.WriteLine("Введите Ваше имя:");
            Console.InputEncoding = Encoding.Unicode;
            var name = Console.ReadLine();
            Console.WriteLine();
            if (name?.ToLower().Equals("вячеслав") ?? false)
                Console.WriteLine("Привет, Вячеслав");
            else
                Console.WriteLine("Нет такого имени");
            Console.WriteLine();
        }

        public static void ArrayNums()
        {
            Console.WriteLine("Задайте размер массива:");
            int numLength;
            try
            {
                numLength = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                throw new Exception("Введён неверный формат.");
            }
            Console.WriteLine();
            double[] nums = new double[numLength];
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Введите значение {i} элемента массива:");
                double newNum;
                try
                {
                    newNum = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    throw new Exception("Введён неверный формат.");
                }
                nums[i] = newNum;
                Console.WriteLine();
            }
            Console.WriteLine("Ниже представлены элементы массива, кратные 3:");
            foreach (double num in nums)
            {
                if (num % 3 == 0)
                    Console.Write(num + " ");
            }
            Console.ReadLine();
        }
    }
}
