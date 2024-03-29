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
    /// Status information about the profile
    /// </summary>
    public partial class StatusResponse
    {
        /// <summary>
        /// Initializes a new instance of the StatusResponse class.
        /// </summary>
        public StatusResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StatusResponse class.
        /// </summary>
        /// <param name="persistenceState">Possible values include: 'unsaved',
        /// 'saved', 'syncing'</param>
        /// <param name="lifetimeState">Possible values include: 'created',
        /// 'starting', 'running', 'terminating', 'terminated', 'locked',
        /// 'unknown'</param>
        /// <param name="externalSpoofingEnginePort">In case of running
        /// profiles which use an external browser this shows the connection
        /// port (for mobile profiles as well).</param>
        public StatusResponse(string persistenceState, string lifetimeState, int? externalSpoofingEnginePort = default(int?))
        {
            PersistenceState = persistenceState;
            LifetimeState = lifetimeState;
            ExternalSpoofingEnginePort = externalSpoofingEnginePort;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'unsaved', 'saved', 'syncing'
        /// </summary>
        [JsonProperty(PropertyName = "persistenceState")]
        public string PersistenceState { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'created', 'starting',
        /// 'running', 'terminating', 'terminated', 'locked', 'unknown'
        /// </summary>
        [JsonProperty(PropertyName = "lifetimeState")]
        public string LifetimeState { get; set; }

        /// <summary>
        /// Gets or sets in case of running profiles which use an external
        /// browser this shows the connection port (for mobile profiles as
        /// well).
        /// </summary>
        [JsonProperty(PropertyName = "externalSpoofingEnginePort")]
        public int? ExternalSpoofingEnginePort { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PersistenceState == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PersistenceState");
            }
            if (LifetimeState == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LifetimeState");
            }
        }
    }
}
