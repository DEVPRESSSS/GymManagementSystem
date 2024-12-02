using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymManagementSystem.Model
{
    public class Contract
    {


        public int ContractID { get; set; }


        public MembershipType? MembershipType { get; set; }
        public DateOnly StartDate { get; set; }


        public DateOnly EndDate { get; set; }

    }
}
