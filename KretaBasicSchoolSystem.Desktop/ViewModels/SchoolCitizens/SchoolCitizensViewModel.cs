using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using KretaBasicSchoolSystem.Desktop.Service.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private UserViewModel _userViewModel;
        private ParentViewModel _parentViewModel;
        private TeacherViewModel _teacherViewModel;

        public SchoolCitizensViewModel()
        {
            IUserService userService = new UserService(null);
            _userViewModel = new UserViewModel(userService);
            _parentViewModel = new ParentViewModel();
            _teacherViewModel = new TeacherViewModel();

            CurrentChildViewModel = new UserViewModel();
        }

        public SchoolCitizensViewModel(UserViewModel userViewModel, ParentViewModel parentViewModel, TeacherViewModel teacherViewModel)
        {
            _userViewModel = userViewModel;
            _parentViewModel = parentViewModel;
            _teacherViewModel = teacherViewModel;

            CurrentChildViewModel = new UserViewModel();
        }

        [ObservableProperty]
        private BaseViewModel _currentChildViewModel;

        [RelayCommand]
        public async Task ShowUserView()
        {
            await _userViewModel.InitializeAsync();
            CurrentChildViewModel = _userViewModel;
        }


        [RelayCommand]
        public void ShowTeacherView()
        {
            CurrentChildViewModel = _teacherViewModel;
        }

        [RelayCommand]
        public void ShowParentView()
        {
            CurrentChildViewModel = _parentViewModel;
        }
    }
}
