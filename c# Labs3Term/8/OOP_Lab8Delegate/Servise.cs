using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab8Delegate
{
    internal class Servise
    {
        public class Game
        {
            public event Action<int> Attack;
            public event Action<int> Heal;

            public void TriggerAttack(int damage)
            {
                Attack?.Invoke(damage);
            }

            public void TriggerHeal(int healing)
            {
                Heal?.Invoke(healing);
            }
        }

        public class GameObject
        {
            public string Name { get; }
            public int Health { get; private set; }

            public GameObject(string name, int health)
            {
                Name = name;
                Health = health;
            }

            public void HandleAttack(int damage)
            {
                Console.WriteLine($"{Name} is attacked for {damage} damage.");
                Health -= damage;
            }

            public void HandleHeal(int healing)
            {
                Console.WriteLine($"{Name} is healed for {healing} points.");
                Health += healing;
            }
        }
    }
}
