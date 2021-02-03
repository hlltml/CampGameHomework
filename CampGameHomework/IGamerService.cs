namespace CampGameHomework
{
    interface IGamerService
    {
        bool Add(IUser gamer);
        void Update(IUser gamer);
        void Delete(IUser gamer);
        bool Result();
    }
}
