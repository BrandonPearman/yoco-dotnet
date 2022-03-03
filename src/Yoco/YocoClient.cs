using System;
using System.Net.Http;
using System.Text;

namespace Yoco;

public class YocoClient : IYocoClient
{
    private readonly HttpClient _httpClient;
    private const string _baseUrl = "https://online.yoco.com";

    public YocoClient(HttpClient httpClient, string privateKey)
    {
        _httpClient = httpClient;
        _httpClient.DefaultRequestHeaders.Authorization =
        new System.Net.Http.Headers.AuthenticationHeaderValue(
            "Basic", Convert.ToBase64String(
            Encoding.UTF8.GetBytes($"{privateKey}:")));
        _httpClient.BaseAddress = new Uri(_baseUrl);
    }

    public ChargeResponse Charge(ChargeRequest chargeRequest)
    {

        return new ChargeResponse();
    }

    public RefundResponse Refund(RefundRequest refundRequest)
    {

        return new RefundResponse();
    }
}
