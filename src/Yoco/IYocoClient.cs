namespace Yoco;

public interface IYocoClient
{
    ChargeResponse Charge(ChargeRequest chargeRequest);
    RefundResponse Refund(RefundRequest refundRequest);
}