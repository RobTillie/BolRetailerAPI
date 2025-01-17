﻿using System.Net.Http;
using BolRetailerApi.Endpoints;
using BolRetailerApi.Models.Authorization;
using BolRetailerApi.Models.Status;
using BolRetailerApi.Services;
using BolRetailerApi.Services.Authorization;
using BolRetailerAPI.Services;

namespace BolRetailerApi
{
    /// <summary>
    /// Wrapper class for the Bol Retailer API services.
    /// </summary>
    public class BolRetailerApi : IBolRetailerApi
    {
        public RateLimits RateLimits { get; }
        protected readonly IEndPoints EndPoints;
        private readonly AuthorizationToken _authorizationToken;
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="BolRetailerApi"/> class.
        /// Setup the necessary objects. This object can be used to inject via DI.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="clientSecret">The client secret.</param>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="testMode">if set to <c>true</c> [test mode].</param>
        public BolRetailerApi(string clientId, string clientSecret, HttpClient httpClient, bool testMode = false)
        {
            RateLimits = new RateLimits();
            EndPoints = testMode ? new TestEndPoints() : new EndPoints();
            _httpClient = httpClient;
            _authorizationToken = new AuthorizationToken(clientId, clientSecret, TokenService);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BolRetailerApi"/> class.
        /// Setup the necessary objects. This object can be used to inject via DI.
        /// </summary>
        /// <param name="clientId">The client identifier.</param>
        /// <param name="clientSecret">The client secret.</param>
        /// <param name="testMode">if set to <c>true</c> [test mode].</param>
        public BolRetailerApi(string clientId, string clientSecret, bool testMode = false)
            : this(clientId, clientSecret, new HttpClient(), testMode)
        {
        }

        /// <summary>
        /// Gets the token service.
        /// </summary>
        /// <value>
        /// The token service.
        /// </value>
        private ITokenService _tokenService;
        public ITokenService TokenService => _tokenService ??= new TokenService(_httpClient, EndPoints);

        /// <summary>
        /// Gets the orders service.
        /// </summary>
        /// <value>
        /// The orders service.
        /// </value>
        private OrdersService _ordersService;
        public OrdersService OrdersService =>
            _ordersService ??= new OrdersService(_httpClient, EndPoints, _authorizationToken, RateLimits);

        /// <summary>
        /// Gets the shipment service.
        /// </summary>
        /// <value>
        /// The shipment service.
        /// </value>
        private ShipmentService _shipmentService;
        public ShipmentService ShipmentService =>
            _shipmentService ??= new ShipmentService(_httpClient, EndPoints, _authorizationToken, RateLimits);

        /// <summary>
        /// Gets the product content service.
        /// </summary>
        /// <value>
        /// The product content service.
        /// </value>
        private ProductContentService _productContentService;
        public ProductContentService ProductContentService =>
            _productContentService ??= new ProductContentService(_httpClient, EndPoints, _authorizationToken, RateLimits);

        /// <summary>
        /// Gets the product service.
        /// </summary>
        /// <value>
        /// The product service.
        /// </value>
        private ProductsService _productsService;
        public ProductsService ProductsService =>
            _productsService ??= new ProductsService(_httpClient, EndPoints, _authorizationToken, RateLimits);
    }
}
