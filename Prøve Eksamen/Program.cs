namespace Prøve_Eksamen
{
    internal class Program
    {
        static void Main()
        {
            int answer=0;

            Console.WriteLine("Indtast et tal fra og med 1 til og med 500");

            try
            {
                answer = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Main();
            }
            if (answer >= 1 && answer <= 500)
            {
                Console.WriteLine(answer);
            }
            else if (answer ==-1)
            {
                Environment.Exit(answer);
            }
            else
            {
                Main();
            }


        }
    }
}
