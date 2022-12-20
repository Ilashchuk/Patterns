using Patterns.CreatedPatterns.AbstractFactory.Factories;
using Patterns.CreatedPatterns.AbstractFactory.Movements;
using Patterns.CreatedPatterns.AbstractFactory.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.CreatedPatterns.AbstractFactory
{
    internal class Serviceman
    {
        private Weapon weapon;
        private Movement movement;
        public Serviceman(ServicemanFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }
        public void ChangePosition()
        {
            movement.Move();
        }
        public void Hit()
        {
            weapon.Hit();
        }
    }
}
