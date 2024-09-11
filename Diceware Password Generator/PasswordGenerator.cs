using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diceware_Password_Generator
{
    internal class PasswordGenerator
    {
        WordsList wordsList = new WordsList();
        Dice dice = new Dice();

        string password;
        string passwordindex;

        public void GeneratePassword()
        {
            password = "";

            for (int i = 0; i < dice.GetDiceCount(); i++)
            {
                bool passTooLong = true;
                while (passTooLong == true)
                {
                    passwordindex = dice.GetDice1().ToString() + dice.GetDice2().ToString() + dice.GetDice3().ToString() + dice.GetDice4().ToString();

                    if (Convert.ToInt32(passwordindex) < wordsList.GetWordsCount() - 1)
                    {
                        passTooLong = false;
                    }
                }

                password += wordsList.word(Convert.ToInt32(passwordindex)) + " ";
            }
        }

        public string GetPassword()
        {
            GeneratePassword();
            return password;
        }
    }
}
