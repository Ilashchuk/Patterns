﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreatedPatterns.AbstractFactory.Movements
{
    internal class DriveMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Drive");
        }
    }
}
