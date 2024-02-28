using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class EnemyLarge : Enemy
    {
        public override void Update()
        {
            Console.WriteLine("EnemyLarge updated");
        }

    }
}
