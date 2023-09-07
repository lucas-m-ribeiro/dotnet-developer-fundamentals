namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
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
                System.Environment.Exit(0);
            
            preStart(time * multiplier, regression);
        }
        public static void preStart(int time, char regression)
        {
            Console.Clear();
            
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);

            Console.WriteLine("Set...");
            Thread.Sleep(1000);

            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            if(regression == 's')
                startRegression(time);
            Start(time);
        }
        public static void Start(int time)
        {   
            int currentTime = 0;

            while(currentTime != time)
            {   
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    
        public static void startRegression(int time)
        {
            int currentTime = 0;

            for(int i = time; i != currentTime; i--)
            {
                Console.Clear();
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine(currentTime);
            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2500);
            Menu();
        }
    }
}