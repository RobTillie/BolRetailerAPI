using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace BolRetailerApi.Models.Request
{ 
    public partial class ProductListRequest
    { 
        /// <summary>
        /// The country for which the products will be retrieved. Default value: NL
        /// </summary>
        /// <value>The country for which the products will be retrieved. Default value: NL</value>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum CountryCodeEnum
        {
            /// <summary>
            /// Enum NLEnum for NL
            /// </summary>
            [EnumMember(Value = "NL")]
            NLEnum = 0,
            /// <summary>
            /// Enum BEEnum for BE
            /// </summary>
            [EnumMember(Value = "BE")]
            BEEnum = 1        }

        public CountryCodeEnum? CountryCode { get; set; }

        public string SearchTerm { get; set; }

        [StringLength(11, MinimumLength=1)]
        public string CategoryId { get; set; }

        public List<ProductListFilterRange> FilterRanges { get; set; }

        public List<ProductListFilterValue> FilterValues { get; set; }

        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum SortEnum
        {
            /// <summary>
            /// Enum RELEVANCEEnum for RELEVANCE
            /// </summary>
            [EnumMember(Value = "RELEVANCE")]
            RELEVANCEEnum = 0,
            /// <summary>
            /// Enum POPULARITYEnum for POPULARITY
            /// </summary>
            [EnumMember(Value = "POPULARITY")]
            POPULARITYEnum = 1,
            /// <summary>
            /// Enum PRICEASCEnum for PRICE_ASC
            /// </summary>
            [EnumMember(Value = "PRICE_ASC")]
            PRICEASCEnum = 2,
            /// <summary>
            /// Enum PRICEDESCEnum for PRICE_DESC
            /// </summary>
            [EnumMember(Value = "PRICE_DESC")]
            PRICEDESCEnum = 3,
            /// <summary>
            /// Enum RELEASEDATEEnum for RELEASE_DATE
            /// </summary>
            [EnumMember(Value = "RELEASE_DATE")]
            RELEASEDATEEnum = 4,
            /// <summary>
            /// Enum RATINGEnum for RATING
            /// </summary>
            [EnumMember(Value = "RATING")]
            RATINGEnum = 5,
            /// <summary>
            /// Enum WISHLISTEnum for WISHLIST
            /// </summary>
            [EnumMember(Value = "WISHLIST")]
            WISHLISTEnum = 6        }

        public SortEnum? Sort { get; set; }

        public int? Page { get; set; }        
    }
}
