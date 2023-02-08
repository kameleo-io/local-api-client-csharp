// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kameleo.LocalApiClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WebglMeta
    {
        /// <summary>
        /// Initializes a new instance of the WebglMeta class.
        /// </summary>
        public WebglMeta()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebglMeta class.
        /// </summary>
        /// <param name="vendor">The UnmaskedVendor field from WebGL
        /// context</param>
        /// <param name="renderer">The UnmaskedRenderer field from WebGL
        /// context</param>
        public WebglMeta(string vendor, string renderer = default(string))
        {
            Vendor = vendor;
            Renderer = renderer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the UnmaskedVendor field from WebGL context
        /// </summary>
        [JsonProperty(PropertyName = "vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets the UnmaskedRenderer field from WebGL context
        /// </summary>
        [JsonProperty(PropertyName = "renderer")]
        public string Renderer { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Vendor == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Vendor");
            }
        }
    }
}
