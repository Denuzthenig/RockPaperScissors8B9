const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

int roundsPlayed = 0;
int playerWins = 0;
int computerWins = 0;
int draws = 0;

while (roundsPlayed < 10)
{
    Console.WriteLine($"Round {roundsPlayed + 1}/10");
    string playerMove = GetPlayerMove();

    if (playerMove == "Invalid")
    {
        Console.WriteLine("Invalid input. Try again...");
        continue;
    }

    string computerMove = GetComputerMove();

    Console.WriteLine($"The Computer chose {computerMove}.");

    string result = GetResult(playerMove, computerMove);

    if (result == "Player")
    {
        Console.WriteLine("You win.");
        playerWins++;
    }
    else if (result == "Computer")
    {
        Console.WriteLine("You lose.");
        computerWins++;
    }
    else
    {
        Console.WriteLine("This game was a draw.");
        draws++;
    }

    roundsPlayed++;
    Console.WriteLine(); // empty line
}

Console.WriteLine("Game over!");
Console.WriteLine($"Wins: {playerWins}, Losses: {computerWins}, Draws: {draws}");


// Functions:

string GetPlayerMove()
{
    Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors: ");
    string input = Console.ReadLine();

    if (input == "r" || input == Rock)
    {
        return Rock;
    }
    else if (input == "p" || input == Paper)
    {
        return Paper;
    }
    else if (input == "s" || input == Scissors)
    {
        return Scissors;
    }
    else
    {
        return "Invalid";
    }
}

string GetComputerMove()
{
    Random random = new Random();
    int computerRandomNumber = random.Next(1, 4);

    switch (computerRandomNumber)
    {
        case 1: return Rock;
        case 2: return Paper;
        case 3: return Scissors;
        default: return Rock; // shouldn't happen
    }
}

string GetResult(string playerMove, string computerMove)
{
    if ((playerMove == Rock && computerMove == Scissors) ||
        (playerMove == Paper && computerMove == Rock) ||
        (playerMove == Scissors && computerMove == Paper))
    {
        return "Player";
    }
    else if ((playerMove == Rock && computerMove == Paper) ||
             (playerMove == Paper && computerMove == Scissors) ||
             (playerMove == Scissors && computerMove == Rock))
    {
        return "Computer";
    }
    else
    {
        return "Draw";
    }
}
