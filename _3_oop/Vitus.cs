﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_oop
{
    class Vitus:Drug
    {
        public Vitus()
            : base()
        {

        }
        public Vitus(string _Name, int _Cost, string _State, bool Receipt)
            : base(_Name, _Cost, _State, Receipt)
        {

        }
    }
}
