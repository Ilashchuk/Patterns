using Patterns.CreatedPatterns.AbstractFactory.Movements;
using Patterns.CreatedPatterns.AbstractFactory.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreatedPatterns.AbstractFactory.Factories
{
    internal class PilotFactory : ServicemanFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Self_guidedMissile();
        }
    }
}
