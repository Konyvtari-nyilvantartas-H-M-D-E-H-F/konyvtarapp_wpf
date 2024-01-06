using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using konyvtarMVVM.Models;
using konyvtarMVVM.Service.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.Models;
using KretaBasicSchoolSystem.Desktop.Service.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class BookViewModel : BaseViewModelWithAsyncInitialization
    {

        [ObservableProperty]
        private ObservableCollection<Book> _books = new ObservableCollection<Book>();

        [ObservableProperty]
        private Book _selectedBook;

        private readonly IBookService? _bookService;



        public BookViewModel()
        {
            
            SelectedBook = new Book();

        }
        public BookViewModel(IBookService? bookService)
        {

            SelectedBook = new Book();

            _bookService = bookService;
        }
        public override async Task InitializeAsync()
        {
            if (_bookService is not null)
            {
                List<Book> books = await _bookService.SelectAllBook();
                Books = new ObservableCollection<Book>(books);
            }
        }

        [RelayCommand]
        public void DoSave(Book newBook)
        {
            Books.Add(newBook);
            OnPropertyChanged(nameof(Books));
        }

        [RelayCommand]
        void DoNewBook()
        {
            SelectedBook = new Book();
        }

        [RelayCommand]
        public void DoRemove(Book bookToDelete)
        {
            Books.Remove(bookToDelete);
            OnPropertyChanged(nameof(Books));
        }
    }
}
