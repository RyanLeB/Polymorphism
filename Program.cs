using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Polymorphism");
            Console.WriteLine("------------------");
            Console.WriteLine();
            // Enemy enemy = new Enemy(); fails because abstraction

            // Enemy Manager

            // decleration
            //EnemySmall[] enemySmall = new EnemySmall[100];
            //EnemyMedium[] enemyMedium = new EnemyMedium[50];
            //EnemyLarge[] enemyLarge = new EnemyLarge[10];

            Enemy[] enemies = new Enemy[100+50+10];

            // instantiation
            //for (int i = 0; i < 100; i++)
            //{
            //    enemies[i] = new EnemySmall();
            //}

            //for (int i = 0; i < 50; i++)
            //{
            //    enemies[i] = new EnemyMedium();
            //}

            //for (int i = 0; i < 10; i++)
            //{
            //    enemies[i] = new EnemyLarge();
            //}


            //for (int i = 0; i < enemies.Length; i++)
            //{
            //    enemies[i].Update();
            //}

            //for (int i = 0; i < enemyMedium.Length; i++)
            //{
            //    enemyMedium[i].Update();
            //}

            //for (int i = 0; i < enemyLarge.Length; i++)
            //{
            //    enemyLarge[i].Update();
            //}
            
            for (int i = 0; i < enemies.Length; i++)
            {
                
                // 0...99
                if (i < 100)
                {
                    enemies[i] = new EnemySmall(); // polymorphism
                    continue;
                }
                
                // 100...149
                if (i < 100 + 50)
                {
                    enemies[i] = new EnemyMedium();
                    continue;
                }


                // 150...159
                enemies[i] = new EnemyLarge();
                
            }

            for (int i = 0;i < enemies.Length; i++)
            {
                enemies[i].Update();
            }


            // Enemy Manager update
            //enemySmall[100].Update();
            //enemyMedium[50].Update();
            //enemyLarge[10].Update();


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        
        }
    }
}
