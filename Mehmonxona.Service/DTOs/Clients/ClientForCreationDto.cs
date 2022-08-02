
using Mehmonxona.Domain.Enums;

namespace Mehmonxona.Service.DTOs.Clients
{
    public class ClientForCreationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Passport { get; set; }
        public Gender Gender { get; set; }
        public string Password { get; set; }
    }
}
