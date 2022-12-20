using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.CreatedPatterns.AbstractFactory;
using Patterns.CreatedPatterns.AbstractFactory.Factories;

namespace Patterns.CreatedPatterns.AbstractFactory
{
    static class Attak
    {
        public static void Offensive()
        {
            Serviceman soldier = new Serviceman(new SoldierFactory());
            Serviceman artillerist = new Serviceman(new ArtilleristFactory());
            Serviceman pilot = new Serviceman(new PilotFactory());


            artillerist.Hit();
            artillerist.ChangePosition();
            artillerist.Hit();
            artillerist.ChangePosition();
            artillerist.Hit();
            pilot.Hit();
            soldier.ChangePosition();
            soldier.Hit();
            pilot.ChangePosition();
            artillerist.ChangePosition();
            soldier.ChangePosition();

            Console.WriteLine("Successful attack!!!");
            Console.WriteLine("New positions have been taken!!!");
        }
    }
}
