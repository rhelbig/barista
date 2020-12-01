using System;

namespace WebAPI.Models
{
    public class UserModel
    {
        public Guid Id{get; set;}
        public string UserName{get; set;}
        public string UserPassword{get; set;}
        public string UserFirstName{get; set;}
        public string UserLastName{get; set;}
        public int Usermobile{get; set;}
        public string UserEmail{get; set;}
        public DateTime LastUpdatedOn { get; set;}
        public int LastUpdatedBy {get; set;}
    }
}