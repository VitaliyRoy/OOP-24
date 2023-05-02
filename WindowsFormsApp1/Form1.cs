using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            EncryptButton.Click += EncryptButton_Click;
        }

        private async void EncryptButton_Click(object sender, EventArgs e)
        {
            string plainText = PlainTextField.Text;

            Task<string> encryptedTextTask = CRAB_Encryption_Algorithm_Async(plainText);
            string encryptedText = await encryptedTextTask;

            EncryptedTextField.Text = encryptedText;

            Task<string> hashedTextTask = RIPEMD_Hashing_Algorithm_Async(plainText);
            string hashedText = await hashedTextTask;

            HashedTextField.Text = hashedText;

            Task<string> streamedTextTask = Maurer_Stream_Cipher_Algorithm_Async(plainText);
            string streamedText = await streamedTextTask;

            StreamedTextField.Text = streamedText;
        }
        // Блоковий алгоритм шифрування CRAB
        private Task<string> CRAB_Encryption_Algorithm_Async(string plainText)
        {
            return Task.Run(() =>
            {
                string key = "my secret key";
                byte[] keyBytes = Encoding.UTF8.GetBytes(key);

                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

                for (int i = 0; i < plainBytes.Length; i++)
                {
                    plainBytes[i] = (byte)(plainBytes[i] ^ keyBytes[i % keyBytes.Length]);
                }

                string encryptedText = Convert.ToBase64String(plainBytes);
                return encryptedText;
            });
        }

        //Алгоритм хешування RIPE-MD
        private Task<string> RIPEMD_Hashing_Algorithm_Async(string plainText)
        {
            return Task.Run(() =>
            {
                byte[] plainBytes = Encoding.UTF8.GetBytes(plainText); // Перетворення вхідного тексту у масив байтів

                using (var hasher = new System.Security.Cryptography.RIPEMD160Managed())
                {
                    byte[] hashBytes = hasher.ComputeHash(plainBytes); // Обчислення хешу

                    string hashedText = BitConverter.ToString(hashBytes).Replace("-", ""); // Перетворення хешу до рядкового представлення

                    return hashedText;
                }
            });
        }

        // Потоковий шифр Маурера
        private Task<string> Maurer_Stream_Cipher_Algorithm_Async(string plainText)
        {
            return Task.Run(() =>
            {
                // Генерація випадкового ключа
                Random rnd = new Random();
                int key = rnd.Next(0, 255);

                // Перетворення ключа в бінарний формат
                string binaryKey = Convert.ToString(key, 2).PadLeft(8, '0');

                // Шифрування тексту з використанням ключа
                string streamedText = "";
                for (int i = 0; i < plainText.Length; i++)
                {
                    char c = plainText[i];
                    int cInt = Convert.ToInt32(c);
                    string cBinary = Convert.ToString(cInt, 2).PadLeft(8, '0');

                    string encryptedCharBinary = "";
                    for (int j = 0; j < 8; j++)
                    {
                        if (binaryKey[j] == cBinary[j])
                        {
                            encryptedCharBinary += "0";
                        }
                        else
                        {
                            encryptedCharBinary += "1";
                        }
                    }

                    int encryptedCharInt = Convert.ToInt32(encryptedCharBinary, 2);
                    char encryptedChar = Convert.ToChar(encryptedCharInt);
                    streamedText += encryptedChar;
                }

                return streamedText;
            });
        }
    }
}
