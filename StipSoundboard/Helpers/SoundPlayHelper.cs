using StipSoundboard.Models;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml.Controls;
using System;
using Windows.UI.Core;

namespace StipSoundboard.Helpers
{
    public class SoundPlayHelper
    {
        private const string Mp3Extension = ".mp3";

        private readonly MediaElement _mediaElement;
        private StorageFolder _soundFilesFolder;

        public SoundPlayHelper()
        {
            _mediaElement = new MediaElement { AutoPlay = true };
            _soundFilesFolder = Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets\SoundFiles").AsTask().Result;
        }

        public async Task PlaySoundAsync(Sound sound)
        {
            await Task.Run(async () =>
            {
                var soundFile = await _soundFilesFolder.GetFileAsync($"{sound.FileName}{Mp3Extension}");
                var openSoundStream = await soundFile.OpenReadAsync();
                await _mediaElement.Dispatcher.RunAsync(CoreDispatcherPriority.High, () =>
                {
                    _mediaElement.SetSource(openSoundStream, soundFile.ContentType);
                });
            });
        }
    }
}
