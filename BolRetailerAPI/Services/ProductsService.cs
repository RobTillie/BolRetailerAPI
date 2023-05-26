using BolRetailerApi.Client;
using BolRetailerApi.Endpoints;
using BolRetailerApi.Models.Authorization;
using BolRetailerApi.Models.Request;
using BolRetailerApi.Models.Response.ProductContent;
using BolRetailerApi.Models.Response.Products;
using BolRetailerApi.Models.Status;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BolRetailerAPI.Services
{
    /// <summary>
    /// ProductContent API Service
    /// </summary>
    /// <seealso cref="AuthenticatedClientBase" />
    public class ProductsService : AuthenticatedClientBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductContentService" /> class.
        /// </summary>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="endPoints">The end points.</param>
        /// <param name="authorizationToken">The authorization token.</param>
        /// <param name="rateLimits">The rate limits.</param>
        public ProductsService(
            HttpClient httpClient,
            IEndPoints endPoints,
            IAuthorizationToken authorizationToken,
            RateLimits rateLimits = null)
            : base(httpClient, endPoints, authorizationToken, rateLimits)
        {
        }
        
        public async Task<ProductListResponse> GetProductListAsync(string searchTerm)
        {
            var request = new ProductListRequest
            { 
                CountryCode = ProductListRequest.CountryCodeEnum.NLEnum,
                SearchTerm = searchTerm,
                Page = 1,
                Sort = ProductListRequest.SortEnum.RELEVANCEEnum
            };

            return await GetApiResult<ProductListResponse>(
                HttpMethod.Post,
                $"{EndPoints.BaseUriApiCalls}{EndPoints.ProductsList}",
                request
            );
        }
    }
}
