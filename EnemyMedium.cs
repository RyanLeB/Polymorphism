using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class EnemyMedium : Enemy
    {
        public override void Update()
        {
            Console.WriteLine("EnemyMedium updated");
        }

    }
}
