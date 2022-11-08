using System;
using System.Collections.Generic;
using System.Linq;


namespace DeckOfCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cards = Console.ReadLine()
                .Split(", ")
                .ToList();
            int numOfCards = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfCards; i++)
            {
                string[] command = Console.ReadLine()
                .Split(", ");
                string cmdArgs = command[0];
                    
                if (cmdArgs == "Add")
                {
                    string cardType = command[1];
                        
                    if (cards.Contains(cardType))
                    {
                        Console.WriteLine("Card is already in the deck");
                        continue;
                    }

                    cards.Add(cardType);
                    Console.WriteLine("Card successfully added");
                }
                else if (cmdArgs == "Remove")
                {
                    string cardType = command[1];

                    if(cards.Contains(cardType))
                    {
                        cards.Remove(cardType);
                        Console.WriteLine("Card successfully removed");
                        continue;
                    }
                    
                      Console.WriteLine("Card not found");                   
                }
                else if (cmdArgs == "Remove At")
                {
                    int indexOfCard = int.Parse(command[1]);

                    if (indexOfCard > cards.Count || indexOfCard < 0)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }

                    cards.RemoveAt(indexOfCard);
                    Console.WriteLine("Card successfully removed");
                }
                else if (cmdArgs == "Insert")
                {
                    int indexOfCard = int.Parse(command[1]);
                    string cardType = command[2];

                    if (indexOfCard > cards.Count || indexOfCard < 0)
                    {
                        Console.WriteLine("Index out of range");
                        continue;
                    }

                    if (cards.Contains(cardType))
                    {
                        Console.WriteLine("Card is already added");
                        continue;
                    }

                        cards.Insert(indexOfCard, cardType);
                    Console.WriteLine("Card successfully added");
                }
            }

            Console.WriteLine(string.Join(",", cards));
        }
    }
}
