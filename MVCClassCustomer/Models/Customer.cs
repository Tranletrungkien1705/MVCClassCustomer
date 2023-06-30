using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCClassCustomer.Models
{
    public class Customer
    {
        private int Id;
        private string FullName;
        private DateOnly Birthday;
        private string? Address;
        private string? Email;
        private string? UserName;
        private string Password;
        private string ConfirmPassword;
        private int ClassId;
    }
}
