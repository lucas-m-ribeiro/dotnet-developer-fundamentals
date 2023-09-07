namespace Stopwatch
{
    class preStart
    {
        public static void prestart(int time, char regression)
        {
            Console.Clear();
            
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);

            Console.WriteLine("Set...");
            Thread.Sleep(1000);

            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            if(regression == 's')
                startRegression.startregression(time);
            Start.start(time);
        }
    }
}