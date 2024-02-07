

class Program
{
    static void Main()
    {
        //Länkad lista.
        HomeBrew.List<string> list = new();
        list.Add("Hej");
        list.Add("Vad");
        list.Add("Heter");
        list.Add("Du");
        list.PrintAll();
        list.RemoveFirst();
        list.PrintAll();
        list.RemoveFirst();
        list.RemoveFirst();
        Console.WriteLine(list.Find("Du"));
    }
}