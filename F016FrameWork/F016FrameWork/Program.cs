using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace F016FrameWork
{
    class Program
    {
        static bool argsWay = false;

        static readonly List<Tuple<int, string,string>> gameElements = new List<Tuple<int, string, string>>
        {
            Tuple.Create(1,"ko", "kő"),
            Tuple.Create(2,"papir", "papír"),
            Tuple.Create(3,"ollo", "olló"),
        };

        static void Main(string[] args)
        {
            InputCheck.CommandCheck.UserInformEvent += MessagePrintOut;

            string input = String.Empty;
            int convertedGameRounds = 0;

            //Set game number to start the program by using command-line args.
            if (args != null && args.Length > 0)
            {
                argsWay = true;
                input = args[0];

                if (InputCheck.CommandCheck.InputIsCorrect(input, argsWay, out convertedGameRounds))
                {
                    GamePlay(convertedGameRounds);
                }
                else
                {
                    argsWay = false;//If argsWay input was not correct change bool back to fals to get chanche to play.
                }
            }

            if (!argsWay)//Normal start whithout args.
            {
                bool playAGame = true;
                Console.WriteLine(ProgramTexts.MainText);

                do
                {
                    Console.WriteLine(ProgramTexts.TypeTheNumberOfTheRounds);
                    input = Console.ReadLine();

                    playAGame = !(input.Trim().ToLower() == ProgramTexts.QuitLetter);

                    if (playAGame && InputCheck.CommandCheck.InputIsCorrect(input, argsWay, out convertedGameRounds))
                    {
                        playAGame = ActualchoiceErrorMessage(GamePlay(convertedGameRounds), Environment.NewLine +
                            ProgramTexts.WouldYouLikeToPlayAnOtherGame);
                    }

                }
                while (playAGame);
            }

            Console.WriteLine(Environment.NewLine + ProgramTexts.GoodBye);
            Console.ReadKey();
        }
        /// <summary>
        /// To print out the actual choices this function send the choosen element name.
        /// </summary>
        /// <param name="choosenElement"></param>
        /// <returns></returns>
        static string ChoiceName (int choosenElement)
        {
            Tuple<int, string, string> foundtuple;

            foundtuple = gameElements.FirstOrDefault(x=>x.Item1 == choosenElement);

            return foundtuple.Item3;
        }
        /// <summary>
        /// To make choice-messages printing a bit simpler, if it is possible.
        /// </summary>
        /// <param name="print"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        static bool ActualchoiceErrorMessage(bool print, string message)
        {
            if (print)
            {
                Console.WriteLine(message);
            }

            return print;
        }
        /// <summary>
        /// Give a result based on the actual choices.
        /// </summary>
        /// <param name="humanChoice"></param>
        /// <param name="computerChoice"></param>
        /// <returns></returns>
        static int RoundResult(int humanChoice, int computerChoice, out string humanChoiceAsAWord, out string computerChoiceAsAWord)
        {
            humanChoiceAsAWord = ChoiceName(humanChoice);
            computerChoiceAsAWord = ChoiceName(computerChoice);

            List<Tuple<int, int, int>> choiceCollection = new List<Tuple<int, int, int>>
            {
                Tuple.Create(1,1,0),//rock/rock = equal
                Tuple.Create(2,2,0),//paper/paper = equal
                Tuple.Create(3,3,0),//scissors/scissors = equal

                Tuple.Create(1,3,1),//Hrock/Cscissors human wins
                Tuple.Create(2,1,1),//Hpaper/Crock human wins
                Tuple.Create(3,2,1),//Hscissors/Cpaper human wins

                Tuple.Create(1,2,2),//Hrock/Cpaper = computer wins
                Tuple.Create(2,3,2),//Hpaper/Cscissors = compuetr wins
                Tuple.Create(3,1,2),//Hscissors/Crock = computer wins
            };

            Tuple<int, int, int> foundTuple;

            foundTuple = choiceCollection.FirstOrDefault(x => x.Item1 == humanChoice && x.Item2 == computerChoice);

            return foundTuple.Item3;
        }
        /// <summary>
        /// Check the game input, if it is correct to score, out parameter going to be the players' choice converted to number.
        /// </summary>
        /// <param name="actualChoice"></param>
        /// <param name="actualChoiceAsANumber"></param>
        /// <returns></returns>
        static bool GameInputIsNotCorrect(string actualChoice, out int actualChoiceAsANumber)
        {
            actualChoiceAsANumber = 0;
            Tuple<int, string, string> foundTuple = null;

            if (!Int32.TryParse(actualChoice, out actualChoiceAsANumber))
            {
                actualChoiceAsANumber = -1;
                foundTuple = gameElements.FirstOrDefault(x => x.Item2 ==
                actualChoice.Trim().ToLower().Replace('ő', 'o').Replace('ö', 'o').
                                Replace('ó', 'o').Replace('á', 'a').Replace('í', 'i'));

                if (foundTuple != null)
                {
                    actualChoiceAsANumber = foundTuple.Item1;
                }
            }
            else
            {
                int actualChoiceToFindelement = actualChoiceAsANumber;
                foundTuple = gameElements.FirstOrDefault(x => x.Item1 == actualChoiceToFindelement);

                actualChoiceAsANumber = foundTuple != null ? actualChoiceToFindelement : -1; 
            }

            return actualChoiceAsANumber == -1;
        }
        /// <summary>
        /// Player can play the given nunmber of rounds. Function first checks the input (till it is correct),
        /// makes a comparison to the computers choice than print out the result and ask for continue.
        /// </summary>
        /// <param name="convertedRoundNumber"></param>
        /// <returns></returns>
        static bool GamePlay(int convertedRoundNumber)
        {
            string questionAboutContinue = String.Empty;
            bool gamePlayedSuccessfully = false;
            int actualChoiceAsANumber = 0;

            int playedGameRounds = 0;
            int winByPlayer = 0;
            int equal = 0;

            string humanChoiceAsAWord = String.Empty;
            string computerChoiceAsAWord = String.Empty;

            Random randomComputerChoice = new Random();

            do
            {
                do//Until the input is not correct player get an error message.
                {
                    Console.WriteLine(ProgramTexts.TypeYourChoice);
                }
                while (ActualchoiceErrorMessage(GameInputIsNotCorrect(Console.ReadLine(), out actualChoiceAsANumber),
                                ProgramTexts.InputIsNotCorrect));

                actualChoiceAsANumber = RoundResult(actualChoiceAsANumber, randomComputerChoice.Next(
                    RockPaperScissorsElements.ComputerMinimumCalculationNumber,//actualChoice is also used to decide which  chategory should be grown (equal or winByPlayer).
                    RockPaperScissorsElements.ComputerMaximumCalculationNumber), out humanChoiceAsAWord, out computerChoiceAsAWord);

                if(actualChoiceAsANumber == 0)
                {
                    equal++;
                }
                if(actualChoiceAsANumber == 1)
                {
                    winByPlayer++;
                }

                playedGameRounds++;

                gamePlayedSuccessfully = playedGameRounds == convertedRoundNumber;

                Console.Clear();

                PrintResult(gamePlayedSuccessfully, playedGameRounds, winByPlayer, equal, humanChoiceAsAWord, computerChoiceAsAWord);

                if (!argsWay)//If program started argsWay there is no question about continue, game has to be played to the final round.
                {
                    if (!gamePlayedSuccessfully)
                    {
                        Console.WriteLine(ProgramTexts.WouldYouLikeToContinue);
                        questionAboutContinue = Console.ReadLine().Trim().ToLower();
                    }
                }

            } while ((questionAboutContinue != ProgramTexts.QuitLetter && !gamePlayedSuccessfully));

            return gamePlayedSuccessfully;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="final"></param>
        /// <param name="playedGameNumber"></param>
        /// <param name="winByPlayer"></param>
        /// <param name="equal"></param>
        /// <param name="humanChoiceAsAWord"></param>
        /// <param name="computerChoiceAsAWord"></param>
        static void PrintResult(bool final, int playedGameNumber, int winByPlayer, int equal, string humanChoiceAsAWord, string computerChoiceAsAWord)
        {
            int result = playedGameNumber - winByPlayer - equal;

            Console.WriteLine(Environment.NewLine + ProgramTexts.ActualGameChoices + Environment.NewLine, humanChoiceAsAWord, computerChoiceAsAWord);
            Console.WriteLine((final ? ProgramTexts.FinalResult : ProgramTexts.ActualResult) +
                ProgramTexts.ResultText, winByPlayer, equal, result);

            if(final)
            {
                Console.WriteLine(result == winByPlayer ? ProgramTexts.Equal : ProgramTexts.TheWinneris, winByPlayer > result &&
                                    result != winByPlayer ? ProgramTexts.Human : ProgramTexts.Computer);
            }
        }
        /// <summary>
        /// Print a string depends on the program was launched by command-line or normal way and print errors.
        /// </summary>
        /// <param name="messageCode"></param>
        /// <param name="argsWasUsed"></param>
        /// <returns></returns>
        public static void MessagePrintOut(InputCheck.MessageEnum messageCode, bool argsWasUsed)
        {
            string commandLineMessage = String.Empty;

            switch (messageCode)
            {
                case InputCheck.MessageEnum.NoInput:
                    commandLineMessage = InputCheckMessages.NoInput;
                    break;
                case InputCheck.MessageEnum.InputIsCorrect:
                    commandLineMessage = InputCheckMessages.CommandLineInputIsCorrect;
                    break;
                case InputCheck.MessageEnum.InputIsNotCorrect:
                    commandLineMessage = InputCheckMessages.InputIsNotCorrect;
                    break;
                case InputCheck.MessageEnum.InputIsSmalerThanOne:
                    commandLineMessage = InputCheckMessages.InputIsSmallerThanOne;
                    break;
                case InputCheck.MessageEnum.InputIsTooBig:
                    commandLineMessage = InputCheckMessages.InputIsTooBig;
                    break;
            }

            Console.WriteLine(argsWasUsed && messageCode != InputCheck.MessageEnum.InputIsCorrect ?
                InputCheckMessages.CommandLineError + commandLineMessage : commandLineMessage);
        }
    }
}

