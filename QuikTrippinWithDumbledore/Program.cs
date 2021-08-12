using System;
using System.Collections.Generic;
using QuikTrippinWithDumbledore.District;

namespace QuikTrippinWithDumbledore
{
    class Program
    {
        static void Main(string[] args)
        {
            var districtRepo = new DistrictRepository();
            Console.WriteLine("Add a new District");
            var userInputDistrict = Console.ReadLine();

            districtRepo.AddNewDistrict(new DistrictBase { DistrictName = userInputDistrict });

            districtRepo.RemoveDistrict(userInputDistrict);

            districtRepo.GetDistricts();

            

        }
    }
}
