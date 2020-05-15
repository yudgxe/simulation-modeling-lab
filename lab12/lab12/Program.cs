using System;
using System.Collections.Generic;

namespace lab11
{
    public class Team
    {
        public string name;
        public bool inGame { get; set; }

        public Team(string name)
        {
            this.name = name;
            inGame = true;
        }

        public void Lose()
        {
            inGame = false;
        }

    }
    class Game
    {
        const double inten = 2;
        List<Team> teams = new List<Team>();

        void generateTeam(int count)
        {
            for (int i = 0; i < count; i++)
            {
                teams.Add(new Team("Team" + (i + 1).ToString()));
            }
        }
        int rndScore()
        {
            double M, S, alfa;
            Random rnd = new Random();
            M = S = 0;
            do
            {
                alfa = rnd.NextDouble();
                S += Math.Log(alfa);
                M++;
            } while (S >= -inten);

            return (int)M;
        }

        void deleteLose()
        {
            for (int i = 0; i < teams.Count; i++) 
            {
                if (!teams[i].inGame)
                {
                    teams.RemoveAt(i);
                    i = 0;
                }

            }
        }

        public void Start(int count)
        {
            generateTeam(count);
            Play();
        }
        private void Play()
        {
            Print();
            Console.WriteLine($"Кол-во команд {teams.Count}");
            Console.WriteLine("Нажмите чтобы сыграть матчи\n");
            Console.ReadKey();
            for (int i = 0; i < teams.Count; i++) 
            {
                if((i + 1) % 2 == 0)
                {
                    int firstScore = rndScore();
                    int secondeScore = rndScore();

                    Console.WriteLine($"{teams[i - 1].name} - {firstScore} : {secondeScore} - {teams[i].name}");


                    if (firstScore >= secondeScore)
                        teams[i].Lose();
                    else
                        teams[i - 1].Lose();
                }
            }

            deleteLose();
            if (teams.Count == 1)
            {
                Console.WriteLine($"Победила команда {teams[0].name}");
                return;
            }
            Play();
        }

        public void Print()
        {
            Console.WriteLine("\nКоманды");
            Console.WriteLine("-------------------");
            for (int i = 0;i < teams.Count;i++)
            {
                Console.WriteLine($"{teams[i].name}");
                if ((i + 1) % 2 == 0) Console.WriteLine("-------------------");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            game.Start(16);

            Console.ReadKey();
        }
    }
}
