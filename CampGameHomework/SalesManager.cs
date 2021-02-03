using System;
using System.Collections.Generic;
using System.Text;

namespace CampGameHomework
{
    class SalesManager : ISalesService
    {
        public void Sell(IUser gamer, Game game, Campaign campaign, ICampaignService campaignManager,IGamerService gamerManager,IGameService gameManager)
        {
            if(gamerManager.Result() == true && gameManager.Result() == true && campaignManager.Result() == true)
            {
                float discountAmount = game.GamePrice * campaign.DiscountRate / 100;
                float price = game.GamePrice - discountAmount;
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " için " + campaign.CampaignName + " kampanyası uygulandı.");
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.GameName + " oyununu " + price + " TL'ye satın aldı");
            }
            else if(gamerManager.Result() == false)
            {
                Console.WriteLine("Oyuncu kayıtlı değildir.");
            }
            else if (gameManager.Result() == false)
            {
                Console.WriteLine("Sistemde böyle bir oyun yoktur.");
            }
            else if (campaignManager.Result() == false)
            {
                Console.WriteLine("Sistemde oluşturulmuş kampanya bulunmamaktadır.Kampanya seçimi yapmadan devam edebilirsiniz.");
            }
        }

        public void Sell(IUser gamer, Game game, IGamerService gamerManager, IGameService gameManager)
        {
            if (gamerManager.Result() == true && gameManager.Result() == true)
            {
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.GameName + " oyununu " + game.GamePrice + " TL'ye satın aldı");
            }
            else if (gamerManager.Result() == false)
            {
                Console.WriteLine("Oyuncu kayıtlı değildir.");
            }
            else if (gameManager.Result() == false)
            {
                Console.WriteLine("Sistemde böyle bir oyun yoktur.");
            }
        }
    }
}
