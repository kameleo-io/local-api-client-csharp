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

    public partial class ScreenSpoofingTypeScreenSizeMultiLevelChoice
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ScreenSpoofingTypeScreenSizeMultiLevelChoice class.
        /// </summary>
        public ScreenSpoofingTypeScreenSizeMultiLevelChoice()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ScreenSpoofingTypeScreenSizeMultiLevelChoice class.
        /// </summary>
        /// <param name="value">Possible values include: 'automatic', 'manual',
        /// 'off'</param>
        /// <param name="extra">The screen size of the device in pixels. For
        /// example: 1920x1080</param>
        public ScreenSpoofingTypeScreenSizeMultiLevelChoice(string value, string extra = default(string))
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
        /// Gets or sets possible values include: 'automatic', 'manual', 'off'
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the screen size of the device in pixels. For example:
        /// 1920x1080
        /// </summary>
        [JsonProperty(PropertyName = "extra")]
        public string Extra { get; set; }

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
