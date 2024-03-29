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

    public partial class UserInfoResponse
    {
        /// <summary>
        /// Initializes a new instance of the UserInfoResponse class.
        /// </summary>
        public UserInfoResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserInfoResponse class.
        /// </summary>
        /// <param name="userId">The guid of the user.</param>
        /// <param name="email">The email address of the authenticated
        /// user.</param>
        /// <param name="emailConfirmed">A boolean value indicating whether the
        /// email address is confirmed.</param>
        /// <param name="subscriptionEnd">The end date of the authenticated
        /// user's current subscription.</param>
        /// <param name="capabilities">The capabilities that the authenticated
        /// user owns thanks to his current subscription.</param>
        /// <param name="gracePeriod">A boolean value indicates whether the
        /// subscription is in a grace period and should be renewed
        /// immediately.</param>
        /// <param name="lastAppLogin">The last date when the user
        /// authenticated by the app.</param>
        /// <param name="workspaceFolder">The user's workspace folder path
        /// where the profiles are stored.</param>
        public UserInfoResponse(System.Guid userId, string email, bool emailConfirmed, System.DateTime subscriptionEnd, IList<string> capabilities, bool gracePeriod, System.DateTime lastAppLogin, string workspaceFolder, QuotaStatistics localStorage, QuotaStatistics cloudStorage)
        {
            UserId = userId;
            Email = email;
            EmailConfirmed = emailConfirmed;
            SubscriptionEnd = subscriptionEnd;
            Capabilities = capabilities;
            GracePeriod = gracePeriod;
            LastAppLogin = lastAppLogin;
            WorkspaceFolder = workspaceFolder;
            LocalStorage = localStorage;
            CloudStorage = cloudStorage;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the guid of the user.
        /// </summary>
        [JsonProperty(PropertyName = "userId")]
        public System.Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the email address of the authenticated user.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicating whether the email address
        /// is confirmed.
        /// </summary>
        [JsonProperty(PropertyName = "emailConfirmed")]
        public bool EmailConfirmed { get; set; }

        /// <summary>
        /// Gets or sets the end date of the authenticated user's current
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "subscriptionEnd")]
        public System.DateTime SubscriptionEnd { get; set; }

        /// <summary>
        /// Gets or sets the capabilities that the authenticated user owns
        /// thanks to his current subscription.
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<string> Capabilities { get; set; }

        /// <summary>
        /// Gets or sets a boolean value indicates whether the subscription is
        /// in a grace period and should be renewed immediately.
        /// </summary>
        [JsonProperty(PropertyName = "gracePeriod")]
        public bool GracePeriod { get; set; }

        /// <summary>
        /// Gets or sets the last date when the user authenticated by the app.
        /// </summary>
        [JsonProperty(PropertyName = "lastAppLogin")]
        public System.DateTime LastAppLogin { get; set; }

        /// <summary>
        /// Gets or sets the user's workspace folder path where the profiles
        /// are stored.
        /// </summary>
        [JsonProperty(PropertyName = "workspaceFolder")]
        public string WorkspaceFolder { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "localStorage")]
        public QuotaStatistics LocalStorage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "cloudStorage")]
        public QuotaStatistics CloudStorage { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Email == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Email");
            }
            if (Capabilities == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Capabilities");
            }
            if (WorkspaceFolder == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "WorkspaceFolder");
            }
            if (LocalStorage == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LocalStorage");
            }
            if (CloudStorage == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "CloudStorage");
            }
            if (LocalStorage != null)
            {
                LocalStorage.Validate();
            }
            if (CloudStorage != null)
            {
                CloudStorage.Validate();
            }
        }
    }
}
