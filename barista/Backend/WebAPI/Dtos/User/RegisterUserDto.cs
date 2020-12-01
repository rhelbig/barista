namespace WebAPI.Dtos.User
{
    public class RegisterUserDto
    {
        public string UserName{get; set;}
        public string UserPassword{get; set;}
        public string UserFirstName{get; set;}
        public string UserLastName{get; set;}
        public string UserEmail{get; set;}
        public int UserMobile{get; set;}
    }
}