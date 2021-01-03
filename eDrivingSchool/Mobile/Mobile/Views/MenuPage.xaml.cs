using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        private readonly APIService _service = new APIService("Users");
        UserSearchRequest request = new UserSearchRequest();
        public MenuPage()
        {
            InitializeComponent();
            /*
            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                 new HomeMenuItem {Id = MenuItemType.YourProfile, Title="Your Profile" },
                  new HomeMenuItem {Id = MenuItemType.Forum, Title="Forum" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };*/
        }

        
        protected async override void OnAppearing()
        {
            base.OnAppearing();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                 new HomeMenuItem {Id = MenuItemType.YourProfile, Title="Your Profile" },
                  new HomeMenuItem {Id = MenuItemType.Forum, Title="Forum" },
                   new HomeMenuItem {Id = MenuItemType.TheoryTestApplications, Title="Theory test applications" }
            };

           

            request.Username = APIService.Username;
            var list = await _service.GetAll<List<User>>(request);
            var user = list[0];
            if(user.RoleId == 3)
            {
                menuItems.Add(new HomeMenuItem { Id = MenuItemType.Certificates, Title = "Certificates" });
            }

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };

        }

            
       

    }
}