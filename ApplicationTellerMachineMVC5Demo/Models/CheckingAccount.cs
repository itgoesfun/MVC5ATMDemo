using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApplicationTellerMachineMVC5Demo.Models
{
    public class CheckingAccount
    {
        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Balance { get; set; }
    }

}