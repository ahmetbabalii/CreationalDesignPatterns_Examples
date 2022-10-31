namespace Prototype.domain
{
    public class Customer : ICloneable
    {
        protected int registerId { get; set; }
        protected string address { get; set; }
        protected string phone { get; set; }
        protected bool authenticated { get; set; }
        protected bool validated { get; set; }
        protected DateTime membershipDate { get; set; }

        public Customer(int registerId, string address, string phone, bool authenticated, bool validated, DateTime membershipDate)
        {
            this.registerId = registerId;
            this.address = address;
            this.phone = phone;
            this.authenticated = authenticated;
            this.validated = validated;
            this.membershipDate = membershipDate;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
