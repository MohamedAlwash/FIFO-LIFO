public static class Program
{

    private static List<int> array = new List<int>() { 22, 1, 58, 33 };

    public static void Add(int number) {
        array.Add(number);
    }

    public static void Remove() {
        array.RemoveAt(0);
    }

    public static void Loop() {
        array.ForEach(n => Console.Write(n));
    }
}