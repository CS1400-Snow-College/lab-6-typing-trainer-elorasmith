// See https://aka.ms/new-console-template for more information

// Elora Smith, 3/11/25, Lab 6 Typing Trainer

Console.Clear();
string instructions = "Welcome to Typing Trainer! Type the challenge text that appears on the following line. I will report your speed and accuracy.";
Console.WriteLine(instructions);
Console.WriteLine();

string[] phrases = {
    "Our greatest glory is not in never falling, but in rising every time we fall. -Confucius",
    "Never, never and never again shall it be that this beautiful land will again experience the oppression of one by another. -Nelson Mandela",
    "History, despite its wrenching pain, cannot be unlived, but if faced with courage, need not be lived again. -Maya Angelou",
    "A small body of determined spirits fired by an unquenchable faith in their mission can alter the course of history. -Mahatma Gandhi",
    "Posterity! You will never know how much it cost the present generation to preserve your freedom! I hope you will make good use of it. -John Adams"
};

Random rand = new Random();
int phrase = rand.Next(0,5);
Console.WriteLine(phrases[phrase]);
