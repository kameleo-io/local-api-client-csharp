// ReSharper disable once CheckNamespace
namespace Kameleo.LocalApiClient.Models
{
    public partial class UpdateProfileRequest
    {
        public UpdateProfileRequest(ProfileResponse profile)
            : this(profile.Canvas, profile.Webgl, profile.Audio, profile.Timezone, profile.Geolocation, profile.Proxy, profile.WebRtc, 
                profile.Fonts, profile.Plugins, profile.Screen, profile.StartPage, profile.PasswordManager, profile.Name, profile.Extensions, profile.Notes, profile.Tags, profile.Launcher)
        {
        }
    }
}
