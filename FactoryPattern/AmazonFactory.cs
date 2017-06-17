using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryPattern
{
  abstract  class Employee
    {
        public virtual void GetProjectDetails()
        { }

        public virtual void GetEmployeeDetails()
        { }             
    }

    class cc : Employee
    {

    }
}