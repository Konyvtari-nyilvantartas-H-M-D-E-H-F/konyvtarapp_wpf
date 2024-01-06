using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.Models;
using KretaBasicSchoolSystem.Desktop.Service.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class UserViewModel : BaseViewModelWithAsyncInitialization
    {

        [ObservableProperty]
        private ObservableCollection<User> _users = new ObservableCollection<User>();

        [ObservableProperty]
        private User _selectedUser;

        private readonly IUserService? _userService;
      

       
        public UserViewModel()
        {
            SelectedUser = new User();
            
        }
        public UserViewModel(IUserService? userService)
        {
            //Users.Add(new User(new Guid(), "Elek", "Teszt", "vasvari@valami.org"));
            SelectedUser = new User();

            _userService = userService;
        }
        public override async Task InitializeAsync()
        {
            if (_userService is not null)
            {
                List<User> users = await _userService.SelectAllUser();
                Users = new ObservableCollection<User>(users);
            }
        } 

        [RelayCommand]
        public void DoSave(User newUser)
        {
            Users.Add(newUser);
            OnPropertyChanged(nameof(Users));
        }

        [RelayCommand]
        void DoNewUser()
        {
            SelectedUser = new User();
        }

        [RelayCommand]
        public void DoRemove(User userToDelete)
        {
            Users.Remove(userToDelete);
            OnPropertyChanged(nameof(Users));
        }
    }
}
