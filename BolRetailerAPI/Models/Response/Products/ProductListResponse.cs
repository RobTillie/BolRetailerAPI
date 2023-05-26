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

namespace BolRetailerApi.Models.Response.Products
{
    public partial class ProductListResponse
    { 
        /// <summary>
        /// The list of products that is associated with the given search term or category and filters.
        /// </summary>
        /// <value>The list of products that is associated with the given search term or category and filters.</value>
        [Required]
        public List<ProductListProduct> Products { get; set; }

        /// <summary>
        /// Determines the order of the products.
        /// </summary>
        /// <value>Determines the order of the products.</value>
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

        /// <summary>
        /// Determines the order of the products.
        /// </summary>
        /// <value>Determines the order of the products.</value>
        [Required]
        public SortEnum? Sort { get; set; }
    }
}
