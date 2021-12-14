using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DogGO.Models;

namespace DogGO.Repositories
{
   
        public interface IOwnerRepository
        {
            List<Owner> GetAllOwners();
            Owner GetOwenrById(int id);
        Owner GetOwnerById(int id);
    }
    
}
