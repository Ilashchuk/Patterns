using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreatedPatterns.AbstractFactory.Weapons
{
    internal class Howitzer : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Fires from a howitzer!!!");
        }
    }
}
