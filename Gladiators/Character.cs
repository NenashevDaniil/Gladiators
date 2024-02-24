using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gladiators
{
    class Character
    {
        int _health;
        public int Health
        {
        get
            {
                return _health;
            }
          set
            {
                _health = value;

            }


        }
        int _damage;
        int _armor;
        public Character()
        {
            _armor = 20;
           
            _damage = 50;

        }
        public void Attack()
        {
            _health = _health-(_damage - _armor);
        }
        public void HP()
        {
            Console.WriteLine($"Здоровье персонажа равно {Health}");
                }
    }
}
