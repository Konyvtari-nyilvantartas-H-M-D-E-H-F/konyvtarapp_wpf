using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using konyvtarMVVM.Service.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Service.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class SchoolCitizensViewModel : BaseViewModel
    {
        private UserViewModel _userViewModel;
        private ParentViewModel _parentViewModel;
        private BookViewModel _bookViewModel;

        public SchoolCitizensViewModel()
        {
            IUserService userService = new UserService(null);
            IBookService bookService = new BookService(null);
            _userViewModel = new UserViewModel(userService);
            _parentViewModel = new ParentViewModel();
            _bookViewModel = new BookViewModel(bookService);

            CurrentChildViewModel = new UserViewModel();
        }

        public SchoolCitizensViewModel(UserViewModel userViewModel, ParentViewModel parentViewModel, BookViewModel bookViewModel)
        {
            _userViewModel = userViewModel;
            _parentViewModel = parentViewModel;
            _bookViewModel = bookViewModel;

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
        public async Task ShowBookView()
        {
            await _bookViewModel.InitializeAsync();
            CurrentChildViewModel = _bookViewModel;
        }

        [RelayCommand]
        public void ShowParentView()
        {
            CurrentChildViewModel = _parentViewModel;
        }
    }
}
