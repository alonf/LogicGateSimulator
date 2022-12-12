namespace LogicGateSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("And Truth Table:");
            var and = new And(2);
            var sw1 = new Switch();
            var sw2 = new Switch();
            and.SetInputComponentAt(0, sw1);
            and.SetInputComponentAt(1, sw2);

            Console.WriteLine("a | b | y");
            Console.WriteLine("__+___+__");
            for (int a = 0; a <= 1; ++a)
            {
                for (int b = 0; b <= 1; ++b)
                {
                    Console.WriteLine($"{a} | {b} | {and.TheOutput}");
                    sw2.Toggle();
                }
                sw1.Toggle();
            }
        }
    }
}