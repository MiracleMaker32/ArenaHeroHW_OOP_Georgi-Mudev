using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGameEngine
{
    public class Priest : Hero
    {
        public Priest() : this("Rudolph") // Cool name 'Rudolph'
        {

        }

        public Priest(string name) : base(name) 
        {
        }

        public override int Attack()
        {
            int baseAttack = base.Attack();
            // Implement attack logic with a chance to summon minions
            if (Random.Shared.Next(0, 100) < 40)
            {
                Console.WriteLine($"{Name} summons a minion to aid in the attack!");
                baseAttack += 20; // Increase attack by 20
            }
            return baseAttack;
        }

        public override void TakeDamage(int incomingDamage)
        {
            // Implement damage-taking logic with a chance to deal thorns damage
            // Example: Deal thorns damage with a probability of 50%
            if (Random.Shared.Next(0, 100) < 50)
            {
                int thornsDamage = incomingDamage / 2; // Deal half of the incoming damage as thorns damage
                Console.WriteLine($"{Name} retaliates with thorns damage!");
                base.TakeDamage(thornsDamage); // Apply thorns damage to the attacker
            }
            else
            {
                base.TakeDamage(incomingDamage); 
            }
        }
    }
}
