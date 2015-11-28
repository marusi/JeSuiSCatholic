using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using JeSuiSCatholic;


using Windows.UI.Xaml.Media.Media3D;




// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace JeSuiSCatholic
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Prayer : Page
    {
        private MainPage rootPage;

        public Prayer()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            rootPage = MainPage.Current;
        }

        /*
         * This is where the magic happens!
         *
         * We need to do two things:
         *
         *   1. Make sure that the center of the perspective transform and image transform are
         *   the same. To do this, we manually set the center of the image transform to
         *   the center of ParallaxRoot, which is the center of the perspective transform by default.
         *
         *   2. Scale up the element to compensate for the perspective effect. This will make the
         *   transformed element appear like the source asset even though it is "further away" from the
         *   viewer than the foreground. The formula for this is:
         *      
         *      scaleFactor = -translateZ / perspectiveDepth + 1.0
         *   
         */
        private void NormalizeParallax(UIElement target)
        {
            var transform = target.Transform3D as CompositeTransform3D;

            if (transform != null)
            {
                var transformToVisual = ParallaxRoot.TransformToVisual(target);
                var center = new Point(ParallaxRoot.ActualWidth / 2.0, RootGrid.ActualHeight / 2.0);

                // Center of ParallaxRoot in the coordinates of target.
                var transformedCenter = transformToVisual.TransformPoint(center);

                transform.CenterX = transformedCenter.X;

                // TransformToVisual doesn't account for ScrollViewer offset
                transform.CenterY = transformedCenter.Y - ParallaxRoot.VerticalOffset;

                // This could be done statically in markup but it's easier to show here.
                transform.ScaleX = transform.ScaleY =
                    -transform.TranslateZ / PerspectiveTransform.Depth + 1.0;
            }
        }

        private void RootGrid_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            NormalizeParallax(RainierBackgroundImage);
            NormalizeParallax(CliffBackgroundImage);
        }

       
       
    }
}