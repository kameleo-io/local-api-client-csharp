// ReSharper disable once CheckNamespace
namespace Kameleo.LocalApiClient.Models
{
    public partial class UpdateProfileRequest
    {
        public UpdateProfileRequest(ProfileResponse profile)
            : this(
                profile.Canvas,
                profile.Webgl,
                new WebglMetaSpoofingTypeWebglMetaSpoofingOptionsMultiLevelChoice(profile.Webgl),
                profile.Audio,
                profile.Timezone,
                profile.Geolocation,
                profile.Proxy,
                profile.WebRtc,
                profile.Fonts,
                profile.Screen,
                profile.HardwareConcurrency,
                profile.PasswordManager,
                profile.Name,
                profile.DeviceMemory,
                profile.StartPage,
                profile.Extensions,
                profile.Notes,
                profile.Tags,
                profile.Launcher
            ) { }
    }
}
