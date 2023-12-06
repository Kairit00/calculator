using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIK299_Grupp3_Projekt
{
    class Menu
    {
        private Option[] options;
        private int length;

        public Menu()
        {
            options = new Option[10];
            length = 0;
        }

        public void AddOption(string name, Action action)
        {
            Option option = new Option(name, action);
            options[length] = option;
            length++;
        }

        public void Start()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine();
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine($"{i + 1}: {options[i].Name}");
                }

                string input = Console.ReadLine();
                int selection;
                if (int.TryParse(input, out selection) && selection > 0 && selection <= length)
                {
                    options[selection - 1].Action();
                }
                else
                {
                    Console.WriteLine("Inkorrekt svar, försök igen: ");
                }
            }
        }
    }
}

