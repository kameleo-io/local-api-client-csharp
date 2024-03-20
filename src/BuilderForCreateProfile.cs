using System;
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
            if (string.IsNullOrEmpty(baseProfileId))
            {
                throw new ArgumentException("baseProfileId must be set", nameof(baseProfileId));
            }

            return new BuilderForCreateProfile(baseProfileId);
        }

        public CreateProfileRequest Build()
        {
            var result = JsonConvert.DeserializeObject<CreateProfileRequest>(JsonConvert.SerializeObject(_profileRequest));
            _profileRequest = Reset(result.BaseProfileId);

            return result;
        }

        /// <summary>
        /// Sets the name of the profile.
        /// </summary>
        /// <param name="value">The name of the profile.</param>
        /// <returns></returns>
        public BuilderForCreateProfile SetName(string value)
        {
            _profileRequest.Name = value;
            return this;
        }

        /// <summary>
        /// Sets the tags of the profile.
        /// </summary>
        /// <param name="value">The tags of the profile.</param>
        /// <returns></returns>
        public BuilderForCreateProfile SetTags(List<string> value)
        {
            _profileRequest.Tags = value;
            return this;
        }

        /// <summary>
        /// <para>Specifies how the canvas will be spoofed. Possible values:</para>
        /// <para>'intelligent': Use intelligent canvas spoofing. This will result non-unique canvas fingerprints.</para>
        /// <para>'noise': Add some noise to canvas generation.</para>
        /// <para>'block': Completely block the 2D API.</para>
        /// <para>'off': Turn off the spoofing, use the original settings.</para>
        /// </summary>
        /// <param name="value">Settings how the WebGL will be spoofed. Values can be 'noise', 'block', 'off'.</param>
        public BuilderForCreateProfile SetCanvas(string value)
        {
            _profileRequest.Canvas = value;

            return this;
        }

        /// <summary>
        /// <para>Set the Webgl spoofing. Possible values:</para>
        /// <para>'noise': Add some noise to the WebGL generation</para>
        /// <para>'block': Completely block the 3D API</para>
        /// <para>'off': Turn off the spoofing, use the original settings</para>
        /// </summary>
        /// <param name="value">Values can be: 'noise', 'block', 'off'</param>
        public BuilderForCreateProfile SetWebgl(string value)
        {
            _profileRequest.Webgl = value;

            return this;
        }

        /// <summary>
        /// <para>Specifies how the WebGL vendor and renderer will be spoofed. Possible values:</para>
        /// <para>'automatic': The vendor and renderer values comes from the base profile.</para>
        /// <para>'manual': Manually set the vendor and renderer values.</para>
        /// <para>'off': Turn off the spoofing, use the original settings.</para>
        /// </summary>
        /// <param name="value">Values can be: 'automatic', 'manual', 'off'</param>
        /// <param name="options">When the WebglMeta spoofing is set to manual the webgl gpu vendor and renderer is required. For example:
        /// Google Inc. (NVIDIA)/ANGLE (NVIDIA, NVIDIA GeForce GTX 1050 Ti Direct3D11 vs_5_0 ps_5_0, D3D11)</param>
        public BuilderForCreateProfile SetWebglMeta(string value, WebglMetaSpoofingOptions options = null)
        {
            _profileRequest.WebglMeta.Value = value;
            _profileRequest.WebglMeta.Extra = options;

            return this;
        }

        /// <summary>
        /// <para>Specifies how the audio will be spoofed. Possible values:</para>
        /// <para>'noise': Add some noise to the Audio generation.</para>
        /// <para>'block': Completely block the Audio API.</para>
        /// <para>'off': Turn off the spoofing, use the original settings.</para>
        /// </summary>
        /// <param name="value">Settings how the Audio will be spoofed. Values can be 'noise', 'block', 'off'.</param>
        public BuilderForCreateProfile SetAudio(string value)
        {
            _profileRequest.Audio = value;
            return this;
        }

        /// <summary>
        /// <para>Specifies how the Timezone will be spoofed. Possble values:</para>
        /// <para>'automatic': Timezone is automatically set by the IP</para>
        /// <para>'manual': Timezone is manually overridden in the profile</para>
        /// <para>'off': Turn off the spoofing, use the original settings</para>
        /// </summary>
        /// <param name="value">Values can be: 'automatic', 'manual', 'off'</param>
        /// <param name="options">When the Timezone spoofing is set to manual the
        /// timezone in Iana format is required. For example:
        /// America/Grenada</param>
        public BuilderForCreateProfile SetTimezone(string value, string options = null)
        {
            _profileRequest.Timezone.Value = value;
            _profileRequest.Timezone.Extra = options;

            return this;
        }

        /// <summary>
        /// <para>Specifies how the Geolocation will be spoofed. Possible values:</para>
        /// <para>'automatic': Automatically set the values based on the IP address</para>
        /// <para>'manual': Manually set the longitude and latitude in the profile</para>
        /// <para>'block': Completely block the Geolocation API</para>
        /// <para>'off': Turn off the spoofing, use the original settings</para>
        /// </summary>
        /// <param name="value">Values can be 'automatic', 'manual', 'off'.</param>
        public BuilderForCreateProfile SetGeolocation(string value, GeolocationSpoofingOptions options = null)
        {
            _profileRequest.Geolocation.Value = value;
            _profileRequest.Geolocation.Extra = options;

            return this;
        }

        /// <summary>
        /// <para>Proxy connection settings of the profiles. Possible values:</para>
        /// <para>'none': Direct connection without any proxy.</para>
        /// <para>'http': Use a HTTP(S) proxy for upstream communication.</para>
        /// <para>'socks5': Use a SOCKS5 proxy for upstream communication.</para>
        /// <para>'ssh': Use an SSH connection for upstream communication. Basically a SOCKS5 proxy created at the given SSH host.</para>
        /// </summary>
        /// <param name="value">Proxy connection settings of the profiles. Values can be 'none', 'http', 'socks5', 'ssh'. When it is not set to none, a server is provided.</param>
        public BuilderForCreateProfile SetProxy(string value, Server options = null)
        {
            _profileRequest.Proxy.Value = value;
            _profileRequest.Proxy.Extra = options;

            return this;
        }

        /// <summary>
        /// <para>Specifies how WebRTC will be spoofed. Possible values:</para>
        /// <para>'automatic': Automatically set the webRTC public IP by the IP, and generates a random private IP like '2d2f78e7-1b1e-4345-a21b-07c904c98394.local'</para>
        /// <para>'manual': Manually override the webRTC public IP and private IP in the profile</para>
        /// <para>'block': Block the WebRTC functionality</para>
        /// <para>'off': Turn off the spoofing, use the original settings</para>
        /// </summary>
        /// <param name="value">Settings how the WebRTC will be spoofed. Values can be 'automatic', 'manual', 'block', 'off'.</param>
        public BuilderForCreateProfile SetWebRtc(string value, WebRtcSpoofingOptions options = null)
        {
            _profileRequest.WebRtc.Value = value;
            _profileRequest.WebRtc.Extra = options;

            return this;
        }

        /// <summary>
        /// <para>Specifies how the Fonts will be spoofed. Possible values:</para>
        /// <para>'enabled': Enable fonts spoofing. A list can be provided to override the fonts coming from the base profile.</para>
        /// <para>'disable': Disable fonts spoofing.</para>
        /// </summary>
        /// <param name="value">Settings how the Fonts will be spoofed. Values can be 'enabled', 'disabled'.</param>
        /// <param name="options">If value is set to enabled, an override list can be provided.</param>
        public BuilderForCreateProfile SetFonts(string value, IList<string> options = null)
        {
            _profileRequest.Fonts.Value = value;
            _profileRequest.Fonts.Extra = options;

            return this;
        }

        /// <summary>
        /// This website will be opened in the browser when the profile launches.
        /// </summary>
        /// <param name="value">This website will be opened in the browser when the profile launches.</param>
        public BuilderForCreateProfile SetStartPage(string value)
        {
            _profileRequest.StartPage = value;

            return this;
        }

        /// <summary>
        /// <para>Enable or disable the password manager function in the browser. Possible values:</para>
        /// <para>'enabled': Enable password manager so browser will ask to save and load passwords on logins.</para>
        /// <para>'disable': Disable password manager.</para>
        /// </summary>
        /// <param name="value">Enable or disable the password manager function in the browser. Values can be 'enabled', 'disable'.</param>
        public BuilderForCreateProfile SetPasswordManager(string value)
        {
            _profileRequest.PasswordManager = value;

            return this;
        }

        /// <summary>
        /// <para>Specifies how the screen will be spoofed. Possible values:</para>
        /// <para>'automatic': Automatically override the screen resolution based on the Base Profile.</para>
        /// <para>'manual': Manually override the screen resolution.</para>
        /// <para>'off': Turn off the spoofing, use the original settings.</para>
        /// </summary>
        /// <param name="value">Settings how the Screen will be spoofed. Values can be 'automatic', 'manual', 'off'. When value is set to manual, the width and height must be provided.</param>
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

        /// <summary>
        /// <para>Specifies how the HardwareConcurrency will be spoofed. Possible values:</para>
        /// <para>'automatic': Automatically override the HardwareConcurrency based on the Base Profile.</para>
        /// <para>'manual': Manually override the HardwareConcurrency. Valid values: 1,2,4,8,16.</para>
        /// <para>'off': Turn off the spoofing, use the original settings.</para>
        /// </summary>
        public BuilderForCreateProfile SetHardwareConcurrency(string value, int? options = null)
        {
            _profileRequest.HardwareConcurrency.Value = value;
            _profileRequest.HardwareConcurrency.Extra = options;

            return this;
        }

        /// <summary>
        /// <para>Specifies how the DeviceMemory will be spoofed. Possible values:</para>
        /// <para>'automatic': Automatically override the DeviceMemory based on the Base Profile.</para>
        /// <para>'manual': Manually override the DeviceMemory. Valid values: 0.25, 0.5, 1, 2, 4, 8.</para>
        /// <para>'off': Turn off the spoofing, use the original settings.</para>
        /// </summary>
        public BuilderForCreateProfile SetDeviceMemory(string value, double? options = null)
        {
            _profileRequest.DeviceMemory.Value = value;
            _profileRequest.DeviceMemory.Extra = options;

            return this;
        }

        /// <summary>
        /// A list of abolute paths from where the profile should load extensions or addons when starting the browser. For chrome and edge use CRX3 format extensions. For firefox use signed xpi format addons.
        /// </summary>
        public BuilderForCreateProfile SetExtensions(IList<string> absolutePaths)
        {
            _profileRequest.Extensions = absolutePaths;

            return this;
        }

        /// <summary>
        /// A free text including any notes written by the user.
        /// </summary>
        public BuilderForCreateProfile SetNotes(string notes)
        {
            _profileRequest.Notes = notes;

            return this;
        }

        /// <summary>
        /// <para> The mode how the profile should be launched. It determines which browser to launch. This cannot be modified after creation. </para>
        /// <para> Possible values for Desktop profiles 'automatic'. </para>
        /// <para> Possible values for Mobile profiles: 'chromium', 'external'. </para>
        /// </summary>
        /// <param name="browserLauncher">The mode how the profile should be launched. It determines which browser to launch. Possible values for Desktop profiles 'automatic'. Possible values for Mobile profiles: 'chromium', 'external'. </param>
        public BuilderForCreateProfile SetLauncher(string browserLauncher)
        {
            _profileRequest.Launcher = browserLauncher;

            return this;
        }

        /// <summary>
        /// This sets all the profile options to the defaults recommended by Kameleo Team. Please consider providing Proxy settings to your profile.
        /// </summary>
        public BuilderForCreateProfile SetRecommendedDefaults()
        {
            _profileRequest.Name = "";
            _profileRequest.Canvas = "intelligent";
            _profileRequest.Webgl = "off";
            _profileRequest.WebglMeta.Value = "automatic";
            _profileRequest.Audio = "off";
            _profileRequest.Timezone.Value = "automatic";
            _profileRequest.Geolocation.Value = "automatic";
            _profileRequest.WebRtc.Value = "automatic";
            _profileRequest.Screen.Value = "automatic";
            _profileRequest.Fonts.Value = "enabled";
            _profileRequest.HardwareConcurrency.Value = "automatic";
            _profileRequest.DeviceMemory.Value = "automatic";
            _profileRequest.Launcher = "automatic";

            return this;
        }

        private static CreateProfileRequest Reset(string baseProfileId)
        {
            return new CreateProfileRequest
            {
                BaseProfileId = baseProfileId,
                Canvas = "off",
                Webgl = "off",
                WebglMeta = new WebglMetaSpoofingTypeWebglMetaSpoofingOptionsMultiLevelChoice("off"),
                Audio = "off",
                Timezone = new TimezoneSpoofingTypeTimezoneMultiLevelChoice("off"),
                Geolocation = new GeolocationSpoofingTypeGeolocationSpoofingOptionsMultiLevelChoice("off"),
                Proxy = new ProxyConnectionTypeServerMultiLevelChoice("none"),
                WebRtc = new WebRtcSpoofingTypeWebRtcSpoofingOptionsMultiLevelChoice("off"),
                Fonts = new FontSpoofingTypeFontIListMultiLevelChoice("disabled"),
                Screen = new ScreenSpoofingTypeScreenSizeMultiLevelChoice("off"),
                HardwareConcurrency = new HardwareConcurrencySpoofingTypeInt32NullableMultiLevelChoice("off"),
                DeviceMemory = new DeviceMemorySpoofingTypeDoubleNullableMultiLevelChoice("off"),
                PasswordManager = "disabled",
            };
        }
    }
}
