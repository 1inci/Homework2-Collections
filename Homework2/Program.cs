using System;
using System.Collections;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Question 1: Prime numbers.");
            Console.WriteLine("Question 3: Vowels");
            Console.WriteLine("Question 2: Average");
            
            int caseNum;
            Console.WriteLine("Please enter a case number including 1 and 3");
            caseNum = Convert.ToInt32(Console.ReadLine());


            ArrayList tempList = new ArrayList();
            ArrayList primeList = new ArrayList();
            ArrayList notPrimeList = new ArrayList();


            switch (caseNum)
            {
                case 1:
                    System.Console.WriteLine("Please enter 20 positive integers.");

                    try
                    {

                        for (int i = 0; i < 20; i++)
                        {
                            System.Console.WriteLine("Please enter {0}. number ", i + 1);
                            int number = int.Parse(Console.ReadLine());
                            if (number < 0)
                            {
                                Console.WriteLine("Lütfen pozitif bir sayı giriniz");
                                break;
                            }

                            else
                            {
                                tempList.Add(int.Parse(Console.ReadLine()));
                            }

                        }

                    }

                    catch (Exception)
                    {
                        Console.WriteLine("Please enter positive integer(s).");
                    }



                    foreach (int item in tempList)
                    {
                        if (item == 1)
                        {
                            notPrimeList.Add(item);
                        }
                        else if (item == 2)
                        {
                            primeList.Add(item);
                        }
                        else
                        {
                            int prime = 0;
                            for (int i = 2; i < item; i++)
                            {
                                if (item % i == 0)
                                {
                                    prime++;

                                }
                            }

                            if (prime == 0)
                            {
                                primeList.Add(item);
                            }
                            else
                            {
                                notPrimeList.Add(item);
                            }
                        }

                        double sumOfPrimeList = 0;
                        double sumOfNotPrimeList = 0;

                        Console.WriteLine("Prime List count: " + primeList.Count);
                        Console.WriteLine("PrimeList descending order: ");
                        primeList.Sort();
                        primeList.Reverse();

                        foreach(int primeNum in primeList)
                        {
                            Console.WriteLine(primeNum);
                            sumOfPrimeList += primeNum;
                        }

                        Console.WriteLine("Average Prime List" + sumOfPrimeList/ primeList.Count);

                        Console.WriteLine("Not Prime List Count" + notPrimeList.Count);
                        Console.WriteLine("PrimeList descending order: ");
                        notPrimeList.Sort();
                        notPrimeList.Reverse();
                       
                        foreach (int NotPrimeNum in notPrimeList)
                        {
                            Console.WriteLine(NotPrimeNum);
                            sumOfNotPrimeList += NotPrimeNum;
                        }

                        Console.WriteLine("Average Not Prime List" + sumOfNotPrimeList / notPrimeList.Count);

                    }

                    break;

                case 2:

                    Console.WriteLine("Please enter a sentence: ");
                    string sentence = Console.ReadLine();
                    ArrayList vowelsList = new ArrayList();
                    char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };

                    char[] letters = new char[sentence.Length];
                    letters = sentence.ToCharArray();

                    foreach (char letter in letters)
                    {
                        foreach (char sabit in vowels)
                        {
                            if (letter == sabit)
                                vowelsList.Add(sabit);
                        }
                    }
                    foreach (var item in vowelsList)
                    {
                        Console.Write(item + " ");
                    }

                    break;

                case 3:
                    break;

                default:
                    Console.WriteLine("***************************************************************************");
                    break;

            }
        }

    }
}