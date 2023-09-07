using System;

namespace BattleGame
{
    public class _mainProgram
    {
        static void Main(string[] args)
        {
            _Warrior Anna = new _Warrior("Anna", 100, 12, 9);
            _Warrior David = new _Warrior("David", 100, 12, 9);

            _Battle._StartFight(Anna, David);
            Console.ReadLine();
        }
    }
}
