using System;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;

namespace SlideImage
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            List<dynamic> dynamics = new List<dynamic>();
            
            // 원본이미지 경로
            // http://www.123mobilewallpapers.com/wp-content/uploads/2016/02/sweet_valentines_day_coffee_heart.jpg
            dynamics.Add(new { ImageSrc = "image1.jpg" });

            // http://www.123mobilewallpapers.com/wp-content/uploads/2014/10/need_more_coffee.jpg
            dynamics.Add(new { ImageSrc = "image2.jpg" });

            // http://www.123mobilewallpapers.com/wp-content/uploads/2015/02/valentine_couples_coffee.png
            dynamics.Add(new { ImageSrc = "image3.png" });

            this.mainView.ItemsSource = dynamics;

            // 3초 간격으로 자동 스크롤이 되도록 합니다.
            Device.StartTimer(TimeSpan.FromSeconds(3), (Func<bool>)(() =>
            {
                this.mainView.Position = (this.mainView.Position + 1) % 3;

                return true;
            }));
        }

        // 각 메뉴 클릭 이벤트입니다.
        private void StoreButton_Clicked(object sender, EventArgs e)
        {
        }

        private void MenuButton_Clicked(object sender, EventArgs e)
        {
        }

        private void CartButton_Clicked(object sender, EventArgs e)
        {
        }

        private void PersonButton_Clicked(object sender, EventArgs e)
        {
        }
    }
}
