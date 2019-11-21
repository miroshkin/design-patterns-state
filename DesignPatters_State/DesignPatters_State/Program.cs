using System;
using System.Dynamic;

namespace DesignPatters_State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design Patterns - State!");

            Wife wife = new Wife();
            wife.TakeMoney();
            wife.SeeMeDrinkingBeer();
            wife.SeeMeDrinkingBeer();
            wife.SeeMeDrinkingBeer();
            wife.SeeMeDrinkingBeer();
        }
    }

    public class Wife
    {
        public WifeState State { get; set; }
        public int BottlesCounter { get; set; }

        public void TakeMoney()
        {
            State = WifeState.Happy;
            Console.WriteLine(State);
        }

        public void SeeMeDrinkingBeer()
        {
            BottlesCounter += 1;

            if (BottlesCounter > 3)
            {
                State = WifeState.Angry;
            }
            else
            {
                State = WifeState.Neutral;
            }

            Console.WriteLine(State);
        }

    }

    public enum WifeState
    {
        Happy,
        Neutral,
        Angry
    }
}
