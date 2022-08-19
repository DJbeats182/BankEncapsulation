

using BankEncaspulation;

BankAccount djsAccount = new BankAccount();

Console.WriteLine("Welcome to your Bank Account!\n");
Console.WriteLine("Please enter your PIN to get started:");
bool isAuthenticated;

do
{
    bool isNumber = int.TryParse(Console.ReadLine(), out int pin);
    isAuthenticated = BankAccount.PinVerification(isNumber, pin);

    if (isAuthenticated)
    {
        Console.WriteLine("Welcome to your account!\n");
        Console.WriteLine($"Your current Balance is: {djsAccount.GetBalance()}\n");
    }
    else
    {
        Console.WriteLine("Sorry that PIN is incorrect\n");
        Console.WriteLine("Please Try Again!");
    }
} while (!isAuthenticated);


Console.WriteLine("Enter in an amount to deposit:");
double depositAmount = double.Parse(Console.ReadLine());
BankAccount.DepositBalance(depositAmount);
Console.WriteLine($"Your new balance is: {djsAccount.GetBalance()}");


//string pass = "";
//Console.WriteLine("Please enter your PIN to get started:");
//bool isNumber = int.TryParse(Console.ReadLine(),out int pin);
//ConsoleKeyInfo key;

//do
//{
//    key = Console.ReadKey(true);

//    // Backspace Should Not Work
//    if (key.Key != ConsoleKey.Backspace)
//    {
//        pass += key.KeyChar;
//        Console.Write("*");
//    }
//    else
//    {
//        Console.Write("\b");
//    }
//}
//// Stops Receving Keys Once Enter is Pressed
//while (key.Key != ConsoleKey.Enter);

