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
    /// TimezoneChoice
    /// </summary>
    [DataContract(Name = "TimezoneChoice")]
    public partial class TimezoneChoice : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public TimezoneSpoofingType Value { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneChoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TimezoneChoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneChoice" /> class.
        /// </summary>
        /// <param name="value">value (required).</param>
        /// <param name="extra">When the Timezone spoofing is set to manual the timezone in Iana format is required. For example: America/Grenada.</param>
        public TimezoneChoice(TimezoneSpoofingType value = default(TimezoneSpoofingType), string extra = default(string))
        {
            this.Value = value;
            this.Extra = extra;
        }

        /// <summary>
        /// When the Timezone spoofing is set to manual the timezone in Iana format is required. For example: America/Grenada
        /// </summary>
        /// <value>When the Timezone spoofing is set to manual the timezone in Iana format is required. For example: America/Grenada</value>
        [DataMember(Name = "extra", EmitDefaultValue = true)]
        public string Extra { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TimezoneChoice {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Extra: ").Append(Extra).Append("\n");
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
