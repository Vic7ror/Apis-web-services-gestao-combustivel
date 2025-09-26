using System.ComponentModel.DataAnnotations;

namespace Apis_web_services_gestao_combustivel.Model
{
    public class AuthenticateDto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
