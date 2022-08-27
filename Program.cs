// Lines 2-10 are introductory messages
System.Console.WriteLine("Welcome to Mad Libs!\n");
System.Console.Write("Please enter your name: ");
string username = Console.ReadLine();
Console.Clear();

introMessage(username);
static void introMessage(string username)
{
    Console.Write("Hello ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(username);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" let's begin Round One! Press enter to continue...\n");
}

// System.Console.WriteLine($"Hello {username} let's begin Round One! Press enter to continue...\n");
Console.ReadKey();
Console.Clear();

Console.WriteLine("The rules are simple: Respond as prompted and press enter. Then your completed Mad Lib will show!\n");
Console.Clear();

// code to begin playing game1
Console.Write("Please enter a plural noun: ");
string pluralNoun = Console.ReadLine();
Console.Clear();
Console.Write("Please enter a verb with 'ing': ");
string verb = Console.ReadLine();
Console.Clear();
Console.Write("Please enter a number: ");

try
{
    int input = int.Parse(Console.ReadLine());
}
catch (FormatException e)
{
    System.Console.WriteLine($"Please enter a number not a word!");
}

int number = Convert.ToInt32(Console.ReadLine()); //converts string to an int 
Console.Clear();

// calling Game class and assigning parameters to game1
Game game1 = new Game();
game1.text1 = pluralNoun;
game1.text2 = verb;
game1.number = number;

//calling MadLib class
MadLib madLib1 = new MadLib();
printAnswer1(pluralNoun, verb, number);
static void printAnswer1(string pluralNoun, string verb, int number)
{
    Console.Write("Oh you think your day has been tough? Today I found ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(pluralNoun);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" on my doorstep! Can you believe that? I immediately started ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(verb);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write("! I mean there were ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(number);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" of them!! That's insanity!\n");
}

System.Console.WriteLine("That was great! Press enter to continue.");
Console.ReadLine();
Console.Clear();

// code for some interactive banter
bool keepRunning = true;
while (keepRunning)
{
    // Console.WriteLine($"Hey {username} ready for Round 2? Please answer yes, no, or maybe.");
    switchResponse(username);
    static void switchResponse(string username)
    {
        Console.Write("Hey ");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(username);
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" ready for Round 2? Please answer yes, no, or maybe.\n");
    }

    string? userResponse = Console.ReadLine();
    switch (userResponse)
    {
        case "Yes" or "yes":
            System.Console.WriteLine("Hell yeah let's do this! Press enter to continue!");
            keepRunning = false;
            break;
        case "No" or "no":
            System.Console.WriteLine("Ehhh let's play it'll be fun! Press enter to continue with the game!");
            keepRunning = false;
            break;
        case "Maybe" or "maybe":
            System.Console.WriteLine("Tough luck it's game time baby! Press enter to continue with the game!");
            keepRunning = false;
            break;
        default:
            System.Console.WriteLine("Sorry couldn't understand that response. Please enter yes, no, or maybe!");
            break;
    }
}
Console.ReadKey();
Console.Clear();

//logic for game2
Console.Write("Please enter an adjective: ");
string adjective = Console.ReadLine();
Console.Clear();
Console.Write("Please enter a number: ");

try
{
    int input = int.Parse(Console.ReadLine());
}
catch (FormatException e)
{
    System.Console.WriteLine($"Please enter a number not a word!");
}

int number2 = Convert.ToInt32(Console.ReadLine());
Console.Clear();
Console.Write("Please enter a verb with 'ing': \n");
string verb2 = Console.ReadLine();
Console.Clear();
// calling the Game class to make game2 usable
Game game2 = new Game();
game2.text1 = adjective;
game2.text2 = verb2;
game2.number = number2;

// calling MadLib class to make madLib2
MadLib madLib2 = new MadLib();
printAnswer2(adjective, verb2, number2);
static void printAnswer2(string adjective, string verb2, int number2)
{
    Console.Write("They say there are many ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(adjective);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" fish in the sea. However, so far I've only found ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(number2);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" fish in the proverbial sea. It's enough to make a girl start ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(verb2);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" around here! Maybe we ought to go fish in the pond!\n");
}

System.Console.WriteLine("Haha. Amazing! Press enter to continue.");
Console.ReadLine();
Console.Clear();

// logic for countdown
countDown(username);
static void countDown(string username)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(username);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(", ready for the final round? Press enter to continue...\n");
}
// System.Console.WriteLine($"{username}, ready for the final round? Let's go!");
Console.ReadKey();
Console.Clear();

for (int i = 3; i >= 1; i--)
{
    System.Console.WriteLine(i);
    Console.ReadKey();
}
Console.Clear();
// \n isn't working. Adding break line
System.Console.WriteLine();
Console.Write("Please enter a noun: ");
string noun = Console.ReadLine();
Console.Clear();
Console.Write("Please enter an adjective: ");
string adjective2 = Console.ReadLine();
Console.Clear();
Console.Write("Please enter a number: \n");

try
{
    int input = int.Parse(Console.ReadLine());
}
catch (FormatException e)
{
    System.Console.WriteLine($"Please enter a number not a word!");
}

int number3 = Convert.ToInt32(Console.ReadLine());
Console.Clear();

// calling Game class for 3rd round
Game game3 = new Game();
game3.text1 = noun;
game3.text2 = adjective2;
game3.number = number3;

MadLib madLib3 = new MadLib();
printAnswer3(noun, adjective2, number3);
static void printAnswer3(string noun, string adjective2, int number3)
{
    Console.Write("We once saw a ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(noun);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" walking on the beach. It was ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(adjective2);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" and we couldn't believe that it came right up to us! We finally had to bribe it with ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(number3);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" cookies to get the ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(noun);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" to leave us alone!\n");
}

Console.ReadKey();
Console.Clear();
//exit message
exitMessage(username);
static void exitMessage(string username)
{
    Console.Write("Congratulations! ");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write(username);
    Console.ForegroundColor = ConsoleColor.White;
    Console.Write(" you completed the game! Hope you enjoyed flexing your lexicon! Play again anytime!\n");
}

// System.Console.WriteLine($"Congratulations {username} you completed the game! Hope you enjoyed flexing your lexicon! Play again anytime!");
//class for games
internal class Game
{
    public string text1 { get; set; }
    public string text2 { get; set; }
    public int number { get; set; }
}
//class for Madlibs
internal class MadLib
{
    public string sentence1 { get; set; }
    public string sentence2 { get; set; }
    public string sentence3 { get; set; }
}