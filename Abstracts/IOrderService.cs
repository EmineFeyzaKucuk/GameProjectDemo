using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Abstracts
{
    interface IOrderService
    {
        void Sales(Gamer gamer, Game game, Campaign campaign);
    }
}
