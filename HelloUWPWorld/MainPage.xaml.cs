using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloUWPWorld
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private object _imgAvatar;

        public MainPage()
        {
            this.InitializeComponent();
        }
        /// <summary>
        /// Shows the image avatar!
        /// </summary>
        /// <param name="sender">the hello world button</param>
        /// <param name="e">not used</param>
        private void OnShowAvatar(object sender, RoutedEventArgs e)
        {
            // Show the image control
            _imgAvatar.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender">the _imgAvatar control</param>
        /// <param name="e">not used</param>
        private void OnImageAvatarTap(object sender, TappedRoutedEventArgs e)
        {
            // Obtain the image object to show the image control
            BitmapImage avatarImage = _imgAvatar.Source as BitmapImage;      // Turqouise mean it's a class
            // avatarImage is the variable name, after the equal sign, is the value. BitmapImage is the type of the variable, like an int, but instead its a class.
            
            // Check if the image is animated
            /*
             Cubes mean methods, lightning bolts mean events, the ranch/tool thingy mean properties I think
             */ 
            if (avatarImage.IsAnimatedBitmap)  //Don't need to say == true, because it is already the thing
            {
                // Toggle the animation state of the image
                // Check if the image is playing
                if (avatarImage.IsPlaying)
                {
                    // If the image is playing then stop it.
                    avatarImage.Stop();
                }
                else
                {
                    // If the image is not playing, play it!
                    avatarImage.Play();
                }






            }
        }
    }
}
