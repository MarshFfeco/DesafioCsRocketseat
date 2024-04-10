using DesafioRocketseat.Respota;

namespace DesafioRocketseat;

class Program
{
    static void Main()
    {
        bool canContinue = true;
        byte res;
        Challenger challenger = new Challenger();

        do
        {
            Console.Clear();
            res = Menu();

            Console.Clear();
            switch (res)
            {
                case 1:
                    challenger.ResponseOne();
                    break;
                case 2:
                    challenger.ResponseTwo();
                    break;
                case 3:
                    challenger.ResponseThree();
                    break;
                case 4:
                    challenger.ResponseFour();
                    break;
                case 5:
                    challenger.ResponseFive();
                    break;
                case 6:
                    challenger.ResponseSix();
                    break;
            }

            Console.WriteLine("\n\n+ -------------------------- +");
            Console.WriteLine("Deseja executar outra Resposta?(Deixe em branco caso queira encerrar)");
            string? response = Console.ReadLine();

            if (response == string.Empty)
                canContinue = false;
        } while (canContinue);
    }

    static byte Menu()
    {
        byte option = 0;

        do
        {
            Console.WriteLine("+ -------------------------- +");
            Console.WriteLine("1. Resposta do Exercício 1!");
            Console.WriteLine("2. Resposta do Exercício 2!");
            Console.WriteLine("3. Resposta do Exercício 3!");
            Console.WriteLine("4. Resposta do Exercício 4!");
            Console.WriteLine("5. Resposta do Exercício 5!");
            Console.WriteLine("6. Resposta do Exercício 6!");
            Console.WriteLine("+ -------------------------- +");

            Console.Write("\n\nEscolha uma opção: ");
            string? selected = Console.ReadLine();

            if (string.IsNullOrEmpty(selected))
            {
                GenerateError("Escolha uma das opções: 1 até 6");
                continue;
            }

            try
            {
                option = byte.Parse(selected);
            }
            catch
            {
                Console.WriteLine("Erro");
                GenerateError("Escolha uma das opções: 1 até 6");
                continue;
            }

        } while (!(option > 0 && option <= 6));

        return option;
    }

    private static void GenerateError(string msg)
    {
        Console.WriteLine(msg);
        Thread.Sleep(1000);
        Console.Clear();
    }
}