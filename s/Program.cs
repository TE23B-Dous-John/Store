int usernameMoney = 1000;

while (usernameMoney > 0)
{
    Console.WriteLine($" You have {usernameMoney} money left");

    Console.WriteLine("What do you want to buy?");
    Console.WriteLine("1. ");
    Console.WriteLine("2.  ");
    Console.WriteLine("3. ");
    Console.WriteLine("4. ");

    string yourChoise = "";
    while (yourChoise != "1" && yourChoise != "2" && yourChoise != "3" && yourChoise != "4") ;
    {
        yourChoise = Console.ReadLine();
    }

    int priceItem = 0;
    if (yourChoise == "1")
    {
        priceItem = 100;
    }
    else if (yourChoise == "2")
    {
        priceItem = 200;
    }
    else if (yourChoise == "3")
    {
        priceItem = 300;
    }
    else if (yourChoise == "4")
    {
        priceItem = 400;
    }

    Console.WriteLine(" how many do you want to buy");
    int numbersBuy = 0;

    while (numbersBuy == 0)
    {
        string number = Console.ReadLine();
        bool success = int.TryParse(number, out numbersBuy);
        if (success = false)

        
    }






    }


// int ageNum = 0;
// bool success = false;

// while (success == false)
// {
//     Console.WriteLine(" How old are you ");
//     string age = Console.ReadLine();
//     success = int.TryParse(age, out ageNum);

// if (success == false)
// {
//     Console.WriteLine("your age needs to be in numbers, not letters");
//     age = Console.ReadLine();
//     success = int.TryParse(age, out ageNum);
// }
// }

// if (ageNum < 18)
// {
//     Console.WriteLine("Tyvär är du för ung, Shopen passar inte dig");
// }
// else 
// {
//     Console.WriteLine("okej, välkommen");
// }

// Console.Clear();

// Console.WriteLine("välj mellan 1 ,2 ,3");
// int apa = Console.ReadLine();
// if (apa = 1)
// {
// Console.Clear();
// Console.WriteLine("");
// Console.ReadLine();
// }
// else (apa = 2 )
// {
//     Console.Clear();
//     Console.WriteLine("");
// }





// Console.ReadLine();