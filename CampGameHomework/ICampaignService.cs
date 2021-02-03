using System;
using System.Collections.Generic;
using System.Text;

namespace CampGameHomework
{
    interface ICampaignService
    {
        bool AddCampaign(Game game, Campaign campaign);
        void DeleteCampaign(Game game, Campaign campaign);
        void UpdateCampaign(Game game, Campaign campaign);
        bool Result();
    }
}
