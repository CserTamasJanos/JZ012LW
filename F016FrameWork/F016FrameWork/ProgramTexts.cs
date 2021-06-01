using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F016FrameWork
{
    class ProgramTexts
    {
        public const string ResultText = " Játékos: {0}, Döntetlen: {1}, Számítógép: {2},";
        public const string FinalResult = "A játék végeredménye: ";
        public const string ActualResult = "Az eddigi játék eredménye: ";
        public const string MainText = "Ez egy Kő/Papír/Olló játék. A játék során számokkal 1(kő), 2(papír), 3(olló) és szavakkal kő, papír, olló is tud játszani. A kilépéshez nyomjon K-t.";
        public const string QuitLetter = "k";
        public const string TypeYourChoice = "Adja meg, hogy mit választott:";
        public const string TypeTheNumberOfTheRounds = "Új játék kezdéséhez adja meg hány kört szeretne játszani. Maximum 20 kör lehetséges.";
        public const string InputIsNotCorrect = "Nem megfelelő a begépelt adat formátuma, gépelje be újra (Számok egytől háromig 1(kő), 2(papír), 3(olló) vagy szavak kő, papír, olló).";
        public const string WouldYouLikeToPlayAnOtherGame = "A játék véget ért. Ha ki szeretne lépni nyomjon K-t";
        public const string GoodBye = "Viszont látásra!";
        public const string WouldYouLikeToContinue = "A következő körhöz nyomjon meg egy gombot, ha ki szeretne lépni nyomjon K-t.";
        public const string NoResultToPrintOut = "Nem játszott egy menetet sem, majd legközelebb.";
        public const string ActualGameChoices = "Az előbbi játékban a játékos választása: {0} a számítógép választása: {1} volt.";
        public const string TheWinneris = "{0} lett a győztes.";
        public const string Human = "A Játékos";
        public const string Computer = "A Számítógép";
        public const string Equal = "Döntetlen.";
    }

    class InputCheckMessages
    {
        public const string NoInput = "A beviteli mező üresen maradt.";
        public const string InputIsNotCorrect = "Nem számot adott meg.";
        public const string InputIsSmallerThanOne = "Egynél kissebb számot adott meg.";
        public const string InputIsTooBig = "A megadott szám túl nagy.";
        public const string CommandLineError = "Hiba a parancssori indításkor.";
        public const string CommandLineInputIsCorrect = "A Program parancssori indítással indult el.";
    }

    class RockPaperScissorsElements
    {
        public const int ComputerMinimumCalculationNumber = 1;
        public const int ComputerMaximumCalculationNumber = 3;
    }
}
