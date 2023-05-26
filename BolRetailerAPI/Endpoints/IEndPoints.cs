namespace BolRetailerApi.Endpoints
{
    /// <summary>
    /// Endpoint definitions.
    /// </summary>
    public interface IEndPoints
    {
        string BaseUriLogin { get; }
        string BaseUriApiCalls { get; }

        string Token { get; }
        string Orders { get; }
        string ProductsList { get; }
        string SingleOrder { get; }
        string Shipments { get; }
        string SingleCatalogProduct { get; }

    }
}
