using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuikTrippinWithDumbledore.District
{
    class DistrictRepository
    {
        static List<District> _district = new List<District>
        {
            new District{DistrictName="North"},
            new District{DistrictName="South"},
            new District{DistrictName="East"},
            new District{DistrictName="West"},
        };

        public List<District> GetDistricts()
        {
            return _district;
        }

        public void Add(District district)
        {
            _district.Add(district);
        }
    }
}
