using Core;

namespace Domain.Commands
{
    public class RegisterContactCommand: Command
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
