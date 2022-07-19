using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        
            Console.WriteLine("Please enter your secret message: ");
            String userInput = Console.ReadLine();
            char[] secretMessage = userInput.ToCharArray();
            char[] encryptedMessage = char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i ++) {
                char character = secretMessage[i];
                int characterIndex = Array.IndexOf(alphabet, character);
                int encryptedCharacterIndex = characterIndex + 3;
                char encryptedCharacter = alphabet[encryptedCharacterIndex];
                encryptedMessage[i] = encryptedCharacter;
            }
        }
    }
}