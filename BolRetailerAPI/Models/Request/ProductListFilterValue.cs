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
    public partial class ProductListFilterValue
    { 
        /// <summary>
        /// The unique identifier of the filter value.
        /// </summary>
        /// <value>The unique identifier of the filter value.</value>
        [Required]
        public string FilterValueId { get; set; }
    }
}
