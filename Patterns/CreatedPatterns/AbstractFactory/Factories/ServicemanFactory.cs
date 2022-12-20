using Patterns.CreatedPatterns.AbstractFactory.Movements;
using Patterns.CreatedPatterns.AbstractFactory.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreatedPatterns.AbstractFactory.Factories
{
    internal abstract class ServicemanFactory
    {
        public abstract Movement CreateMovement();
        public abstract Weapon CreateWeapon();
    }
}
