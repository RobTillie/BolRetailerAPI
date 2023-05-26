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
    public partial class ProductListProductEan
    { 
        /// <summary>
        /// The EAN number associated with this product.
        /// </summary>
        /// <value>The EAN number associated with this product.</value>
        [Required]
        public string Ean { get; set; }
    }
}
