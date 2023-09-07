namespace Calculator
{
    class Multiplicacao
    {
        public static void multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            float resultado = v1*v2;

            Console.WriteLine("resultado é: " +  resultado);
            Console.ReadKey();
        }
    }
}