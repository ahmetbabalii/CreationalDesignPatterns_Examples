using System.Text;

namespace Prototype.domain
{
    public class IndividualCustomer : Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public IndividualCustomer(int registerId, string address, string phone, bool authenticated, bool validated, DateTime membershipDate, string firstName, string lastName)
            : base(registerId, address, phone, authenticated, validated, membershipDate)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*************************************");
            sb.AppendLine("IndividualCustomer Details");
            sb.AppendLine($"registerId: {registerId}");
            sb.AppendLine($"firstName: {firstName}");
            sb.AppendLine($"lastName: {lastName}");
            sb.AppendLine($"address: {address}");
            sb.AppendLine($"phone: {phone}");
            sb.AppendLine($"authenticated: {authenticated}");
            sb.AppendLine($"validated: {validated}");
            sb.AppendLine($"membershipDate: {membershipDate}");

            return sb.ToString();
        }    
    }
}
