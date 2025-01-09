namespace Ordering.Domain.ValueObjects
{
    public class OrderItemId
    {
        public Guid Value { get; set; }

        private OrderItemId(Guid value) => Value = value;

        public static OrderItemId Of(Guid value)
        {
            ArgumentNullException.ThrowIfNull(value);
            if(value == Guid.Empty)
            {
                throw new DomainException("OrderItemId can not be empty.");
            }

            return new OrderItemId(value);
        }
    }
}
