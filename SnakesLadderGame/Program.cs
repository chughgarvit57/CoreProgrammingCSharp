namespace SnakesLadderGame
{
    internal class Program
    {
        static Random random = new Random();
        static int WINNING_POSITION = 100;
        static int[] snakes = new int[101];
        static int[] ladders = new int[101];
        static void InitialiseBoard()
        {
            // Defining snake points
            snakes[29] = 8;
            snakes[68] = 37;
            snakes[73] = 50;
            snakes[84] = 65;
            snakes[93] = 74;
            snakes[99] = 3;

            // Defining ladder points
            ladders[14] = 35;
            ladders[21] = 42;
            ladders[43] = 81;
            ladders[63] = 98;
            ladders[66] = 85;
            ladders[70] = 91;
        }
        static int RollDice()
        {
            return random.Next(1,7);
        }
        static int MovePlayer(int position, int diceRoll)
        {
            int newPosition = position + diceRoll;

            // ✅ Prevent accessing out-of-bounds array index
            if (newPosition > WINNING_POSITION)
            {
                return position; // Stay at the same position if overshooting 100
            }

            // ✅ Check if newPosition is within valid bounds before accessing arrays
            if (newPosition >= 0 && newPosition <= WINNING_POSITION)
            {
                if (snakes[newPosition] != 0)
                {
                    Console.WriteLine($"OUCHHH! Snake at {newPosition}, moving down to {snakes[newPosition]}");
                    return snakes[newPosition];
                }

                if (ladders[newPosition] != 0)
                {
                    Console.WriteLine($"YAYYY! Ladder at {newPosition}, climbing up to {ladders[newPosition]}");
                    return ladders[newPosition];
                }
            }

            return newPosition; // Return new position if no snake or ladder
        }

        static void StartGame()
        {
            InitialiseBoard();
            int player1Position = 0, player2Position = 0, turn = 1, diceRolls = 0;
            while(player1Position < WINNING_POSITION &&  player2Position < WINNING_POSITION)
            {
                int diceRoll = RollDice();
                diceRolls++;
                Console.WriteLine($"Player {turn} rolled a {diceRoll}");
                bool extraTurn = false; // check if player needs extra turn if climbed up the ladder
                if(turn == 1)
                {
                    int previousPosition = player1Position;
                    player1Position = MovePlayer(player1Position, diceRoll);
                    Console.WriteLine($"Player 1 is at {player1Position}");
                    if (previousPosition + diceRoll <= WINNING_POSITION && ladders[previousPosition + diceRoll] != 0)
                    {
                        extraTurn = true; // grant extra turn if player climbed up the ladder
                    }
                }
                else
                {
                    int previousPosition = player2Position;
                    player2Position = MovePlayer(player2Position, diceRoll);
                    Console.WriteLine($"Player 2 is at {player2Position}");
                    if (previousPosition + diceRoll <= WINNING_POSITION && ladders[previousPosition + diceRoll] != 0)
                    {
                        extraTurn = true; // grant extra turn if player climbed up the ladder
                    }
                }
                if(!extraTurn)
                {
                    turn = (turn == 1) ? 2 : 1;
                }
            }
            Console.WriteLine($"Player {(player1Position == WINNING_POSITION ? 1 : 2)} wins after {diceRolls} rolls!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! Welcome To Snakes & Ladder Game!");
            StartGame();
        }
    }
}
