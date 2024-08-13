using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmenteven_.Clubs
{
    internal class Club
    {
        public int ClubID { get; set; }
        public String ClubName { get; set; }
        List<Employee> Members;
        public void AddMember(Employee E)
        {
            Members.Add(E);
            
            ///Try Register for EmployeeLayOff Event Here
        }
        ///CallBackMethod
        public void RemoveMember (object sender, EmployeeLayOffEventArgs e)
        {
            Console.WriteLine($" sender is {sender} , emp : {e}");
            if(e)
            ///Employee Will not be removed from the Club if Age>60
            ///Employee will be removed from Club if Vacation Stock < 0
        }
        public override string ToString()
        {
            return $"Id :{ClubID} , Name : {ClubName} ";
        }
        public Club()
        {
            Members = new List<Employee>();
        }
    }
}
