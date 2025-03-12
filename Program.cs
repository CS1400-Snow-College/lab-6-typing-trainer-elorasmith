// See https://aka.ms/new-console-template for more information

// Elora Smith, 3/11/25, Lab 6 Typing Trainer

using System.Diagnostics;

Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
string instructions = "Welcome to Typing Trainer! Type the challenge text that appears on the following line, and then press enter.";
Console.WriteLine(instructions);
Console.WriteLine();

string[] phrases = {
    "Our greatest glory is not in never falling, but in rising every time we fall. -Confucius",
    "Never, never and never again shall it be that this beautiful land will again experience the oppression of one by another. -Nelson Mandela",
    "History, despite its wrenching pain, cannot be unlived, but if faced with courage, need not be lived again. -Maya Angelou",
    "A small body of determined spirits fired by an unquenchable faith in their mission can alter the course of history. -Mahatma Gandhi",
    "Posterity! You will never know how much it cost the present generation to preserve your freedom! I hope you will make good use of it. -John Adams"
};

int row = Console.CursorLeft;
int column = Console.CursorTop;
Stopwatch stopwatch = new Stopwatch();
Random rand = new Random();
int phrase = rand.Next(0,5);
int errors = 0;
int correct = 0;
string challengePhrase = phrases[phrase];
Console.WriteLine(challengePhrase);
Console.SetCursorPosition(0, 2);

char temp = Console.ReadKey(true).KeyChar;
stopwatch.Start();
for (int i = 0; i < challengePhrase.Count(); i++)
{
    if (temp == challengePhrase[i])
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(challengePhrase[i]);
        correct++;
    }
    else if (temp != challengePhrase[i])
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(challengePhrase[i]);
        errors++;
    }
    temp = Console.ReadKey(true).KeyChar;
}
stopwatch.Stop();
double seconds = stopwatch.ElapsedMilliseconds/1000.0;

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine();
Console.WriteLine($"Your phrase was - words: you took {seconds} seconds and made {errors} mistakes.\nYour accuracy was -%!");
