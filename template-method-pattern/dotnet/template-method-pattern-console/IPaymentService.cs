namespace com.opusmagus
{
    public interface IPaymentService
    {
        bool processPayment(OrderDTO order);
    }
}