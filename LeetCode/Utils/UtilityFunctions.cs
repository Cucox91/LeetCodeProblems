namespace LeetCode;

public class Utils
{
    public static void PrintCollection<T>(IEnumerable<T> collection)
    {
        foreach (var item in collection)
        {
            var result = item != null ? item.ToString() : "";
            Console.Write($"{result}, ");
        }
        Console.WriteLine();
    }
}