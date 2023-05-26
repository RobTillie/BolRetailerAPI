using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BolRetailerApi.Client;
using BolRetailerApi.Endpoints;
using BolRetailerApi.Exceptions;
using BolRetailerApi.Models.Authorization;
using BolRetailerApi.Models.Enum;
using BolRetailerApi.Models.Request;
using BolRetailerApi.Models.Response;
using BolRetailerApi.Models.Response.Orders;
using BolRetailerApi.Models.Response.ProductContent;
using BolRetailerApi.Models.Status;

namespace BolRetailerApi.Services
{
    /// <summary>
    /// ProductContent API Service
    /// </summary>
    /// <seealso cref="AuthenticatedClientBase" />
    public class ProductContentService : AuthenticatedClientBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductContentService" /> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="endPoints">The end points.</param>
        /// <param name="authorizationToken">The authorization token.</param>
        /// <param name="rateLimits">The rate limits.</param>
        public ProductContentService(
            HttpClient httpClient,
            IEndPoints endPoints,
            IAuthorizationToken authorizationToken,
            RateLimits rateLimits = null)
            : base(httpClient, endPoints, authorizationToken, rateLimits)
        {
        }


        /// <summary>
        /// Gets a single order's details.
        /// </summary>
        /// <param name="orderId">The order identifier.</param>
        /// <returns>An Order entity.</returns>
        public async Task<CatalogProduct> GetCatalogProductAsync(string ean)
        {
            return await GetApiResult<CatalogProduct>(
                HttpMethod.Get,
                $"{EndPoints.BaseUriApiCalls}{EndPoints.SingleCatalogProduct}{ean}"
            );
        }        
    }
}
