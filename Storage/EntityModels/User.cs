﻿
namespace Storage.EntityModels
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
        /*public int RoleId { get; set; }*/
        
        public Role Role { get; set; }
    }
}