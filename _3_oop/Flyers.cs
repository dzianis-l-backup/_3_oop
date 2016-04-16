﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    abstract class Flyers:Animal
    {
        public bool IsBird{ get; set; }
        public int WingsQuantity { get; set; }
        public Flyers(string _Name,int _Age, bool _IsHealthy,int  _WingsQuantity, bool _IsBird)
            : base(_Name,_Age, _IsHealthy)
        {
            Name = _Name;
            WingsQuantity = _WingsQuantity;
            IsBird = _IsBird;
        }
        public override string Move()
        {
            return "I'm flying yeah!";
        }
        public string SayIsBird()
        {
            if (IsBird)
            {
                return "Bird!";
            }
            else return "Notabird!";
        }       
        public virtual string Fly()
        {
            return "I cannot I do not know how to!";
        }
    }
}
