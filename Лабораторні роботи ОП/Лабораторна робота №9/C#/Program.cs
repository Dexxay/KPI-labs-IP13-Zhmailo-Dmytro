using System;
using System.Collections.Generic;

namespace Lab9_CSharp
{
    class Program
    {
        // Варіант-13, Жмайло Дмитро ІП-13
        static void Main(string[] args)
        {
            string text = InputText();
            
            char first_letter = InputChar("Input first letter: ");
            char last_letter = InputChar("Input last letter: ");
            
            string[] words_array = SplitWords(text);
            List<string> result_list = FindWords(words_array, first_letter, last_letter);
            Console.WriteLine($"All words, that starts with letter \'{first_letter}\' and finishes with letter \'{last_letter}\': ");
            DisplayList(result_list);
        }

        static string InputText() // Функція для введення тексту користувачем
        {
            Console.Write("Input your sentence: ");
            string input = Console.ReadLine();
            string sentence = input;
            return sentence;
        }
        
        static char InputChar(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine();
            return Convert.ToChar(input);
        }
            

        static string[] SplitWords (string sentence) // Функція для розділення речення на окремі слова
        {
            string[] separated_words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return separated_words;
        }

        static List<string> FindWords(string [] words_arr, char first, char last) // Функція для пошуку слів за заданими літерами
        {
            List<string> words_list = new List<string>();
            string temp_word;
            int temp_first, temp_last, temp_last_number;
            int length = words_arr.Length;
            for (int i = 0; i < length; i++)
            {
                temp_word = words_arr[i];
                temp_last_number = temp_word.Length - 1;
                temp_first = temp_word[0];
                temp_last = temp_word[temp_last_number];
                if ((temp_first == first) && (temp_last == last))
                {
                    words_list.Add(temp_word);
                }
            }
            return words_list;
        }
        
        static void DisplayList( List <string> words_list) // Функція для виведення елементів списку в консоль 
        {
            for (int i = 0; i < words_list.Count; i++)
            {
                Console.Write(words_list[i] + "\t");
            }
        }

    }
}
