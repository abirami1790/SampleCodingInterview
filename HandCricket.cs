// See https://aka.ms/new-console-template for more information
class Program
{
    static public void Main(string[] args)
    {
        int playerAScore = 0;
        int playerBScore = 0;
        int[] battingthrowsofA = { 3, 4, 1, 5, 6, 0 };
        int[] BowlingThrowsofB = { 3, 6, 0, 2, 1,3 };
        //int score = 0;
        for (int i = 0; i <= 5; i++)
        {
            int temp = Innings(battingthrowsofA[i], BowlingThrowsofB[i]);
            if (temp > 0)
            {
                playerAScore = temp + playerAScore;
            }
            else
            {
                break;
            }
        }
        int[] battingthrowsofB = { 1, 3, 5, 2, 6, 0 };
        int[] BowlingThrowsofA = { 5, 6, 0, 2, 1 ,3};
        //int score = 0;
        for (int i = 0; i <= 5; i++)
        {
            int temp = Innings(battingthrowsofB[i], BowlingThrowsofA[i]);
            if (temp > 0)
            {
                playerBScore = temp + playerBScore;
            }
            else
            {
                break;
            }

        }
        if (playerAScore == playerBScore)
        {
            Console.WriteLine("Both Player Got Same Score =TIE");
        }
        else
        {
            if (playerAScore > playerBScore)
            {
                Console.WriteLine("Player A is the Winner");
            }
            else
            {
                Console.WriteLine("Player B is the Winner");
            }
        }



    }

    private static int Innings(int BattingThrow, int BowlingThrow)
    {

        if (BattingThrow == BowlingThrow)
        {
            Console.WriteLine("Player gets off");
            return -1;
        }
        else
        {

            // int playerscore = playerscore + BattingThrow;
            return BattingThrow;
        }
    }

    //Console.WriteLine("Hello, World!");


}
