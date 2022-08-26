// Lines 2-10 are introductory messages
System.Console.WriteLine("Welcome to Mal's Mad Libs!\n");

System.Console.Write("Please enter your name: ");

string username = Console.ReadLine();

System.Console.WriteLine($"Hello {username} let's begin Round One!\n");

Console.WriteLine("The rules are simple: Respond as prompted and press enter. Then your completed Mad Lib will show!\n");


    // code to begin playing game1
    Console.Write("Please enter a plural noun: ");
    string pluralNoun = Console.ReadLine();

    Console.Write("Please enter a verb with 'ing': ");
    string verb = Console.ReadLine();
    
    Console.Write("Please enter a number: ");
    int number = Convert.ToInt32(Console.ReadLine()); //converts string to an int

    // calling Game class and assigning parameters to game1
Game game1 = new Game();
game1.text1 = pluralNoun;
game1.text2 = verb;
game1.number = number;

// code to create first mad lib
        string roundOneSentence1 = $"Oh you think your day has been tough? Today I found {pluralNoun} on my doorstep!";
        string roundOneSentence2 = $"Can you believe that? I immediately started {verb}!";
        string roundOneSentence3 = $"I mean there were {number} of them!! That's insanity!\n";

        //calling MadLib class
        MadLib madLib1 = new MadLib();
        madLib1.sentence1 = roundOneSentence1;
        madLib1.sentence2 = roundOneSentence2;
        madLib1.sentence3 = roundOneSentence3;

        // \n isn't working. Adding break line
        System.Console.WriteLine();

        System.Console.WriteLine(roundOneSentence1 + " " + roundOneSentence2 + " " + roundOneSentence3); // printing madlib1 to console



// Press Enter to continue, otherwise they cannot see the printed MadLib
System.Console.WriteLine("That was great! Press enter to continue.");
Console.ReadLine();

// code for some interactive banter
Console.WriteLine($"Hey {username} ready for Round 2? Please answer yes, no, or maybe.");
string userResponse = Console.ReadLine();

if (userResponse == "yes")
{
    System.Console.WriteLine("Hell yeah let's do this!\n");
}
else if (userResponse == "maybe")
{
    System.Console.WriteLine("Ehhh let's play it'll be fun!\n");
}
else if (userResponse == "no")
{
    System.Console.WriteLine("Tough luck it's game time baby!\n");
}
else 
{
    System.Console.WriteLine("Sorry couldn't understand that response. Please enter yes, no, or maybe!\n");
}

//logic for game2
    Console.Write("Please enter an adjective: ");
string adjective = Console.ReadLine();

Console.Write("Please enter a number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter a verb with 'ing': \n");
string verb2 = Console.ReadLine();

    // calling the Game class to make game2 usable
Game game2 = new Game();
game2.text1 = adjective;
game2.text2 = verb2;
game2.number = number2;

// \n isn't working. Adding break line
System.Console.WriteLine();

string roundTwoSentence1 = $"They say there are many {adjective} fish in the sea.";
string roundTwoSentence2 = $"However, so far I've only found {number2} fish in the proverbial sea.";
string roundTwoSentence3 = $"It's enough to make a girl start {verb2} around here! Maybe we ought to go fish in the pond!\n";

// calling MadLib class to make madLib2
MadLib madLib2 = new MadLib();
madLib2.sentence1 = roundTwoSentence1;
madLib2.sentence2 = roundTwoSentence2;
madLib2.sentence3 = roundTwoSentence3;

// \n isn't working. Adding break line
System.Console.WriteLine();

System.Console.WriteLine(roundTwoSentence1 + " " + roundTwoSentence2 + " " + roundTwoSentence3); // prints madLib2 to console

// Press Enter to continue, otherwise they cannot see the printed MadLib
System.Console.WriteLine("Haha. Amazing! Press enter to continue.");
Console.ReadLine();

// logic for countdown
for (int i = 3; i >= 1; i--)
{
    System.Console.WriteLine(i);
}

System.Console.WriteLine($"{username}, ready for the final round? Let's go!");

// \n isn't working. Adding break line
System.Console.WriteLine();

Console.Write("Please enter a noun: ");
string noun = Console.ReadLine();

Console.Write("Please enter an adjective: ");
string adjective2 = Console.ReadLine();

Console.Write("Please enter a number: \n");
int number3 = Convert.ToInt32(Console.ReadLine());

// calling Game class for 3rd round
Game game3 = new Game();
game3.text1 = noun;
game3.text2 = adjective2;
game3.number = number3;

string roundThreeSentence1 = $"We once saw a {noun} walking on the beach.";
string roundThreeSentence2 = $"It was {adjective2} and we couldn't believe that it came right up to us!";
string roundThreeSentence3 = $"We finally had to bribe it with {number3} cookies to get the {noun} to leave us alone!\n";

// calling MadLib class to make madLib3
MadLib madLib3 = new MadLib();
madLib3.sentence1 = roundThreeSentence1;
madLib3.sentence2 = roundThreeSentence2;
madLib3.sentence3 = roundThreeSentence3;

System.Console.WriteLine(roundThreeSentence1 + " " + roundThreeSentence2 + " " + roundThreeSentence3); // prints madlib3 to console

//exit message
System.Console.WriteLine($"Congratulations {username} you completed the game! Hope you enjoyed flexing your lexicon! Play again anytime!");

//class for games
internal class Game {
    public string text1 { get; set; }
    public string text2 { get; set; }
    public int number { get; set; }
}

//class for Madlibs
internal class MadLib {
    public string sentence1 { get; set; }
    public string sentence2 { get; set; }
    public string sentence3 { get; set; }
}