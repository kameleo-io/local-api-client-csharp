// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Kameleo.LocalApiClient.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Provides possible values for base profile filtering. For example it
    /// tells what os languages are available.
    /// </summary>
    public partial class BaseProfileSearchParameters
    {
        /// <summary>
        /// Initializes a new instance of the BaseProfileSearchParameters
        /// class.
        /// </summary>
        public BaseProfileSearchParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseProfileSearchParameters
        /// class.
        /// </summary>
        /// <param name="deviceTypes">List of possible device types. Possible
        /// values are 'desktop', 'mobile'.</param>
        /// <param name="osFamilies">List of possible os families. Possible
        /// values are 'windows', 'macos', 'linux', 'android', 'ios'.</param>
        /// <param name="browserProducts">List of possible browser products.
        /// Possible values are 'chrome', 'firefox', 'edge', 'safari'.</param>
        /// <param name="languages">List of possible os languages. It using the
        /// ISO 639-1 language code format.</param>
        public BaseProfileSearchParameters(IList<string> deviceTypes, IList<string> osFamilies, IList<string> browserProducts, IList<string> languages)
        {
            DeviceTypes = deviceTypes;
            OsFamilies = osFamilies;
            BrowserProducts = browserProducts;
            Languages = languages;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of possible device types. Possible values are
        /// 'desktop', 'mobile'.
        /// </summary>
        [JsonProperty(PropertyName = "deviceTypes")]
        public IList<string> DeviceTypes { get; set; }

        /// <summary>
        /// Gets or sets list of possible os families. Possible values are
        /// 'windows', 'macos', 'linux', 'android', 'ios'.
        /// </summary>
        [JsonProperty(PropertyName = "osFamilies")]
        public IList<string> OsFamilies { get; set; }

        /// <summary>
        /// Gets or sets list of possible browser products. Possible values are
        /// 'chrome', 'firefox', 'edge', 'safari'.
        /// </summary>
        [JsonProperty(PropertyName = "browserProducts")]
        public IList<string> BrowserProducts { get; set; }

        /// <summary>
        /// Gets or sets list of possible os languages. It using the ISO 639-1
        /// language code format.
        /// </summary>
        [JsonProperty(PropertyName = "languages")]
        public IList<string> Languages { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeviceTypes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeviceTypes");
            }
            if (OsFamilies == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsFamilies");
            }
            if (BrowserProducts == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BrowserProducts");
            }
            if (Languages == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Languages");
            }
        }
    }
}