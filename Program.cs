
using System;

namespace CaesarCipher
{
    class Program
    {
        public static void Main(string[] args)
        {
                //Define global variables
                char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
                string newMessage = "";
                int counter = 0;
            //keeps program running until terminated
            while (counter == 0)
            {
                //User selects a mode
                int selection = SelectMode(alphabet);
                //Message is recieved and converted to a char array
                Console.WriteLine("Enter message:  ");
                string userMessage = Console.ReadLine();
                char[] secretMessage = userMessage.ToCharArray();
                //Mode selection is activated
                if (selection == 1)
                {
                    newMessage = EncryptMessage(alphabet, secretMessage);
                }
                else if (selection == 2)
                {
                    newMessage = DecryptMessage(alphabet, secretMessage);
                }
                //Display results
                Console.WriteLine(newMessage);
                counter = ContinueOrNo();


            }
        }
        //User selects whether to continue or end program
        private static int ContinueOrNo()
        {
            Console.WriteLine("Would you like to continue?  ");
            string userAnswer = Console.ReadLine();
            userAnswer.ToLower();
            int selection = 0;
            if (userAnswer == "yes" || userAnswer == "y")
            {
                selection = 0;
            }
            else
            {
                selection++;
            }
            return selection;
        }
        //User selects whether to encrypt or decrypt a message
        public static int SelectMode(char[] alphabet)
        {
            Console.WriteLine("Would you like to encrpyt or decrypt a message? (e or d) ");
            string userAnswer = Console.ReadLine();
            userAnswer.ToLower();
            int selection = 0;
            //assigns int value to user string
            if (userAnswer == "encrypt" || userAnswer == "e")
            {
                selection = 1;
            }
            else if (userAnswer == "decrypt" || userAnswer == "d")
            {
                selection = 2;
            }
            return selection;
            }

        //takes a message and converts it into an encrypted message
        public static string EncryptMessage(char[] alphabet, char[] secretMessage)
        {
            char[] encryptedMessage = new char[secretMessage.Length];
            string newMessage = "";
            char newLetter = ' ';
            for (int i = 0; i < secretMessage.Length; i++)
            {
                //picks a letter at index [i] from the message and finds the letter's value
                char currentLetter = secretMessage[i];
                int indexOfLetter = Array.IndexOf(alphabet, currentLetter);
                //condition for spaces or other characters not in alphabet
                if (indexOfLetter == -1)
                {
                    encryptedMessage[i] = ' ';

                }
                else
                {
                    //encrypts letter by modifying the value (modulo keeps new value within range)
                    indexOfLetter = (indexOfLetter + 3) % 26;
                    //finds new letter from modified value and joins it to a new string
                    newLetter = alphabet[indexOfLetter];
                    encryptedMessage[i] = newLetter;
                    newMessage = String.Join("", encryptedMessage);

                }
            }
            return newMessage;
        }

        //takes a message and converts it into a decrypted message
        private static string DecryptMessage(char[] alphabet, char[] secretMessage)
        {
            char[] decryptedMessage = new char[secretMessage.Length];
            string newMessage = "";

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char currentLetter = secretMessage[i];
                int indexOfLetter = Array.IndexOf(alphabet, currentLetter);
                if (indexOfLetter == -1)
                {
                    decryptedMessage[i] = ' ';
                }
                else
                {

                    indexOfLetter = ((indexOfLetter + 23) % 26);
                    char newLetter = alphabet[indexOfLetter];
                    decryptedMessage[i] = newLetter;
                    newMessage = String.Join("", decryptedMessage);
                }
            }

            return newMessage;
        }
    }
}