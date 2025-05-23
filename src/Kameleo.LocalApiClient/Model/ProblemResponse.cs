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
    /// ProblemResponse
    /// </summary>
    [DataContract(Name = "ProblemResponse")]
    public partial class ProblemResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProblemResponse" /> class.
        /// </summary>
        /// <param name="code">code.</param>
        /// <param name="error">error.</param>
        public ProblemResponse(int? code = default(int?), Dictionary<string, List<string>> error = default(Dictionary<string, List<string>>))
        {
            this.Code = code;
            this.Error = error;
        }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public int? Code { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProblemResponse {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
