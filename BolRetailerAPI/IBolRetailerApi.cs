using BolRetailerApi.Services;
using BolRetailerApi.Services.Authorization;
using BolRetailerAPI.Services;

namespace BolRetailerApi
{
    /// <summary>
    /// Wrapper class interface for the Bol Retailer API services.
    /// </summary>
    public interface IBolRetailerApi
    {
        /// <summary>
        /// Gets the token service.
        /// </summary>
        /// <value>
        /// The token service.
        /// </value>
        ITokenService TokenService { get; }

        /// <summary>
        /// Gets the orders service.
        /// </summary>
        /// <value>
        /// The orders service.
        /// </value>
        OrdersService OrdersService { get; }

        /// <summary>
        /// Gets the shipment service.
        /// </summary>
        /// <value>
        /// The shipment service.
        /// </value>
        ShipmentService ShipmentService { get; }

        ProductsService ProductsService { get; }

        ProductContentService ProductContentService { get; }
    }
}