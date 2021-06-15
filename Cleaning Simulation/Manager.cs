using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaning_Simulation
{
    public class Manager
    {
        private Manager()
        {

        }
        static Manager manager = new Manager();
        public static Manager Singleton
        {
            get
            {
                return manager;
            }
        }
    }
}
