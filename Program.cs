using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
        
            Console.WriteLine("Please enter your secret message: ");
            String userInput = Console.ReadLine().ToLower();
            char[] secretMessage = userInput.ToCharArray();
            char[] encryptedMessage = new char[secretMessage.Length];

            // Encrypting message characters
            for (int i = 0; i < secretMessage.Length; i ++) {
                char character = secretMessage[i];
                int characterIndex = Array.IndexOf(alphabet, character);
                if (characterIndex == -1) {
                    encryptedMessage[i] = character;
                } else {
                    int encryptedCharacterIndex = (characterIndex + 3) % 26;
                char encryptedCharacter = alphabet[encryptedCharacterIndex];
                encryptedMessage[i] = encryptedCharacter;
                }
                
            }

            String encryptedMessageString = String.Join("", encryptedMessage);
            Console.WriteLine($"Here is your encrypted message: {encryptedMessageString}");

        }
    }
}