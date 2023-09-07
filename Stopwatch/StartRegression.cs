namespace Stopwatch
{
    class startRegression
    {
        public static void startregression(int time)
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
            Menu.menu();
        }
    }
}

