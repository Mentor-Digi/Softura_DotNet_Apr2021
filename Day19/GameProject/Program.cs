using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        //Get word from user
        //Calculate Cows and Bulls
        //Check if user is successful
        //Print Result
        string givenWord;
        List<Word> words = new List<Word>();
        public Program()
        {
            givenWord = "teal";
        }
        void GetWord()
        {
            Word word = new Word();
            Console.WriteLine("Please enter your guess word");
            word.UserWord = Console.ReadLine().ToLower();
            words.Add(word);
        }

        //teal and yarn
        void CalculateCowAndBull()
        {
            int idx = words.Count-1;
            string strWord = words[idx].UserWord;
            for (int i = 0; i < strWord.Length; i++)//4
            {
                for (int j = 0; j < strWord.Length; j++)//4
                {
                    if (strWord[i] == givenWord[j])//i=0,j=0y==t,j=1y==e,j=2y==a,j=3y==l/i=1,j=0a==t,j=1a==e,j=2a==a
                        if (i == j)
                            words[idx].Cows += 1;
                        else
                            words[idx].Bulls += 1;
                }
            }
        }
        void CheckAndUpdateSuccess()
        {
            int idx = words.Count - 1;
            if (givenWord.Length == words[idx].Cows)
                words[idx].IsSuccess = true;
            else
                words[idx].IsSuccess = false;
        }
        void PayGame()
        {
            Console.WriteLine("You have a {0} letter for guessing",givenWord.Length);
            do
            {
                GetWord();
                CalculateCowAndBull();
                CheckAndUpdateSuccess();
                Console.WriteLine(words[words.Count - 1]);
            } while (!words[words.Count-1].IsSuccess);
            Console.WriteLine("--------------------------");
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            new Program().PayGame();
            Console.ReadLine();
        }
    }
}
