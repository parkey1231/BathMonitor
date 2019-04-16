using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BathMonitorSystem
{
     static class CommonMethods
    {
        public static Dictionary<int, FlowData> CurrentValue = new Dictionary<int, FlowData>();
        public static Dictionary<int, ModTCP> CurrentModbusList = new Dictionary<int, ModTCP>();
    }
}
