using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.District
{
    class DistrictRepository
    {
        static List<DistrictBase> _districts = new List<DistrictBase>
        {
            new DistrictBase{DistrictName="North"},
            new DistrictBase{DistrictName="South"},
            new DistrictBase{DistrictName="East"},
            new DistrictBase{DistrictName="West"},
        };

        public List<DistrictBase> GetDistricts()
        {
            return _districts;
        }

        public void AddNewDistrict(DistrictBase district)
        {
            _districts.Add(district);
        }
    }
}
