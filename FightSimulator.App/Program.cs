using System;
using FightSimulator.Entities;

namespace FightSimulator.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Battle battle = new Battle();
            Warrior manMan = new Warrior("Man-Man", 250, 100, 50);
            Warrior notManMan = new Warrior("Not Man-Man", 250, 100, 50);

            battle.StartBattle(manMan, notManMan);
        }
    }
}
