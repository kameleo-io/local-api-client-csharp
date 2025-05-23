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
    /// Device
    /// </summary>
    [DataContract(Name = "Device")]
    public partial class Device : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Device() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        /// <param name="type">Type of the device. Possible values are: &#39;desktop&#39;, &#39;mobile&#39;. (required).</param>
        /// <param name="name">Name of the device. This is only available for mobile profiles..</param>
        public Device(string type = default(string), string name = default(string))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for Device and cannot be null");
            }
            this.Type = type;
            this.Name = name;
        }

        /// <summary>
        /// Type of the device. Possible values are: &#39;desktop&#39;, &#39;mobile&#39;.
        /// </summary>
        /// <value>Type of the device. Possible values are: &#39;desktop&#39;, &#39;mobile&#39;.</value>
        /*
        <example>desktop</example>
        */
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Name of the device. This is only available for mobile profiles.
        /// </summary>
        /// <value>Name of the device. This is only available for mobile profiles.</value>
        /*
        <example>Samsung SM-A705FN</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Device {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
