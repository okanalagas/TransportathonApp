namespace TransportathonApp.Application.Exceptions
{
    public class LoginFailException : Exception
    {
        public LoginFailException() : base("Kullanıcı adı veya şifre hatalı!")
        {
        }

        public LoginFailException(string? message) : base(message)
        {
        }

        public LoginFailException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
