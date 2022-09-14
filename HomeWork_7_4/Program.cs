using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_7_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Top top = new Top();
            top.DetermineTopPlayersByLevel();
            top.DetermineTopPlayersByStrong();
        }

        class Top
        {
            private List<Player> _players;

            public Top()
            {
                _players = new List<Player>();
                _players.Add(new Player(name: "Olivia", 10, 15));
                _players.Add(new Player(name: "William", 20, 28));
                _players.Add(new Player(name: "James", 5, 10));
                _players.Add(new Player(name: "Henry", 13, 24));
                _players.Add(new Player(name: "Benjamin", 40, 50));
                _players.Add(new Player(name: "Lucas", 30, 34));
                _players.Add(new Player(name: "Noah", 50, 60));
                _players.Add(new Player(name: "Ava", 45, 21));
                _players.Add(new Player(name: "Amelia", 80, 100));
                _players.Add(new Player(name: "Evelyn", 90, 95));
            }
            public void DetermineTopPlayersByLevel()
            {
                int countPlayerInTop = 3;
                Console.WriteLine($"Топ  {countPlayerInTop} игроков по уровню:");
                _players = _players.OrderByDescending(player => player.Level).Take(countPlayerInTop).ToList();
                ShowTop();
            }

            public void DetermineTopPlayersByStrong()
            {
                int countPlayerInTop = 3;
                Console.WriteLine($"Топ {countPlayerInTop} игроков по силе:");
                _players = _players.OrderByDescending(player => player.Power).Take(countPlayerInTop).ToList();
                ShowTop();
            }

            private void ShowTop()
            {
                foreach (Player player in _players)
                {
                    player.ShowInfo();
                }

                Console.ReadLine();
            }

        }
        class Player
        {
            public string Name { get; private set; }
            public int Level { get; private set; }
            public int Power { get; private set; }

            public Player(string name, int level, int power)
            {
                Name = name;
                Level = level;
                Power = power;
            }

            public void ShowInfo() => Console.WriteLine($"{Name} - Уровень: {Level} - Сила: {Power}");
        }
    }
}
