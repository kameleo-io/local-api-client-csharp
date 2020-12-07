using System.Collections.Generic;
using Kameleo.LocalApiClient.Models;
using Newtonsoft.Json;

namespace Kameleo.LocalApiClient
{
    public class BuilderForCreateProfile
    {
        private CreateProfileRequest _profileRequest;

        private BuilderForCreateProfile(string baseProfileId)
        {
            _profileRequest = Reset(baseProfileId);
        }

        public static BuilderForCreateProfile ForBaseProfile(string baseProfileId)
        {
            return new BuilderForCreateProfile(baseProfileId);
        }

        public CreateProfileRequest Build()
        {
            var result = JsonConvert.DeserializeObject<CreateProfileRequest>(JsonConvert.SerializeObject(_profileRequest));
            _profileRequest = Reset(result.BaseProfileId);

            return result;
        }

        public BuilderForCreateProfile SetCanvas(string value)
        {
            _profileRequest.Canvas = value;

            return this;
        }

        public BuilderForCreateProfile SetWebgl(string value, WebglSpoofingOptions options = null)
        {
            _profileRequest.Webgl.Value = value;
            _profileRequest.Webgl.Extra = options;

            return this;
        }

        public BuilderForCreateProfile SetTimezone(string value, string options = null)
        {
            _profileRequest.Timezone.Value = value;
            _profileRequest.Timezone.Extra = options;

            return this;
        }

        public BuilderForCreateProfile SetGeolocation(string value, GeolocationSpoofingOptions options = null)
        {
            _profileRequest.Geolocation.Value = value;
            _profileRequest.Geolocation.Extra = options;

            return this;
        }

        public BuilderForCreateProfile SetProxy(string value, Server options = null)
        {
            _profileRequest.Proxy.Value = value;
            _profileRequest.Proxy.Extra = options;

            return this;
        }

        public BuilderForCreateProfile SetWebRtc(string value, WebRtcSpoofingOptions options = null)
        {
            _profileRequest.WebRtc.Value = value;
            _profileRequest.WebRtc.Extra = options;

            return this;
        }

        public BuilderForCreateProfile SetFonts(string value, IList<string> options = null)
        {
            _profileRequest.Fonts.Value = value;
            _profileRequest.Fonts.Extra = options;

            return this;
        }

        public BuilderForCreateProfile SetPlugins(string value, IList<string> options = null)
        {
            _profileRequest.Plugins.Value = value;
            _profileRequest.Plugins.Extra = options;

            return this;
        }

        public BuilderForCreateProfile SetStartPage(string value)
        {
            _profileRequest.StartPage = value;

            return this;
        }

        public BuilderForCreateProfile SetScreen(string value, int? width = null, int? height = null)
        {
            _profileRequest.Screen.Value = value;
            if (width == null || height == null)
            {
                _profileRequest.Screen.Extra = null;
            }
            else
            {
                _profileRequest.Screen.Extra = $"{width}x{height}";
            }
            
            return this;
        }

        public BuilderForCreateProfile SetExtensions(IList<string> absolutePaths)
        {
            _profileRequest.Extensions = absolutePaths;

            return this;
        }

        public BuilderForCreateProfile SetNotes(string notes)
        {
            _profileRequest.Notes = notes;

            return this;
        }

        public BuilderForCreateProfile SetLauncher(string browserLauncher)
        {
            _profileRequest.Launcher = browserLauncher;

            return this;
        }

        public BuilderForCreateProfile SetRecommendedDefaults()
        {
            _profileRequest.Canvas = "noise";
            _profileRequest.Webgl.Value = "noise";
            _profileRequest.Timezone.Value = "automatic";
            _profileRequest.Geolocation.Value = "automatic";
            _profileRequest.WebRtc.Value = "automatic";
            _profileRequest.Screen.Value = "automatic";
            _profileRequest.Launcher = "automatic";

            return this;
        }

        private static CreateProfileRequest Reset(string baseProfileId)
        {
            return new CreateProfileRequest
            {
                BaseProfileId = baseProfileId,
                Canvas = "off",
                Webgl = new WebglSpoofingTypeWebglSpoofingOptionsMultiLevelChoice("off"),
                Timezone = new TimezoneSpoofingTypeTimezoneMultiLevelChoice("off"),
                Geolocation = new GeolocationSpoofingTypeGeolocationSpoofingOptionsMultiLevelChoice("off"),
                Proxy = new ProxyConnectionTypeServerMultiLevelChoice("none"),
                WebRtc = new WebRtcSpoofingTypeWebRtcSpoofingOptionsMultiLevelChoice("off"),
                Fonts = new FontSpoofingTypeFontIListMultiLevelChoice("disabled"),
                Plugins = new PluginSpoofingTypePluginIListMultiLevelChoice("disabled"),
                Screen = new ScreenSpoofingTypeScreenSizeMultiLevelChoice("off"),
            };
        }
    }
}
