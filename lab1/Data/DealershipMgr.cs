using lab1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab1.Data
{
    //Remember to include basic error checking
    public static class DealershipMgr
    {
        public static List<Dealership> dealerships = new List<Dealership>() {
            new Dealership {ID = 1, Name = "dealership1", Email = "tets@test.com", PhoneNumber = "123-123-1234"},
            new Dealership {ID = 2, Name = "dealership2", Email = "asd@asdf.com", PhoneNumber = "111-111-1111"},
            new Dealership {ID = 3, Name = "dealership3", Email = "wow@wow.com", PhoneNumber = "222-222-2222"},
        };

        public static List<Dealership> GetDealerships()
        {
            return dealerships;
        }

        public static Dealership GetDealership(int? id)
        {
            try {
                return dealerships.FirstOrDefault(dealership => dealership.ID == id);
            }
            catch  (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
            
        }

        public static void CreateDealership(Dealership dealership) {
            try {
                int lastIndex = dealerships.Count - 1;
                dealership.ID = dealerships[lastIndex].ID + 1;
                dealerships.Add(dealership);
                Console.WriteLine(dealerships);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        public static void UpdateDealership(Dealership dealership) {
            //update dealership
            try
            {
                int index = dealerships.FindIndex(d => d.ID == dealership.ID);

                if (index >= 0)
                {
                    dealerships[index] = dealership;
                }
                else {
                    Console.WriteLine("dealership doesn't exist.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void UpdateDealershipApi(int id, Dealership dealership)
        {
            //update dealership
            try
            {
                int index = dealerships.FindIndex(d => d.ID == id);
                if (index >= 0)
                {
                    dealership.ID = id;
                    dealerships[index] = dealership;
                }
                else
                {
                    Console.WriteLine("dealership doesn't exist.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public static void DeleteDealership(int id) {
            //delete dealership
            try
            {
                Dealership selectedDealership = dealerships.FirstOrDefault(d => d.ID == id);

                if (selectedDealership != null)
                {
                    int index = dealerships.IndexOf(selectedDealership);
                    dealerships.RemoveAt(index);
                }
                else
                {
                    Console.WriteLine("dealership doesn't exist.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
