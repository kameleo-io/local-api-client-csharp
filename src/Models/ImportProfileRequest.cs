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

    /// <summary>
    /// Specifies the source location for profile import.
    /// </summary>
    public partial class ImportProfileRequest
    {
        /// <summary>
        /// Initializes a new instance of the ImportProfileRequest class.
        /// </summary>
        public ImportProfileRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ImportProfileRequest class.
        /// </summary>
        /// <param name="path">The file path from which the profile will be
        /// imported.</param>
        public ImportProfileRequest(string path)
        {
            Path = path;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the file path from which the profile will be imported.
        /// </summary>
        [JsonProperty(PropertyName = "path")]
        public string Path { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Path == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Path");
            }
            if (Path != null)
            {
                if (Path.Length < 1)
                {
                    throw new ValidationException(ValidationRules.MinLength, "Path", 1);
                }
            }
        }
    }
}
