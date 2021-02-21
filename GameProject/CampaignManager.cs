using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void CampaignDelete(Gamer gamer)
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void CampaignLogin(Gamer gamer)
        {
            Console.WriteLine("Kampanya girişi");
        }

        public void CampaignUpdate(Gamer gamer)
        {
            Console.WriteLine("Kampanya güncellendi");
        }
    }
}
