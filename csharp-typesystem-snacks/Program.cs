using System.Security.Cryptography.X509Certificates;

snack4();

void snack1()
{
    Console.WriteLine("Inserisci il primo numero: ");

    int num1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Inserisci il secondo numero: ");

    int num2 = Convert.ToInt32(Console.ReadLine());

    var max = num1 > num2 ? num1 : num2;

    var message = $"il maggiore è {max}";

    Console.WriteLine(message);
}

void snack2()
{
    Console.WriteLine("inserisci la prima parola: ");
    string wrd1 = Console.ReadLine() ?? "";
    Console.WriteLine("inserisci la seconda parola: ");
    string wrd2 = Console.ReadLine() ?? "";
    if (wrd1.Length >= wrd2.Length)
    {
        Console.WriteLine(wrd2 + "; " + wrd1);
    }
    else
    {
        Console.WriteLine(wrd1 + "; " + wrd2);
    }
}

void snack3()
{
    var number = 0;
    Console.WriteLine("dammi 10 numeri: ");
    for (var i = 0; i < 10; i++)
    {
        number = number + Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine($"la somma dei numeri è {number}");
}

void snack4()
{
    var sum = 0;
    var media = 0;
    var quantity = 0;

    for (int i = 2; i <= 10; i++)
    {
        quantity++;
        sum += i;
        media = sum / quantity;
    }
    Console.WriteLine($"La somma dei numeri da 2 a 10 è {sum}");
    Console.WriteLine($"La media dei numeri da 2 a 10 è {media}");
}

void snack5()
{
    Console.WriteLine("Inserisci un numero: ");
    var num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num % 2 == 0 ? num : num + 1);
}

void snack6()
{
    string[] invitati = { "Giorgio", "Franco", "Marco", "Luigi", "Francesco" };
    Console.WriteLine("FESTA DEL GRANDE GATSBY!");
    Console.WriteLine("dimmi il tuo nome: ");
    var name = Console.ReadLine();

    var message = (Array.IndexOf(invitati, name) != -1 ? "Prego entra pure" : "Mi spiace non sei in lista");

    Console.WriteLine(message);
}

void snack7()
{
    int[] evenNums = new int[6];
    Console.Write("Inserisci sei numeri: ");

    for (var i = 0; i < 6; i++)
    {
        int num = Convert.ToInt32(Console.ReadLine());
        if (num % 2 != 0)
        {
            evenNums[i] = num;
        }
        else
        {
            evenNums[i] = 0;
        }
    }
    foreach (int num in evenNums)
    {
        Console.WriteLine(num);
    }
}

void snack8()
{
    int[] nums = { 2, 4, 5, 8, 3, 24, 56, 345, 32, 46, 75, 23, 654, 12, 45 };
    int[] sum = new int[nums.Length];
    for (var i = 0; i < nums.Length; i++)
    {
        if (nums[i] % 2 != 0)
        {
            sum[i] = nums[i];
        }
    }
    Console.WriteLine("la somma dei numeri in posizione dispari è: " + sum.Sum());
}

void snack9()
{
    int[] nums = new int[50];
    var count = 0;
    while (nums.Sum() < 50)
    {
        Console.WriteLine("dammi un numero:");
        var num = Convert.ToInt32(Console.ReadLine());
        nums[count] = num;
        count++;
    }
    Console.WriteLine("La somma dei numeri che hai inserito è maggiore di 50. ecco i tuoi numeri: ");
    foreach (var item in nums)
    {
        Console.WriteLine(item != 0 ? item : "");
    }
}

void snack10()
{
    Console.WriteLine("Quanti array di numeri casuali vuoi creare?");
    var N = Convert.ToInt32(Console.ReadLine());
    for (var i = 0; i < N; i++)
    {
        int[] arrNums = new int[10];
        for (var j = 0; j < 10; j++)
        {
            var random = new Random();
            var num = random.Next(1, 100);
            arrNums[j] = num;
        }
        foreach (var item in arrNums)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine();
    }
}

void snack11()
{
    Console.WriteLine("inserisci la prima parola: ");
    var wrd1 = Console.ReadLine();
    Console.WriteLine("inserisci la seconda parola: ");
    var wrd2 = Console.ReadLine();

    if (areEquals(wrd1, wrd2))
    {
        Console.WriteLine($"{wrd1}; {wrd2}");
    }
    else
    {
        Console.WriteLine(wrd1.Length > wrd2.Length ? wrd1 : wrd2);
    }

    static bool areEquals(string a, string b)
    {
        if (a.Length == b.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

void snack12()
{
    Console.WriteLine("dammi un numero:");
    var num = Convert.ToInt32(Console.ReadLine());
    if (isOdd(num))
    {
        Console.WriteLine("il numero è pari");
    }
    else
    {
        Console.WriteLine("il numero è dispari");
    }

    static bool isOdd(int num)
    {
        if (num % 2 != 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}