using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation
{
    class Security:Person
    {
        private bool alarm;

        private void Scan_System() { }

        private void Check_Access() { /*change to dataTable*/}

        private void Fault_Access() { /*change to dataTable*/}

        private bool Alarm() { return false; }

        private void Check_Camera() { }
    }
}
