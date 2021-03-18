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

    public partial class WebglSpoofingTypeWebglSpoofingOptionsMultiLevelChoice
    {
        /// <summary>
        /// Initializes a new instance of the
        /// WebglSpoofingTypeWebglSpoofingOptionsMultiLevelChoice class.
        /// </summary>
        public WebglSpoofingTypeWebglSpoofingOptionsMultiLevelChoice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// WebglSpoofingTypeWebglSpoofingOptionsMultiLevelChoice class.
        /// </summary>
        /// <param name="value">Possible values include: 'noise', 'block',
        /// 'off'</param>
        public WebglSpoofingTypeWebglSpoofingOptionsMultiLevelChoice(string value, WebglSpoofingOptions extra = default(WebglSpoofingOptions))
        {
            Value = value;
            Extra = extra;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'noise', 'block', 'off'
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extra")]
        public WebglSpoofingOptions Extra { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}