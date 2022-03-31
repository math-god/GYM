using System;

namespace Storage.EntityModels
{
    public class Subscription
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public decimal Price { get; set; }
        public int WorkoutsAmount { get; set; }
        public int PassedWorkouts { get; set; }
        public DateTime LastWorkoutDateTime { get; set; }
     /*   public int ClientId { get; set; }

        public Client Client { get; set; }*/
    }
}
