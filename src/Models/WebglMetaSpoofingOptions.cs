// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kameleo.LocalApiClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// When the WebGL Meta spoofing is used, these settings can override the
    /// values in the base profile.
    /// </summary>
    public partial class WebglMetaSpoofingOptions
    {
        /// <summary>
        /// Initializes a new instance of the WebglMetaSpoofingOptions class.
        /// </summary>
        public WebglMetaSpoofingOptions()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebglMetaSpoofingOptions class.
        /// </summary>
        /// <param name="vendor">Unmasked vendor</param>
        /// <param name="renderer">Unmasked renderer</param>
        public WebglMetaSpoofingOptions(string vendor = default(string), string renderer = default(string))
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
        /// Gets or sets unmasked vendor
        /// </summary>
        [JsonProperty(PropertyName = "vendor")]
        public string Vendor { get; set; }

        /// <summary>
        /// Gets or sets unmasked renderer
        /// </summary>
        [JsonProperty(PropertyName = "renderer")]
        public string Renderer { get; set; }

    }
}
