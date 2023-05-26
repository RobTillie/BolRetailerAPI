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
    public partial class ProductListFilterRange
    { 
        /// <summary>
        /// The id of the range filter the products can be found within.
        /// </summary>
        /// <value>The id of the range filter the products can be found within.</value>
        [Required]

        [StringLength(11, MinimumLength=1)]
        public string RangeId { get; set; }

        /// <summary>
        /// The minimum value for the range that can be used to filter the products.
        /// </summary>
        /// <value>The minimum value for the range that can be used to filter the products.</value>
        [Required]
        public decimal? Min { get; set; }

        /// <summary>
        /// The maximum value for the range that can be used to filter the products.
        /// </summary>
        /// <value>The maximum value for the range that can be used to filter the products.</value>
        [Required]
        public decimal? Max { get; set; }
    }
}
