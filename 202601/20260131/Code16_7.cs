public class Code16_7{
    public static void Run(){
        PrintList([1,234,5,6,8]);
        PrintList<string>(["aaaa","bbbb","cccc","dddd"]);
    }

    static void PrintList<T>(IEnumerable<T> list){
        foreach(var n in list){
            Console.WriteLine(n);
        }
    }
}