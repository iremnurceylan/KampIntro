using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void CampaignLogin(Gamer gamer);
        void CampaignDelete(Gamer gamer);
        void CampaignUpdate(Gamer gamer);
    }
}
