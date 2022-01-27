using GameProjectDemo.Abstracts;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concretes
{
    class OrderManager : IOrderService
    {
        public void Sales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine("campaign action defined successfully!" + " (" +  gamer.FirstName + ", " + game.GameName + ", " + campaign.CampaignName +")");
         }
    }
}
