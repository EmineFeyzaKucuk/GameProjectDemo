using GameProjectDemo.Abstracts;
using GameProjectDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProjectDemo.Concretes
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService= userValidationService;
        }


        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Gamer Added!");
            }
            else

            { Console.WriteLine("Gamer Validation Failed!"); }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(" Gamer Deleted Succesfully", gamer.FirstName);
        }

        public void Update(Gamer gamer)
        {

            Console.WriteLine(" Gamer Uptaded Succesfully", gamer.FirstName);
        }

      
     

       


       

      

       
    }
}
