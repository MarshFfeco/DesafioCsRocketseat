using System.Globalization;

namespace DesafioRocketseat.Respota;

public class Challenger
{
    public void ResponseOne()
    {
        bool canContinue = false;
        string? name;

        do
        {
            Console.Write("Digite seu nome: ");
            name = Console.ReadLine();


            if (string.IsNullOrEmpty(name))
            {
                GenerateError("Você precisa digitar seu nome!");
            }
            else
                canContinue = true;
        } while (!canContinue);

        Console.Clear();
        Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
    }

    public void ResponseTwo()
    {
        bool canCompleteF = false, canCompleteL = false;
        string? firstName, lastName;

        do
        {
            Console.Write("Digite seu primeiro nome: ");
            firstName = Console.ReadLine();

            if (string.IsNullOrEmpty(firstName))
            {
                GenerateError("Você precisa digitar seu Primeiro Nome!");
                continue;
            }

            canCompleteF = true;
        } while (!canCompleteF);

        do
        {
            Console.Write($"Digite seu sobrenome {firstName}: ");
            lastName = Console.ReadLine();

            if (string.IsNullOrEmpty(lastName))
            {
                GenerateError("Você precisa digitar seu Sobrenome!");
                continue;
            }

            canCompleteL = true;
        } while (!canCompleteL);

        Console.Clear();
        Console.WriteLine($"Olá, {firstName} {lastName}! Seja muito bem-vindo!");
    }

    public void ResponseThree()
    {
        bool canCompleteX = false, canCompleteY = false;
        double x = 0, y = 0;

        do
        {
            Console.Write("Digite o número X: ");
            string? valueX = Console.ReadLine();

            if (string.IsNullOrEmpty(valueX))
            {
                GenerateError("Você precisa digitar um número!");
                continue;
            }

            try
            {
                x = double.Parse(valueX);
                canCompleteX = true;
            }
            catch
            {
                GenerateError("Você precisa digitar um número!");
            }
        } while (!canCompleteX);

        do
        {
            Console.Write($"Digite o número Y: ");
            string? valueY = Console.ReadLine();

            if (string.IsNullOrEmpty(valueY))
            {
                GenerateError("Você precisa digitar um número!");
                continue;
            }

            try
            {
                y = double.Parse(valueY);
                canCompleteY = true;
            }
            catch
            {
                GenerateError("Você precisa digitar um número!");
            }
        } while (!canCompleteY);

        double soma = x + y;
        double sub = x - y;
        double mult = x * y;
        double med = (x + y) / 2;

        Console.Clear();
        Console.WriteLine($"Soma: {soma}");
        Console.WriteLine($"Subtração: {sub}");
        Console.WriteLine($"Multiplicação: {mult}");
        if (!(y == 0.0 || y == 0))
        {
            Console.WriteLine($"divisão: {x / y}");
        }
        else
        {
            Console.WriteLine($"divisão: Divisão por zero!");
        }

        Console.WriteLine($"Média: {med}");
    }

    public void ResponseFour()
    {
        bool canComplete = false;
        string? palavra;

        do
        {
            Console.Write("Digite uma palavra ou frase: ");
            palavra = Console.ReadLine();

            if (string.IsNullOrEmpty(palavra))
                GenerateError("Você uma palavra ou frase!");
            else
                canComplete = true;
        } while (!canComplete);

        string pre = palavra.Replace(" ", "");

        Console.WriteLine($"Sua palavra ou frase tem {pre.Length} caracteres");
    }

    public void ResponseFive()
    {
        bool canContinue = false;
        string resp = "Falso";

        do
        {
            Console.Write("Digite a placa do veículo: ");
            string? placa = Console.ReadLine();

            if (string.IsNullOrEmpty(placa))
            {
                GenerateError("Você precisa digital a placa do veívulo!");
                continue;
            }

            if (placa.Length != 7)
            {
                GenerateError("Digite uma placa válida");
                continue;
            }

            string numeros = $"{placa[3]}{placa[4]}{placa[5]}{placa[6]}";

            bool letra = char.IsLetter(placa[0]) && char.IsLetter(placa[1]) && char.IsLetter(placa[2]);
            bool numero = int.TryParse(numeros, out _);

            if (letra && numero)
            {
                resp = "Verdadeiro";
            }

            canContinue = true;
        } while (!canContinue);

        Console.WriteLine(resp);
    }

    public void ResponseSix()
    {
        byte option = 0;

        do
        {
            Console.WriteLine("+ ------------------------------------ +");
            Console.WriteLine("1. Formato completo.");
            Console.WriteLine("2. Apenas a data.");
            Console.WriteLine("3. Apenas a hora.");
            Console.WriteLine("4. A data com o mês por extenso.");
            Console.WriteLine("+ ------------------------------------ +");

            Console.Write("\n\nEscolha uma opção: ");
            string? selected = Console.ReadLine();

            if (string.IsNullOrEmpty(selected))
            {
                GenerateError("Escolha uma das opções: 1 até 4");
            }
            else
                option = byte.Parse(selected);
        } while (!(option > 0 && option <= 4));

        Console.Clear();
        string patente = "";

        switch (option)
        {
            case 1:
                patente = "dddd d-M-yyyy H:m:s";
                break;
            case 2:
                patente = "dd/MM/yyyy";
                break;
            case 3:
                patente = "HH";
                break;
            case 4:
                patente = "dd MMMM";
                break;
        }

        Console.WriteLine(DateTime.Now.ToString(patente, CultureInfo.CreateSpecificCulture("pt-BR")));
    }
    private void GenerateError(string msg)
    {
        Console.WriteLine(msg);
        Thread.Sleep(1000);
        Console.Clear();
    }
}