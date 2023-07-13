using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLader
{
    internal class Snake
    {

        //uc1
        int position = 0;
        Random random = new Random();

        //uc2
        public void DieRoll()
        {
            int diePosition = random.Next(1, 7);
            Console.WriteLine("Die POsition is" + diePosition);
        }


    }
}

       