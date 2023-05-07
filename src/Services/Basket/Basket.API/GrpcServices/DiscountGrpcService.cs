using Discount.Grpc.Protos;

namespace Basket.API.GrpcServices
{
    public class DiscountGrpcService
    {
        private readonly DiscountProtoService.DiscountProtoServiceClient _client;

        public DiscountGrpcService(DiscountProtoService.DiscountProtoServiceClient client)
        {
            _client = client;
        }

        public async Task<CouponModel> GetDiscount(string producName)
        {
            var discountRequest = new GetDiscountRequest {  ProductName = producName };
            return await _client.GetDiscountAsync(discountRequest);
        }
    }
}
