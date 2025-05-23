﻿/*
 * kameleo-local-api
 *
 * You can use the following API endpoints to communicate with the local running Kameleo programmatically.
 *
 * The version of the OpenAPI document: v1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Kameleo.LocalApiClient.Client.OpenAPIDateConverter;

namespace Kameleo.LocalApiClient.Model
{
    /// <summary>
    /// Provides a summarized view of a fingerprint, which encapsulates real-world browser fingerprint configurations used to  instantiate virtual browser profiles. This preview aids in selecting the appropriate fingerprint from hundreds of thousands available.
    /// </summary>
    [DataContract(Name = "FingerprintPreview")]
    public partial class FingerprintPreview : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FingerprintPreview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FingerprintPreview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FingerprintPreview" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the fingerprint. You can use this as a reference to create a new profile from this fingerprint. (required).</param>
        /// <param name="device">device (required).</param>
        /// <param name="os">os (required).</param>
        /// <param name="browser">browser (required).</param>
        /// <param name="webglMeta">webglMeta (required).</param>
        public FingerprintPreview(string id = default(string), Device device = default(Device), Os os = default(Os), Browser browser = default(Browser), WebglMeta webglMeta = default(WebglMeta))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FingerprintPreview and cannot be null");
            }
            this.Id = id;
            // to ensure "device" is required (not null)
            if (device == null)
            {
                throw new ArgumentNullException("device is a required property for FingerprintPreview and cannot be null");
            }
            this.Device = device;
            // to ensure "os" is required (not null)
            if (os == null)
            {
                throw new ArgumentNullException("os is a required property for FingerprintPreview and cannot be null");
            }
            this.Os = os;
            // to ensure "browser" is required (not null)
            if (browser == null)
            {
                throw new ArgumentNullException("browser is a required property for FingerprintPreview and cannot be null");
            }
            this.Browser = browser;
            // to ensure "webglMeta" is required (not null)
            if (webglMeta == null)
            {
                throw new ArgumentNullException("webglMeta is a required property for FingerprintPreview and cannot be null");
            }
            this.WebglMeta = webglMeta;
        }

        /// <summary>
        /// The unique identifier of the fingerprint. You can use this as a reference to create a new profile from this fingerprint.
        /// </summary>
        /// <value>The unique identifier of the fingerprint. You can use this as a reference to create a new profile from this fingerprint.</value>
        /*
        <example>BPID1CC227DG69B5M56E5DE4TW8P48B47NB8BB5967XEA501UZXP019FZGOX4A61</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Device
        /// </summary>
        [DataMember(Name = "device", IsRequired = true, EmitDefaultValue = true)]
        public Device Device { get; set; }

        /// <summary>
        /// Gets or Sets Os
        /// </summary>
        [DataMember(Name = "os", IsRequired = true, EmitDefaultValue = true)]
        public Os Os { get; set; }

        /// <summary>
        /// Gets or Sets Browser
        /// </summary>
        [DataMember(Name = "browser", IsRequired = true, EmitDefaultValue = true)]
        public Browser Browser { get; set; }

        /// <summary>
        /// Gets or Sets WebglMeta
        /// </summary>
        [DataMember(Name = "webglMeta", IsRequired = true, EmitDefaultValue = true)]
        public WebglMeta WebglMeta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FingerprintPreview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Device: ").Append(Device).Append("\n");
            sb.Append("  Os: ").Append(Os).Append("\n");
            sb.Append("  Browser: ").Append(Browser).Append("\n");
            sb.Append("  WebglMeta: ").Append(WebglMeta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
