namespace Ввод_массива_с_клавиатуры
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int elementsCount = int.Parse(Console.ReadLine());

            int[] AyazkinArray = new int[elementsCount];

            for (int i = 0; i < elementsCount; i++)
            {
                Console.Write($"Введите {i + 1} элемент массива: ");
                AyazkinArray[i] = int.Parse(Console.ReadLine()); 
            }


            Console.Write("Ваш массив: ");
            for(int i = 0; i < AyazkinArray.Length; i++)
            {       
            Console.Write(AyazkinArray[i] + " ");
            }
        }
    }
}