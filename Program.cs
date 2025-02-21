using DemoDelegate_AnonymousFunction;

internal class Program
{
    private static void Main(string[] args)
    {
        //DemoDelegate.DemoBasicDelegate();
        //DemoDelegate.DemoMulticast();
        DemoUsingComparison demo = new DemoUsingComparison();
        demo.InitData();
        demo.Sort();
        demo.Display();
    }
}