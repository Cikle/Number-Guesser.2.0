using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser2._0
{
    internal class GenerateNumber
    {
        public int secretNumber { get; private set; }
        public void Secret()
        {
            Random random = new Random();
            secretNumber = random.Next(1, 101);
        }
    }
}
