using System;
using System.Collections.Generic;

namespace Storage.EntityModels
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string Phone { get; set; }
        public DateTime SignUpDate { get; set; }
        
   /*     public List<Subscription> Subscriptions { get; set; } = new List<Subscription>();*/
    }
}