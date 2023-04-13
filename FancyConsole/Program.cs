namespace FancyConsole
{
    internal class Program
    {

        static FancyConsole FC;
        static void Main(string[] args)
        {
            //Instantiate FancyConsole
            FC = new FancyConsole("Boolean - Exercise", 75, 20);

            FC.Header("Exercise 1");
            FC.SubHeader("by Francesco Limpias");

            /*
            FC.Paragraph("Questo è un test 2 + 2 = " + 2 + 2);

            FC.Options(
                    new Option(Key.R, () => ),
                    new Option(Key.Q, () => ),
                    FancyConsole.ExitOption
                );
            */
        }
    }
}