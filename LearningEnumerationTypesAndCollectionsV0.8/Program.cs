using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningEnumerationTypesAndCollectionsV0._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Card> cards = new List<Card>();
            /*
            {   
                 //code, before optimalization

                new Card() { Type = (Types)random.Next(0,3), Value =(Values)random.Next(1,13)},
                new Card() { Type = (Types)random.Next(0,3), Value =(Values)random.Next(1,13)},
                new Card() { Type = (Types)random.Next(0,3), Value =(Values)random.Next(1,13)},
                new Card() { Type = (Types)random.Next(0,3), Value =(Values)random.Next(1,13)},
                new Card() { Type = (Types)random.Next(0,3), Value =(Values)random.Next(1,13)},
              
            };
              */
            Console.WriteLine("Przed posortowaniem:");
            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Types)random.Next(4), (Values)random.Next(1, 13)));
                Console.WriteLine(cards[i].Name);
            }

            Console.WriteLine("\r\n"+"Po posortowaniu:");
            CardComparer cardComparer = new CardComparer();
            cardComparer.SortBy = SortCriteria.TypeThenValue; // Here we can decide how we want to sor our values.
            cards.Sort(cardComparer);
            foreach(Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
            Console.ReadKey();
        }

    }
}
