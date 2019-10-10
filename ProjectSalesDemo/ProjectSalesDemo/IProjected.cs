using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSalesDemo
{
    //This is an interface. Acts as an abstract class.
    
    //interfaces are meant to be shared amongst classes that will have common
    //functions (for example, a bank teller, and and atm both can deposit money)
    interface IProjected
    {
        double salesIncrease();

    }
}
