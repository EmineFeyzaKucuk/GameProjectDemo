using GameProjectDemo.Abstracts;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concretes
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Feyza" && gamer.LastName == "Küçük" && gamer.DateOfBirth == new DateTime(2020,01,01) && gamer.id == 123456 && gamer.Tc == "32323232323" )

            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
