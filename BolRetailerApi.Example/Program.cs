﻿using BolRetailerApi.Models.Enum;
using Microsoft.Extensions.Configuration;

var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .Build();

Console.Write("Client ID: ");
var clientId = configuration.GetSection("clientId")?.Value ?? Console.ReadLine();
Console.WriteLine($"{clientId}\n");

Console.Write("Client Secret: ");
var clientSecret = configuration.GetSection("clientSecret")?.Value ?? Console.ReadLine();
Console.WriteLine($"{clientSecret}\n");

var api = new BolRetailerApi.BolRetailerApi(
    clientId,
    clientSecret,
    false);

try
{
    string[] searchTerms = new[] { "LEGO Marvel Spider-Man", "10782", "5702017153445" };

    foreach (var searchTerm in searchTerms)
    {
        Console.WriteLine($"Searching products for {searchTerm}");
        var products = await api.ProductsService.GetProductListAsync(searchTerm);
        Console.WriteLine($"Found {products.Products.Count} results with {products.Products.FirstOrDefault()?.Title}");
    }

    Console.WriteLine("Fetching catalog product by EAN");

    Console.WriteLine("Scan barcode: ");
    var enteredText = Console.ReadLine();

    var pc = await api.ProductContentService.GetCatalogProductAsync(enteredText);

    var mpn = pc?.Attributes.FirstOrDefault(x => x.Id == "Mpn")?.Values.FirstOrDefault()?.Value;
    var title = pc?.Attributes.FirstOrDefault(x => x.Id == "Title")?.Values.FirstOrDefault()?.Value;

    Console.WriteLine($"Found product {title} (mpn = {mpn})");

    //Console.WriteLine("Fetching all orders..");
    //var orders = await api.OrdersService.GetOrdersAsync();
    //Console.WriteLine($"Found {orders.Count()} orders.\n");

    //Console.WriteLine("Fetching open orders..");
    //orders = await api.OrdersService.GetOrdersAsync();
    //Console.WriteLine($"Found {orders.Count()} open orders.\n");

    //var firstOrder = orders.First();
    //Console.WriteLine($"First order has order id {firstOrder.OrderId}\n");

    //Console.WriteLine("Fetching the full order..");
    //var fullOrder = await api.OrdersService.GetOrderAsync(firstOrder.OrderId);
    //Console.WriteLine("Full order fetched.\n");

    //Console.WriteLine($"Cancelling order {firstOrder.OrderId}..");
    //var cancelledOrderItem = await api.OrdersService.CancelOrderAsync(firstOrder.OrderId);
    //Console.WriteLine($"Order cancelled with status {cancelledOrderItem.First().Status}\n");

    //Console.WriteLine($"Shipping order {firstOrder.OrderId}..");
    //var shippedOrder = await api.OrdersService.ShipOrderAsync(
    //    firstOrder.OrderId,
    //    TransporterCode.Tnt,
    //    "3SABCD000000001"
    //);
    //Console.WriteLine($"Order shipped with status {shippedOrder.First().Status}\n");

    //Console.WriteLine($"Fetching shipped order details for order {firstOrder.OrderId}..");
    //var shippedOrderDetails = await api
    //    .ShipmentService
    //    .GetShipmentListForOrderAsync(firstOrder.OrderId);
    
    //var shipmentId = shippedOrderDetails.First().ShipmentId;
    //Console.WriteLine($"Successful retrieval of details. First shipment Id is {shipmentId}\n");

    //Console.WriteLine($"Fetching shipment details for {shipmentId}");
    //var shipmentDetails = await api.ShipmentService.GetShipmentByIdAsync(shipmentId);
    //Console.WriteLine($"Shipment details retrieved with date and time {shipmentDetails.ShipmentDateTime}");
}
catch (Exception ex)
{
    Console.WriteLine("!! EXCEPTION !!");
    Console.WriteLine($"{ex.Message}\n\n");
    Console.WriteLine(ex.StackTrace);
}

Console.ReadKey();
