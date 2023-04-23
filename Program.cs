void ReassembleTheArray()
{
    // Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
    // длина которых меньше, либо равна 3 символам.
    // Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
    // При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
    string[] array = { "c#", "Mil", "consider", "IO", "max", "OMEGA", "dd", "reveal", "Gain", "Get" };
    string[] ReassembleArray(string[] arr1)
    {
        int counter = 0;
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i].Length <= 3)
            {
                arr1[counter] = arr1[i];
                counter++;
            }
        }
        string[] arr2 = new string[counter];
        for (int a = 0; a < counter; a++)
        {
            arr2[a] = arr1[a];
        }
        return arr2;
    }
    void PrintStringArray(string[] array1)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            Console.Write(array1[i] + " ");
        }
        Console.WriteLine();
    }
    PrintStringArray(ReassembleArray(array));
}
ReassembleTheArray();
