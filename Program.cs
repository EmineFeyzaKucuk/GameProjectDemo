using GameProjectDemo.Concretes;
using GameProjectDemo.Entity;
using System;

namespace GameProjectDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer Feyza = new Gamer
            {
                id = 123456,
                FirstName = "Feyza",
                LastName = "Küçük",
                DateOfBirth = new DateTime(2020, 01, 01),
                Tc = "32323232323"
            };

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(Feyza);
            gamerManager.Update(Feyza);
            gamerManager.Delete(Feyza);

            Game game = new Game();
            {
                game.id = 3;
                game.GameName = "Game320";
                game.GamePrice = 32;
            }

            Campaign campaign = new Campaign();
            {
                campaign.id = 3;
                campaign.CampaignName = "Campaign1";
            }

            CampaignManager campaignManager = new CampaignManager();
            {
                campaignManager.NewCampaign(campaign);
                campaignManager.Add(campaign);
                campaignManager.Update(campaign);
                campaignManager.Delete(campaign); 
            }

            OrderManager orderManager = new OrderManager();
            orderManager.Sales(Feyza, game, campaign);
            
        }
    }
}
