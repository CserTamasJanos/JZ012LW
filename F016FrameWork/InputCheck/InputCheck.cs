using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputCheck
{
    public class CommandCheck
    {
        public delegate void UserInform(MessageEnum messageCode, bool argsWasUsed);
        public static event UserInform UserInformEvent;

        /// <summary>
        /// Make enum-branches depends on the input (number, or correct number) and the way program starts (whit or whitout command-line).
        /// </summary>
        /// <param name="input"></param>
        /// <param name="argsWasUsed"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool InputIsCorrect(string input, bool argsWasUsed, out int result)
        {
            result = 0;
            MessageEnum enumResult = MessageEnum.InputIsCorrect;

            if (String.IsNullOrEmpty(input))
            {
                enumResult = MessageEnum.NoInput;
            }
            else if (!Int32.TryParse(input, out result))
            {
                enumResult = MessageEnum.InputIsNotCorrect;
            }
            else if (result < 1)
            {
                enumResult = MessageEnum.InputIsSmalerThanOne;
            }
            else if (result > 1 && result > Texts.MultiplicationLimitNumber)
            {
                enumResult = MessageEnum.InputIsTooBig;
            }

            //Because messages are mounted (Error and Ok messages) the InputIsCorrect should run if command-line is used.  
            if (enumResult != MessageEnum.InputIsCorrect || argsWasUsed)
            {
                if (UserInformEvent != null)
                {
                    UserInformEvent.Invoke(enumResult, argsWasUsed);
                }
            }

            return enumResult == MessageEnum.InputIsCorrect;
        }
    }
}
