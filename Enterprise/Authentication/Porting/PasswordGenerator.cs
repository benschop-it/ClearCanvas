using System;
using System.Linq;
using System.Security.Cryptography;

namespace ClearCanvas.Enterprise.Authentication.Porting {

    public class PasswordGenerator {
        private static readonly char[] _passwordChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
        private static readonly char[] _nonAlphanumericChars = "!@#$%^&*()_-+=<>?".ToCharArray();

        public static string GeneratePassword(int length, int numberOfNonAlphanumericCharacters) {
            if (length < 1 || numberOfNonAlphanumericCharacters > length) {
                throw new ArgumentException("Invalid password length or number of non-alphanumeric characters.");
            }

            using (var rng = new RNGCryptoServiceProvider()) {
                var passwordChars = new char[length];

                // Fill the password array with random alphanumeric characters
                for (int i = 0; i < length - numberOfNonAlphanumericCharacters; i++) {
                    passwordChars[i] = _passwordChars[GetRandomInt(rng, _passwordChars.Length)];
                }

                // Fill the remaining positions with random non-alphanumeric characters
                for (int i = length - numberOfNonAlphanumericCharacters; i < length; i++) {
                    passwordChars[i] = _nonAlphanumericChars[GetRandomInt(rng, _nonAlphanumericChars.Length)];
                }

                // Shuffle the characters in the password array to ensure random distribution
                return new string(passwordChars.OrderBy(x => GetRandomInt(rng, length)).ToArray());
            }
        }

        private static long GetRandomInt(RNGCryptoServiceProvider rng, int max) {
            var randomNumber = new byte[4];
            rng.GetBytes(randomNumber);
            return BitConverter.ToUInt32(randomNumber, 0) % max;
        }
    }
}
