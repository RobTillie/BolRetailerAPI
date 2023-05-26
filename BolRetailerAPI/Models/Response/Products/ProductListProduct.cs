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
    public partial class ProductListProduct
    { 
        /// <summary>
        /// The title of the product.
        /// </summary>
        /// <value>The title of the product.</value>
        [Required]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Eans
        /// </summary>
        [Required]
        public List<ProductListProductEan> Eans { get; set; }
    }
}
