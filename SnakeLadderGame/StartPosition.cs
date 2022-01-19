using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGame
{
    public class StartPosition
    {
<<<<<<< HEAD
        //Instance Variables.
        int playerOnePosition = 0;               //player one member variable
        int playerOneDieCount = 0;
        int playerOneStatus;
        int playerOneDie;
        int playerTwoPosition = 0;             //player two member variable
        int playerTwoDieCount = 0;
        int playerTwoStatus;
        int playerTwoDie;
        const int MaxPosition = 100;        //Constant variables
        const int LADDER = 1;
        const int SNAKE = 2;
        Random random = new Random();       // object of random class
       
        public void StartGame()             //Method
        {
            Console.WriteLine("\nPosition of playerOne: " + playerOnePosition);
            Console.WriteLine("\nPosition of playerTwo: " + playerTwoPosition);

            //Using While Loop to iterate Game till any of one player reaches max position
            while (playerOnePosition < MaxPosition && playerTwoPosition < MaxPosition)
            {
                int playCheck = random.Next(0, 3); //Generating random value between 0 to 2 to pass die to both players               
                if (playCheck == 1)                                 //value on die is 1
                {
                    //Player ONE conditions
                    playerOneDie = random.Next(1, 7);
                    playerOneDieCount++;
                    playerOneStatus = random.Next(0, 3);
                    switch (playerOneStatus)
                    {
                        case LADDER:                                   //using case statements
                            if (playerOnePosition > MaxPosition)
                                playerOnePosition -= playerOneDie;
                            while (playerOneStatus == LADDER)          //player gets ladder so playing again
                            {
                                playerOneStatus = random.Next(0, 3);
                                if (playerOneStatus == LADDER)
                                {
                                    playerOneDie = random.Next(1, 7);
                                    playerOnePosition += playerOneDie;
                                    playerOneDieCount++;
                                    if (playerOnePosition > MaxPosition)
                                        playerOnePosition -= playerOneDie;
                                    if (playerOnePosition == MaxPosition)
                                        break;
                                }
                                if (playerOneStatus == SNAKE)    //player gets snake 
                                {
                                    playerOnePosition -= playerOneDie;
                                    playerOneDieCount++;
                                    break;
                                }
                            }
                            break;
                        case SNAKE:
                            playerOnePosition -= playerOneDie;
                            break;
                        default:
                            break;
                    }
                    if (playerOnePosition < 0)
                    {
                        playerOnePosition = 0;
                        Console.WriteLine("First player position is: " + playerOnePosition);
                    }
                    if (playerOnePosition < MaxPosition)
                    {
                        playerOnePosition += playerOneDie;
                        Console.WriteLine("First player position is: " + playerOnePosition);
                    }
                    if (playerOnePosition == MaxPosition)
                    {
                        Console.WriteLine("First player reaches the winning position:" + playerOnePosition);
                        Console.WriteLine("Total number of times rolled dice by first player is:" + playerOneDieCount);  //printing total number od die rolled by 1st player
                        break;
                    }
                }
                else if (playCheck == 2)                          //value on die is 2
                {
                    //Player TWO conditions
                    playerTwoDie = random.Next(1, 7);
                    playerTwoDieCount++;
                    playerTwoStatus = random.Next(0, 3);
                    switch (playerTwoStatus)
                    {
                        case LADDER:                                //using case statements
                            if (playerTwoPosition > MaxPosition)   
                                playerTwoPosition -= playerTwoDie;
                            while (playerTwoStatus == LADDER)       //player gets ladder playing again
                            {
                                playerTwoStatus = random.Next(0, 3);
                                if (playerTwoStatus == LADDER)
                                {
                                    playerTwoDie = random.Next(1, 7);
                                    playerTwoPosition += playerTwoDie;
                                    playerTwoDieCount++;
                                    if (playerTwoPosition > MaxPosition)
                                        playerTwoPosition -= playerTwoDie;
                                    if (playerTwoPosition == MaxPosition)
                                        break;
                                }
                                if (playerTwoStatus == SNAKE)       //player gets snake
                                {
                                    playerTwoPosition -= playerTwoDie;
                                    playerTwoDieCount++;
                                    break;
                                }
                            }
                            break;
                        case SNAKE:
                            playerTwoPosition -= playerTwoDie;
                            break;
                        default:
                            break;
                    }
                    if (playerTwoPosition < 0)
                    {
                        playerTwoPosition = 0;
                        Console.WriteLine("Second player position is: " + playerTwoPosition);
                    }
                    if (playerTwoPosition < MaxPosition)
                    {
                        playerTwoPosition += playerTwoDie;
                        Console.WriteLine("Second player position is: " + playerTwoPosition);
                    }
                    if (playerTwoPosition == MaxPosition)
                    {
                        Console.WriteLine("Second player reaches the winning position: " + playerTwoPosition); 
                        Console.WriteLine("Total number of times dice rolled by second player is: " + playerTwoDieCount); //printing total number od die rolled by 2nd player
                    }
                }
            }
=======
        // Instance variable
        int position = 0;
        Random random = new Random(); //Calling object class  

        public void StartGame() //Calling Method
        {
            Console.WriteLine("Player position is: " + position);
            int RandomNum = random.Next(1,7); //Generating random number between 0 and 6
            Console.WriteLine("randomNum: " + RandomNum);
>>>>>>> 921375c02283705383af0ecae517fb5e272e3707
        }
    }
}
