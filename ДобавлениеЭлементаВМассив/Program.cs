namespace ДобавлениеЭлементаВМассив
{
    internal class Program
    {
        static void Resize(ref int[] array, int index, int elem)
        {
            int[] newArray = new int[array.Length + 1];

            newArray[index] = elem;

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            

            for (int q = index; q < array.Length; q++)
            newArray[q + 1] = array[q];

            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 5, 1, 2 };

            Resize(ref myArray, 4, -3);

            foreach (int e in myArray) Console.WriteLine(e);
            
        }        
    }
}
