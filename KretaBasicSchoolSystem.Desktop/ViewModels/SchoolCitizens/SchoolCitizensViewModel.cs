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
        private KiadoViewModel _kiadoViewModel;
        private BookViewModel _bookViewModel;

        public SchoolCitizensViewModel()
        {
            IUserService userService = new UserService(null);
            IBookService bookService = new BookService(null);
            IKiadoService kiadoService = new KiadoService(null);
            _userViewModel = new UserViewModel(userService);
            _kiadoViewModel = new KiadoViewModel(kiadoService);
            _bookViewModel = new BookViewModel(bookService);

            CurrentChildViewModel = new UserViewModel();
        }

        public SchoolCitizensViewModel(UserViewModel userViewModel, KiadoViewModel kiadoViewModel, BookViewModel bookViewModel)
        {
            _userViewModel = userViewModel;
            _kiadoViewModel = kiadoViewModel;
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
        public async Task ShowKiadoView()
        {
            await _kiadoViewModel.InitializeAsync();
            CurrentChildViewModel = _kiadoViewModel;
        }
    }
}
