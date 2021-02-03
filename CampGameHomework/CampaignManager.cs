using System;
using System.Collections.Generic;
using System.Text;

namespace CampGameHomework
{
    class CampaignManager : ICampaignService
    {
        bool result = false;
        public bool AddCampaign(Game game, Campaign campaign)
        {
            return result = true;
        }

        public void DeleteCampaign(Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " silinmiştir.");
        }

        public void UpdateCampaign(Game game, Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " güncellenmiştir.");
        }
        public bool Result()
        {
            return result;
        }
    }
}
