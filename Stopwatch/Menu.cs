namespace Stopwatch
{
    class Menu
    {
        public static void menu()
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("S = Segundos => 10s = 10 Segundos");
            Console.WriteLine("M = Minutos => 10m = 10 Minutos");
            Console.WriteLine("0 = Para sair do programa");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Quanto tempo deseja contar?");
            Console.WriteLine("--------------------------------------------");

            string data = Console.ReadLine().ToLower();
            
            Console.WriteLine($"Vc digitou {data}. Deseja executar de forma regressiva? S/N");

            char regression = char.Parse(Console.ReadLine().ToLower());

            char type =  char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if(type == 'm')
                multiplier = 60;

            if(time == 0)
                Environment.Exit(0);
            
            preStart.prestart(time * multiplier, regression);
        }
    }
}