﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonAidStand
{
    class Player
    {
        public double money = 20;
        public double lemonCount = 0;
        public double sugarCount = 0;
        public double iceCount = 0;
        public double cupCount = 0;
        public double glassPrice;


        public Player()
        {

        }

        public double getGlassPrice()

        {

            Console.WriteLine("How much do you want to charge for a glass?");
            glassPrice = double.Parse(Console.ReadLine());
            
            return glassPrice;


        }
    }
}







