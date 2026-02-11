// CEIS209 Course Project
// Module 2
// Selection and Repetition Control Structures
// Topics: If Blocks, Loops, Validating Input
#nullable disable
#pragma warning disable
// Define constants
const string userName = "Christopher Cummings"; // Replace with your name
const string userSession = "July 2025"; // Replace with the session month and year

// TODO: Declare and Initialize Variables
string loanPurpose = "";
decimal loanAmount = -1;
decimal loanInterestRate = -1;
decimal loanTerm = -1;
decimal loanPayment = -1;
decimal loanMonthlyInterestRate = -1;
decimal loanNumberOfPayments = -1;
decimal balance = -1;
decimal interestPayment = -1;
decimal principalPayment = -1;

//Clear Screen
Console.Clear();

// TODO: Get Loan Information
Console.WriteLine("Loan Information ---");
Console.Write("Please enter the purpose of the loan: ");
loanPurpose = Console.ReadLine();

while (loanAmount < 0 || loanAmount > 250000)
{
    Console.Write("Please enter the loan amount: ");
    loanAmount = Convert.ToDecimal(Console.ReadLine());

    if (loanAmount < 0 || loanAmount > 250000)
    {
        Console.WriteLine("Invalid input. Please enter a value greater than zero and less than or equal to 250,000.");
    }
}

while (loanInterestRate < 0 || loanInterestRate > 25)
{
    Console.Write("Please enter the interest rate: ");
    loanInterestRate = Convert.ToDecimal(Console.ReadLine());

    if (loanInterestRate < 0 || loanInterestRate > 25)
    {
        Console.WriteLine("Invalid input. Please enter a value greater than zero and less than 25.");
    }
}

while (loanTerm < 0 || loanTerm > 30)
{
    Console.Write("Please enter the loan term in years: ");
    loanTerm = Convert.ToDecimal(Console.ReadLine());

    if (loanTerm < 0 || loanTerm > 30)
    {
        Console.WriteLine("Invalid input. Please enter a value greater than zero and less than 30.");
    }
}




// Calculate Monthly Payment
loanMonthlyInterestRate = loanInterestRate / 1200;
loanNumberOfPayments = loanTerm * 12;
loanPayment = loanAmount * (loanMonthlyInterestRate * (decimal)Math.Pow((double)(1 + loanMonthlyInterestRate), (double)loanNumberOfPayments)) / ((decimal)Math.Pow((double)(1 + loanMonthlyInterestRate), (double)loanNumberOfPayments) - 1);

// Display Amortization Schedule - Headers written for you
Console.WriteLine();
Console.WriteLine("Amortization Schedule ---");
Console.WriteLine($"{"Payment #",10}\t{"Payment",15}\t{"Interest",15}\t{"Principal",15}\t{"Balance",15}");
Console.WriteLine($"{"=========",10}\t{"=========",15}\t{"========",15}\t{"=========",15}\t{"==========",15}");

//TODO: Write Amortization schedule below
balance = loanAmount;

for (int i = 1; i <= loanNumberOfPayments; i++)
{
    interestPayment = balance * loanMonthlyInterestRate;
    principalPayment = loanPayment - interestPayment;
    balance -= principalPayment;
    Console.WriteLine($"{i,10}\t{loanPayment,15:C}\t{interestPayment,15:C}\t{principalPayment,15:C}\t {balance,15:C}");
}