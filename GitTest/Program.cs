class Test
{
    public static void Main()
    {
        int a = 3;
        Console.WriteLine("meth" + a);
        string s = Console.ReadLine();
        Test t = new Test();
        t.Prin(33);
    }
    public void Prin(int a)
    {
        int p = a + 40;
        Console.WriteLine(p);
    }
}