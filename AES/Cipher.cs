using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;


namespace AES
{
    internal class Cipher
    {
        public string Encrypt(string plainText, string key, CipherMode cipherMode)
        {
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            //
            Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes, 1000);
            byte[] newKeyBytes = derivedKey.GetBytes(16);
            byte[] ivBytes = derivedKey.GetBytes(16);

            //
            Aes encryption = Aes.Create();
            encryption.Mode = cipherMode;
            encryption.Key= newKeyBytes;
            encryption.IV = newKeyBytes;

            byte[] encryptedBytes;

            //
            using (ICryptoTransform encryptor = encryption.CreateEncryptor())
            {
                encryptedBytes = encryptor.TransformFinalBlock(plainBytes, 0, plainBytes.Length);
            }

            return Convert.ToBase64String(encryptedBytes);
        }

        public string Decrypt(string encryptedText, string key, CipherMode cipherMode)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            byte[] keyBytes = Encoding.UTF8.GetBytes(key);

            Rfc2898DeriveBytes derivedKey = new Rfc2898DeriveBytes(key, keyBytes, 1000);
            byte[] newKeyBytes = derivedKey.GetBytes(16);
            byte[] ivBytes = derivedKey.GetBytes(16);

            Aes decryption = Aes.Create();
            decryption.Mode = cipherMode;
            decryption.Key = newKeyBytes;
            decryption.IV = newKeyBytes;

            byte[] plainBytes;

            using (ICryptoTransform decryptor = decryption.CreateDecryptor())
            {
                plainBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
            }

            return Encoding.UTF8.GetString(plainBytes);
        }

        public void SaveToFile(string encryptedText, string filePath) 
        {
            File.WriteAllText(filePath, encryptedText);
        }

        public string DecryptFromFile(string filePath, string key, CipherMode cipherMode)
        {
            string encryptedText = File.ReadAllText(filePath);
            return Decrypt(encryptedText, key, cipherMode);
        }
    }
}
