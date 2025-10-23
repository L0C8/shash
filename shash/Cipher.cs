using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace shash
{
    class Cipher
    {
        private static readonly UTF8Encoding utf8Encoding = new UTF8Encoding(false);

        public string EncryptCBC(string plainText, byte[] key)
        {
            // Generate IV like Python os.urandom(16)
            byte[] iv = RandomizeBytes(16);
            // Create AES cipher in CBC mode
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;
                aes.IV = iv;

                // Encrypt using CBC mode
                using (var encryptor = aes.CreateEncryptor())
                {
                    // Convert to bytes using UTF-8 like Python
                    byte[] plainBytes = utf8Encoding.GetBytes(plainText);
                    byte[] ciphertext = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);

                    // Concatenate IV + ciphertext like Python
                    byte[] result = new byte[iv.Length + ciphertext.Length];
                    Buffer.BlockCopy(iv, 0, result, 0, iv.Length);
                    Buffer.BlockCopy(ciphertext, 0, result, iv.Length, ciphertext.Length);

                    // Return base64 like Python b64encode().decode()
                    return Convert.ToBase64String(result);
                }
            }
        }

        public string encrypt(string plainText, string passPhrase)
        {
            if (string.IsNullOrEmpty(passPhrase))
            {
                // Use CBC mode with random key when no password
                byte[] key = RandomizeBytes(16);
                return EncryptCBC(plainText, key);
            }
            else
            {
                // Use ECB mode with password-derived key
                return EncryptECB(plainText, passPhrase);
            }
        }

        public string DecryptCBC(string encryptedText, byte[] key)
        {
            // Decode base64 like Python b64decode()
            byte[] encryptedData = Convert.FromBase64String(encryptedText);

            // Extract IV and ciphertext like Python code
            byte[] iv = new byte[16];
            byte[] ciphertext = new byte[encryptedData.Length - 16];
            Buffer.BlockCopy(encryptedData, 0, iv, 0, 16);
            Buffer.BlockCopy(encryptedData, 16, ciphertext, 0, ciphertext.Length);

            // Create AES cipher in CBC mode
            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;
                aes.IV = iv;

                // Decrypt using CBC mode
                using (var decryptor = aes.CreateDecryptor())
                {
                    byte[] decrypted = decryptor.TransformFinalBlock(ciphertext, 0, ciphertext.Length);
                    return utf8Encoding.GetString(decrypted);
                }
            }
        }

        public string DecryptECB(string encryptedText, string password)
        {
            // Derive key using SHA1 like Python
            byte[] key = SetKey(password);
            byte[] encryptedData = Convert.FromBase64String(encryptedText);

            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;

                using (var decryptor = aes.CreateDecryptor())
                {
                    byte[] decrypted = decryptor.TransformFinalBlock(encryptedData, 0, encryptedData.Length);
                    return utf8Encoding.GetString(decrypted);
                }
            }
        }

        public string decrypt(string cipherText, string passPhrase)
        {
            if (string.IsNullOrEmpty(passPhrase))
            {
                // Use CBC mode with random key when no password
                byte[] key = RandomizeBytes(16);
                return DecryptCBC(cipherText, key);
            }
            else
            {
                // Use ECB mode with password-derived key
                return DecryptECB(cipherText, passPhrase);
            }
        }

        public string EncryptECB(string plainText, string password)
        {
            // Derive key using SHA1 like Python
            byte[] key = SetKey(password);

            using (var aes = Aes.Create())
            {
                aes.Mode = CipherMode.ECB;
                aes.Padding = PaddingMode.PKCS7;
                aes.Key = key;

                // Encrypt using ECB mode (no IV needed)
                using (var encryptor = aes.CreateEncryptor())
                {
                    byte[] plainBytes = utf8Encoding.GetBytes(plainText);
                    byte[] ciphertext = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
                    return Convert.ToBase64String(ciphertext);
                }
            }
        }

        // Match Python's set_key function using SHA1
        private static byte[] SetKey(string password)
        {
            using (var sha1 = SHA1.Create())
            {
                byte[] passwordBytes = utf8Encoding.GetBytes(password);
                byte[] hash = sha1.ComputeHash(passwordBytes);
                // Take first 16 bytes like Python [:16]
                byte[] key = new byte[16];
                Buffer.BlockCopy(hash, 0, key, 0, 16);
                return key;
            }
        }

        private static byte[] RandomizeBytes(int length)
        {
            var randomBytes = new byte[length];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomBytes);
            }
            return randomBytes;
        }



    }
}
