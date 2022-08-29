using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Superheltene
{
    internal class Villain
    {
        private string description;
        public string Description
        {
            get { return description; }
            private set
            {
                description = value;
            }
        }

        public Villain(string description)
        {
            Description = description;
        }
    }
}
