namespace CampGameHomework
{
    interface ISalesService
    {
        void Sell(IUser gamer, Game game,Campaign campaign, ICampaignService campaignManager,IGamerService gamerManager, IGameService gameManager);
        void Sell(IUser gamer, Game game,IGamerService gamerManager, IGameService gameManager);
    }
}
