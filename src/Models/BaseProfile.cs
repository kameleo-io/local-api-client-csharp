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
    /// Representation of a base profile which is used to build profiles from.
    /// </summary>
    public partial class BaseProfile
    {
        /// <summary>
        /// Initializes a new instance of the BaseProfile class.
        /// </summary>
        public BaseProfile()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BaseProfile class.
        /// </summary>
        /// <param name="version">The version of the base profile. As time
        /// passes new base profile versions will be introduced. It is
        /// recommended to use the latest one.</param>
        /// <param name="id">The unique identifier of the base profile. You can
        /// use this as a reference to create a new profile from this base
        /// profile.</param>
        /// <param name="language">Language of the base profile. Using ISO
        /// 639-1 language codes.</param>
        /// <param name="resolution">The screen size of the device in
        /// pixels</param>
        /// <param name="fonts">A list of font types included in the
        /// profile</param>
        /// <param name="plugins">A list of plugins included in the
        /// profile</param>
        public BaseProfile(string version, string id, Device device, Os os, Browser browser, string language, string resolution, IList<string> fonts, IList<string> plugins, WebglMeta webglMeta)
        {
            Version = version;
            Id = id;
            Device = device;
            Os = os;
            Browser = browser;
            Language = language;
            Resolution = resolution;
            Fonts = fonts;
            Plugins = plugins;
            WebglMeta = webglMeta;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the version of the base profile. As time passes new
        /// base profile versions will be introduced. It is recommended to use
        /// the latest one.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier of the base profile. You can use
        /// this as a reference to create a new profile from this base profile.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "device")]
        public Device Device { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "os")]
        public Os Os { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "browser")]
        public Browser Browser { get; set; }

        /// <summary>
        /// Gets or sets language of the base profile. Using ISO 639-1 language
        /// codes.
        /// </summary>
        [JsonProperty(PropertyName = "language")]
        public string Language { get; set; }

        /// <summary>
        /// Gets or sets the screen size of the device in pixels
        /// </summary>
        [JsonProperty(PropertyName = "resolution")]
        public string Resolution { get; set; }

        /// <summary>
        /// Gets or sets a list of font types included in the profile
        /// </summary>
        [JsonProperty(PropertyName = "fonts")]
        public IList<string> Fonts { get; set; }

        /// <summary>
        /// Gets or sets a list of plugins included in the profile
        /// </summary>
        [JsonProperty(PropertyName = "plugins")]
        public IList<string> Plugins { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "webglMeta")]
        public WebglMeta WebglMeta { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Version == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Version");
            }
            if (Id == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Id");
            }
            if (Device == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Device");
            }
            if (Os == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Os");
            }
            if (Browser == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Browser");
            }
            if (Language == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Language");
            }
            if (Resolution == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Resolution");
            }
            if (Fonts == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Fonts");
            }
            if (Plugins == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Plugins");
            }
            if (WebglMeta == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WebglMeta");
            }
            if (Device != null)
            {
                Device.Validate();
            }
            if (Os != null)
            {
                Os.Validate();
            }
            if (Browser != null)
            {
                Browser.Validate();
            }
            if (WebglMeta != null)
            {
                WebglMeta.Validate();
            }
        }
    }
}
