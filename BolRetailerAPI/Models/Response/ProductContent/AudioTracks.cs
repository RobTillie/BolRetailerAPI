using System;

namespace BolRetailerApi.Models.Response.ProductContent
{
    public partial class AudioTracks
    { 
        public string DiscNumber { get; set; }
        public string TrackNumber { get; set; }
        public string DiscSide { get; set; }
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public string PlayTime { get; set; }
        public string ClipUrl { get; set; }
        public string ClipType { get; set; }
    }
}
