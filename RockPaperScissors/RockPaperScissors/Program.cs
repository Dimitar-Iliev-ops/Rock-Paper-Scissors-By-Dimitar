const string rock = "Rock";
const string paper = "Paper";
const string scissors = "Scissors";
string playerMove = "";
string computerMove = "";
Random random = new Random();
int randomNum = random.Next(1, 4);
Console.WriteLine("Choose [r]ock, [p]aper, or [s]cissors:");
playerMove = Console.ReadLine();
if (playerMove == "r")
{
    playerMove = rock;
}
else if (playerMove == "p")
{
    playerMove = paper;
}
else if (playerMove == "s")
{
    playerMove = scissors;
}
else
{
    Console.WriteLine("Invalid input. Try again...");
    return;
}

switch (randomNum)
{
    case 1:
        computerMove = rock;
        break;
    case 2:
        computerMove = paper;
        break;
    case 3:
        computerMove = scissors;
        break;
}

Console.WriteLine($"The computer chose {computerMove}.");

if ((playerMove == rock && computerMove == scissors) ||
    (playerMove == paper && computerMove == rock) ||
    (playerMove == scissors && computerMove == paper))
{
    Console.WriteLine("You win.");
}
else if ((playerMove == scissors && computerMove == rock) ||
         (playerMove == rock && computerMove == paper) ||
         (playerMove == paper && computerMove == scissors))
{
    Console.WriteLine("You lose.");
}
else
{
    Console.WriteLine("The game was a draw.");
}
