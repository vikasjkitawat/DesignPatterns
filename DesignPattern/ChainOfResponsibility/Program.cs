using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Entity;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            President president = new President { Name = "President" };
            VicePresident vicepresident = new VicePresident { Name = "Vice President", Next = president };
            Manager manager = new Manager { Name = "Manager", Next = vicepresident };

            Request medicalLeaveRequest = new LeaveRequest
            {
                ID = 1,
                Subject = "Medical leave - 1 week",
                Body = "Description",
                Approved = false,
                Severity = 3
            };

            Request sickLeaveRequest = new LeaveRequest
            {
                ID = 1,
                Subject = "Sick Leave",
                Body = "Description",
                Approved = false,
                Severity = 1
            };

            Request paternalLeaveRequest = new LeaveRequest
            {
                ID = 3,
                Subject = "Paternal leave - 2 week",
                Body = "Description",
                Approved = false,
                Severity = 2
            };

            manager.ProcessRequest(medicalLeaveRequest);
            manager.ProcessRequest(sickLeaveRequest);
            manager.ProcessRequest(paternalLeaveRequest);

            Console.ReadKey();
        }
    }
}

