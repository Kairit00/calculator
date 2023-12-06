using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIK299_Grupp3_Projekt
{
    class Option
    {
        public string Name { get; }
        public Action Action { get; }

        public Option(string name, Action action)
        {
            Name = name;
            Action = action;
        }
    }

}
