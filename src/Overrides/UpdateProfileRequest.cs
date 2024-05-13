// ReSharper disable once CheckNamespace

namespace Kameleo.LocalApiClient.Models
{
    public partial class UpdateProfileRequest
    {
        public UpdateProfileRequest(ProfileResponse profile) : this()
        {
            Canvas = profile.Canvas;
            Webgl = profile.Webgl;
            WebglMeta = new WebglMetaSpoofingTypeWebglMetaSpoofingOptionsMultiLevelChoice(profile.Webgl);
            Audio = profile.Audio;
            Timezone = profile.Timezone;
            Geolocation = profile.Geolocation;
            Proxy = profile.Proxy;
            WebRtc = profile.WebRtc;
            Fonts = profile.Fonts;
            Screen = profile.Screen;
            HardwareConcurrency = profile.HardwareConcurrency;
            PasswordManager = profile.PasswordManager;
            Name = profile.Name;
            DeviceMemory = profile.DeviceMemory;
            StartPage = profile.StartPage;
            Extensions = profile.Extensions;
            Notes = profile.Notes;
            Tags = profile.Tags;
            Storage = profile.Storage;
            Launcher = profile.Launcher;
        }
    }
}
