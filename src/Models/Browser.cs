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

    public partial class Browser
    {
        /// <summary>
        /// Initializes a new instance of the Browser class.
        /// </summary>
        public Browser()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Browser class.
        /// </summary>
        /// <param name="product">Product of the browser. Possible values are
        /// 'chrome', 'firefox', 'edge', 'safari'.</param>
        /// <param name="major">Major version of the browser.</param>
        /// <param name="version">Exact version of the browser.</param>
        public Browser(string product, int major, string version)
        {
            Product = product;
            Major = major;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets product of the browser. Possible values are 'chrome',
        /// 'firefox', 'edge', 'safari'.
        /// </summary>
        [JsonProperty(PropertyName = "product")]
        public string Product { get; set; }

        /// <summary>
        /// Gets or sets major version of the browser.
        /// </summary>
        [JsonProperty(PropertyName = "major")]
        public int Major { get; set; }

        /// <summary>
        /// Gets or sets exact version of the browser.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Product == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Product");
            }
            if (Version == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Version");
            }
        }
    }
}
