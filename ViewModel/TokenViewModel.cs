using APIDWS.Models;

namespace APIDWS.ViewModel {
    public class TokenViewModel {
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public User? User { get; set; }
    }
}