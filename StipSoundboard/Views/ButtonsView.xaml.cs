using StipSoundboard.Helpers;
using StipSoundboard.Models;
using System.Collections.Generic;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace StipSoundboard.Views
{
    public sealed partial class ButtonsView : Page
    {
        private readonly SoundPlayHelper _soundPlayHelper;

        public ButtonsView()
        {
            InitializeComponent();

            SetStatusBar();

            CreateButtons(new SoundHelper(BaseUri).GetSounds());
            _soundPlayHelper = new SoundPlayHelper();

            SizeChanged += UpdateButtonHeights;
        }

        private void CreateButtons(IList<Sound> sounds)
        {
            ButtonsGrid.Children.Clear();
            ButtonsGrid.RowDefinitions.Clear();

            var nRows = sounds.Count % 2 == 0 ? sounds.Count / 2 : (sounds.Count / 2) + 1;
            for (int i = 0; i < nRows; i++)
            {
                ButtonsGrid.RowDefinitions.Add(new RowDefinition());
            }

            for (int i = 0; i < sounds.Count - 1; i++)
            {
                var button = CreateButton(sounds[i]);
                button.SetValue(Grid.RowProperty, i / 2);
                button.SetValue(Grid.ColumnProperty, i % 2);

                ButtonsGrid.Children.Add(button);
            }

            var lastButton = CreateButton(sounds[sounds.Count - 1]);
            lastButton.SetValue(Grid.RowProperty, (sounds.Count - 1) / 2);
            if (sounds.Count % 2 == 0)
            {
                lastButton.SetValue(Grid.ColumnProperty, 1);
            }
            else
            {
                lastButton.SetValue(Grid.ColumnProperty, 0);
                lastButton.SetValue(Grid.ColumnSpanProperty, 2);
            }

            ButtonsGrid.Children.Add(lastButton);
        }

        private Button CreateButton(Sound sound)
        {
            var button = new Button
            {
                DataContext = sound,
                Style = Application.Current.Resources["SoundButton"] as Style,
                Content = sound.Name
            };

            button.Click += OnSoundButtonClick;

            return button;
        }

        private void OnSoundButtonClick(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var sound = button.DataContext as Sound;
                if (sound != null)
                {
                    _soundPlayHelper.PlaySoundAsync(sound);
                }
            }
        }

        private void UpdateButtonHeights(object sender, SizeChangedEventArgs eventArgs)
        {
            var buttonHeight = ActualWidth / 2;
            foreach (var child in ButtonsGrid.Children)
            {
                var button = child as Button;
                if (button != null)
                {
                    button.Height = buttonHeight;
                }
            }
        }

        private void SetStatusBar()
        {
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {

                var statusBar = StatusBar.GetForCurrentView();
                if (statusBar != null)
                {
                    statusBar.BackgroundOpacity = 1;
                    statusBar.BackgroundColor = Application.Current.Resources["Red"] as Color?;
                    statusBar.ForegroundColor = Application.Current.Resources["White"] as Color?;
                }
            }
        }
    }
}
