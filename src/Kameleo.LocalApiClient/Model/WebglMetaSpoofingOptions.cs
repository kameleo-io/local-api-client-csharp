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
    /// When the WebGL Meta spoofing is used, these settings can override the values in the fingerprint.
    /// </summary>
    [DataContract(Name = "WebglMetaSpoofingOptions")]
    public partial class WebglMetaSpoofingOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebglMetaSpoofingOptions" /> class.
        /// </summary>
        /// <param name="vendor">Unmasked vendor.</param>
        /// <param name="renderer">Unmasked renderer.</param>
        public WebglMetaSpoofingOptions(string vendor = default(string), string renderer = default(string))
        {
            this.Vendor = vendor;
            this.Renderer = renderer;
        }

        /// <summary>
        /// Unmasked vendor
        /// </summary>
        /// <value>Unmasked vendor</value>
        /*
        <example>Google Inc.</example>
        */
        [DataMember(Name = "vendor", EmitDefaultValue = true)]
        public string Vendor { get; set; }

        /// <summary>
        /// Unmasked renderer
        /// </summary>
        /// <value>Unmasked renderer</value>
        /*
        <example>ANGLE (Intel(R) HD Graphics 630 Direct3D11 vs_5_0 ps_5_0)</example>
        */
        [DataMember(Name = "renderer", EmitDefaultValue = true)]
        public string Renderer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebglMetaSpoofingOptions {\n");
            sb.Append("  Vendor: ").Append(Vendor).Append("\n");
            sb.Append("  Renderer: ").Append(Renderer).Append("\n");
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
