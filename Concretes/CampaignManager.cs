using GameProjectDemo.Abstracts;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concretes
{
    class CampaignManager : ICampaignService
    {

        public void NewCampaign(Campaign campaign)
        {

           Console.WriteLine(campaign.CampaignName + " Defined Succesfully");

        }
        public void Add(Campaign campaign)
        {
            
            Console.WriteLine(" Campaign Addded Succesfully");

        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(" Campaign Deleted Succesfully");
        }


        public void Update(Campaign campaign)
        {
            Console.WriteLine(" Campaign Uptaded Succesfully");
        }
    }
}
