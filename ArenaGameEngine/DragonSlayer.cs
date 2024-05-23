using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class DragonSlayer : Hero
    {
        public DragonSlayer() : this("Garuda") //set cool name("Garuda")
        {

        }

        public DragonSlayer(string name) : base(name)
        {
        
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            // Let's say DragonSlayer has a 50% chance to deal quadruple damage(I want him to be the strongest heh)
            if (Random.Shared.Next(0, 100) < 50)
            {
                Console.WriteLine($"{Name} strikes with unmatched power!");
                baseAttack *= 4;
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            // Let's say DragonSlayer has 50% armor which reduces incoming damage
            int reducedDamage = incomingDamage - (int)(incomingDamage * 0.5);
            base.TakeDamage(reducedDamage);
        }
    }
}
