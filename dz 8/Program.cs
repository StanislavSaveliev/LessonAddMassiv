namespace dz_8
{
    internal class Program
    {
        static void Resize(ref int[] array, int index)
        {
            int[] newArray = new int[array.Length - 1];           
            
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i == index) continue;
                newArray[j++] = array[i];
            }                

            array = newArray;
        }

        static void Start(ref int[] array)
        {
            Resize(ref array, 0);
        }

        static void Last(ref int[] array) 
        {
            Resize(ref array, array.Length -1);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 5, 1, 2 };

            Last(ref myArray);

            foreach (int e in myArray) Console.WriteLine(e);
        }
    }
}
