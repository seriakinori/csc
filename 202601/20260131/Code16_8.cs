public class Code16_8{
    public static void Run(){
        var n = DoSomething([1,2,3,6,7,8,9]);
        Console.WriteLine(n);

        var s = DoSomething(["aaaa","bbbb"]);
        Console.WriteLine(s ?? "<null>");
    }

    static T? DoSomething<T>(IList<T> list) where T : notnull {
        for(int i=0; i < list.Count - 1; i++)
            if(list[i].Equal(list[i + 1])){
                return list[i];
            }
        return default;
    }
}