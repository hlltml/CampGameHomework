namespace CampGameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser gamer = new Gamer {Id=1, FirstName = "Halil".ToUpper() , LastName="Temel".ToUpper(), BirthYear=1991, NationalityId=12345678910 };
            IGamerService gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);

            Game game = new Game { Id = 1, GameName = "Call Of Duty 2", GamePrice = 25 };
            IGameService gameManager = new GameManager();
            gameManager.Add(game);

            Campaign campaign = new Campaign { Id = 1, CampaignName = "%40 İndirim Kampanyası", DiscountRate = 40 };
            ICampaignService campaignManager = new CampaignManager();
            campaignManager.AddCampaign(game, campaign);

            ISalesService salesManager = new SalesManager();
            salesManager.Sell(gamer, game, campaign, campaignManager, gamerManager, gameManager);
            salesManager.Sell(gamer, game, gamerManager, gameManager);
        }
    }
}
