using System;
using System.Collections.Generic;
using System.Text;

namespace CampGameHomework
{
    interface IGameService
    {
        bool Add(Game game);
        void Update(Game game);
        void Delete(Game game);
        bool Result();
    }
}
