using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmenteven_.Clubs
{
    internal class Employee
    {
        public event Action<EmployeeLayOffEventArgs>? EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            throw new NotImplementedException();
        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate
        {
            get ; 
            set; 
        }
        public int VacationStock { get; set; }
            
        
        public bool RequestVacation(DateTime From, DateTime To)
        {
            throw new NotImplementedException();
        }
        public void EndOfYearOperation()
        {
            throw new NotImplementedException();
        }
    }
}

