using System;
using System.Collections.Generic;
using System.Linq;

namespace BolRetailerApi.Models.Response.ProductContent
{ 
    public partial class CatalogProduct
    { 
        public bool? Published { get; set; }

        public Gpc Gpc { get; set; }

        public Enrichment Enrichment { get; set; }

        public List<Attributes> Attributes { get; set; }

        public List<Party> Parties { get; set; }

        public List<AudioTracks> AudioTracks { get; set; }

        public List<Serie> Series { get; set; }   
        
        // Helper methods
        public string? GetTitle() => Attributes.FirstOrDefault(x => x.Id == "Title")?.Values.FirstOrDefault()?.Value;
        public string? GetMpn() => Attributes.FirstOrDefault(x => x.Id == "Mpn")?.Values.FirstOrDefault()?.Value;
        public string? GetPieces() => Attributes.FirstOrDefault(x => x.Id == "Number of Parts")?.Values.FirstOrDefault()?.Value;
        public string? GetCategory() => Series.FirstOrDefault()?.Name;
    }
}
