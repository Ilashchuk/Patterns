using Patterns.CreatedPatterns.AbstractFactory.Movements;
using Patterns.CreatedPatterns.AbstractFactory.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreatedPatterns.AbstractFactory.Factories
{
    internal class ArtilleristFactory : ServicemanFactory
    {
        public override Movement CreateMovement()
        {
            return new DriveMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Howitzer();
        }
    }
}
