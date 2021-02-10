using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbbyWakeAssignment4.Models
{
    public class tempStorage
    {
        private static List<addRes> ResList = new List<addRes>();

        public static IEnumerable<addRes> Applications => ResList;

        public static void AddApplication(addRes addRes)
        {
            ResList.Add(addRes);
        }
    }
}
