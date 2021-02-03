using System;
using System.Globalization;

namespace CampGameHomework
{
    class GameManager : IGameService
    {
        bool result = false;
        public bool Add(Game game)
        {
            Console.WriteLine(game.GameName + " eklendi");
            return result = true;
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + " silindi");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + " güncellendi");
        }

        public bool Result()
        {
            return result;
        }
    }
}
