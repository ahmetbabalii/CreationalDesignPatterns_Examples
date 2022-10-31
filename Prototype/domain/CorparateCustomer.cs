using System.Text;

namespace Prototype.domain
{
    public class CorparateCustomer : Customer
    {
        public string corporateName { get; set; }
        public string directorName { get; set; }

        public CorparateCustomer(int registerId, string address, string phone, bool authenticated, bool validated, DateTime membershipDate, string corporateName, string directorName) 
            : base(registerId, address, phone, authenticated, validated, membershipDate)
        {
            this.corporateName = corporateName;
            this.directorName = directorName;
        }

        public override string ToString()     
        {            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*************************************");
            sb.AppendLine("IndividualCustomer Details");
            sb.AppendLine($"registerId: {registerId}");
            sb.AppendLine($"corporateName: {corporateName}");
            sb.AppendLine($"directorName: {directorName}");
            sb.AppendLine($"address: {address}");
            sb.AppendLine($"phone: {phone}");
            sb.AppendLine($"authenticated: {authenticated}");
            sb.AppendLine($"validated: {validated}");
            sb.AppendLine($"membershipDate: {membershipDate}");

            return sb.ToString();
        }
    }
}
