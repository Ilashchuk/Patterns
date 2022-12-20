//using Patterns.CreatedPatterns.AbstractFactory.Weapons;
using Patterns.CreatedPatterns.AbstractFactory.Movements;
using Patterns.CreatedPatterns.AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.CreatedPatterns.AbstractFactory.Weapons;

namespace Patterns.CreatedPatterns.AbstractFactory.Factories
{
    internal class SoldierFactory : ServicemanFactory
    {
        public override Movement CreateMovement()
        {
            return new RunMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Automaton();
        }
    }
}
