using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicsStorePOS
{
    internal class Validation
    {
        /// <summary>
        /// Displays an error message to the user
        /// </summary>
        /// <param name="errorString">The error message being displayed</param>
        /// <param name="errorCaption">The caption of the error</param>
        public static void DisplayError(string errorString, string errorCaption)
        {
            MessageBox.Show(errorString, errorCaption,
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Displays an informational message to the user
        /// </summary>
        /// <param name="messageString">The message being displayed</param>
        /// <param name="messageCaption">The caption of the message</param>
        public static void DisplayMessage(string messageString, string messageCaption)
        {
            MessageBox.Show(messageString, messageCaption,
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Checks if a textbox has text, and returns true or false accordingly.
        /// </summary>
        /// <param name="currTextBox">The textbox being checked</param>
        /// <returns>True if <paramref name="currTextBox"/> contains text; otherwise False</returns>
        public static bool IsInputPresent(TextBox currTextBox)
        {
            // Check if textbox is empty
            if (string.IsNullOrWhiteSpace(currTextBox.Text))
            {
                return false;
            }

            // If textbox contains text
            return true;
        }

        /// <summary>
        /// Checks if a string is a number
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNumber(string input)
        {
            double number;
            if (double.TryParse(input, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a string is a valid ESRB rating
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsRating(string input)
        {
            if (input == "E" || input == "E10+" || input == "T" || input == "M" || input == "AO" || input == "RP")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Checks if a string is a valid category
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsCategory(string input)
        {
            if (input == "Console" || input == "Game" || input == "Accessory" || input == "PC Component" || input == "Storage Device" || input == "Display" || input == "Software" || input == "Other")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
