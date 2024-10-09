#region 1.Min methodu yaradılır. Daxil olunan arrayın ən kiçik elementini tapır.






// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         int n;
//         Console.WriteLine("Arrayin uzunlugunu daxil edin: ");
//         n = Convert.ToInt32(Console.ReadLine());

//         int[] arr = new int[n];
//         Console.WriteLine("Arrayin elementlerini daxil edin: ");

//         for (int i = 0; i < n; i++)
//         {
//             arr[i] = Convert.ToInt32(Console.ReadLine());
//         }

//         bubbleSort(arr);

//         Console.WriteLine("Siralanmis array:");
//         foreach (int num in arr)
//         {
//             Console.Write(num + " ");
//         }
//         Console.WriteLine();

//         Console.WriteLine("Axtarilan elementi daxil edin: ");

//         int target = Convert.ToInt32(Console.ReadLine());
//         int index = BinarySearch(arr, target);

//         if (index != -1)
//         {
//             Console.WriteLine($"{target} ededi {index} nomreli indexdedir");
//         }
//         else
//         {
//             Console.WriteLine($"{target} ededi array-da yoxdur");
//         }
//     }

//     static void bubbleSort(int[] arr)
//     {
//         int n = arr.Length;
//         for (int i = 0; i < n - 1; i++)
//         {
//             for (int j = 0; j < n - i - 1; j++)
//             {
//                 if (arr[j] > arr[j + 1])
//                 {
//                     int temp = arr[j];
//                     arr[j] = arr[j + 1];
//                     arr[j + 1] = temp;
//                 }
//             }
//         }
//     }

//     static int BinarySearch(int[] arr, int target)
//     {
//         int left = 0;
//         int right = arr.Length - 1;

//         while (left <= right)
//         {
//             int mid = left + (right - left) / 2;

//             if (arr[mid] == target)
//             {
//                 return mid;
//             }
//             else if (arr[mid] > target)
//             {
//                 right = mid - 1;
//             }
//             else
//             {
//                 left = mid + 1;
//             }
//         }
//         return -1;
//     }
// }


#endregion



#region 2.İstənilən verilən cümlədə sözlərin baş hərflərini ekrana yazdıran method yazın  məs .("Hello World --> "H" "W" )
using System;

using System.Text.RegularExpressions; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cumleni daxil edin: ");
        string sentence = Console.ReadLine();

        PrintFirstLetters(sentence);
    }

    static void PrintFirstLetters(string sentence)
    {
        Regex regex = new Regex(@"\b\w");

        MatchCollection matches = regex.Matches(sentence);

        Console.WriteLine("Sozlerin baa herfleri:");
        foreach (Match match in matches)
        {
            Console.Write(match.Value + " ");
        }
        Console.WriteLine(); 
    }
}


#endregion


#region .Parametr olaraq 1 string dəyər qəbul edən və həmin string dəyəri icində bosluqlar qalmayacaq hala gətirən metod.Misal olaraq, name = " Yusif    Osmanov   " deyə bir variable-mız varsa onu yaratdigimiz metoda göndərdikdə variable-daki dəyər "YusifOsmanov" olmalıdır.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cumleni daxil edin: ");
        string sentence = Console.ReadLine();
        DeleteSpace(sentence);
    }

    static void DeleteSpace(string sentence)
    {
        string result = ""; 

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] != ' ')
            {
                result += sentence[i];
            }
        }

        Console.WriteLine(result);
    }
}

#endregion
