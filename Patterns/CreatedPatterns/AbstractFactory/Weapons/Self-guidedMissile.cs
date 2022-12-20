using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreatedPatterns.AbstractFactory.Weapons
{
    internal class Self_guidedMissile : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Launches self-guided missiles!!!");
        }
    }
}
