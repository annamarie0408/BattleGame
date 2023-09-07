using System;
using System.Collections.Generic;
using System.Text;

namespace BattleGame
{
    class _Battle
    {
        public static void _StartFight(_Warrior warrior1, _Warrior warrior2)
        {
            //Warrior1 
            //Warrior2
            while (true)
            {
                if (_GetAttackResults(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (_GetAttackResults(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
            }
            
        }

        public static string _GetAttackResults(_Warrior warriorA, _Warrior warriorB)
        {
            double _warrior1AttAmt = warriorA.Attack();
            double _warrior2BlkAmt = warriorB.Block();
            double dmg2WarB = _warrior1AttAmt - _warrior2BlkAmt;
          


            if (dmg2WarB > 0)
            {
                warriorB._Health = warriorB._Health - (int)dmg2WarB;
            }
            else dmg2WarB = 0;
           Console.WriteLine("{0} Attacks {1} and deals {2} Damage, {3} blocks with {4}, total damage taken {5}", warriorA._Name, warriorB._Name, _warrior1AttAmt, warriorB._Name, _warrior2BlkAmt, dmg2WarB);
          
            Console.WriteLine("{0} has {1} health", warriorB._Name, warriorB._Health);

            if (warriorB._Health <= 0 )
            {
                Console.WriteLine("{0} has died and {1} is victorious", warriorB._Name, warriorA._Name);
                return "Game Over";
            }
            
            else
            {
                return "Fight Again";
            }

        }


        }
    }

