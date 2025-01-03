using Enumeracao.Entities.Enums;

namespace Enumeracao.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public Order()
        {

        }

        public Order(int id, DateTime moment, OrderStatus status)
        {
            Id = id;
            Moment = moment;
            Status = status;
        }

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }
    }
}
