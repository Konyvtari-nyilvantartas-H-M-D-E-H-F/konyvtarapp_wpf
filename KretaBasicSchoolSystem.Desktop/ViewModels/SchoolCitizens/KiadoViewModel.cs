using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using konyvtarMVVM.Models;
using konyvtarMVVM.Service.SchoolCitizens;
using KretaBasicSchoolSystem.Desktop.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KretaBasicSchoolSystem.Desktop.ViewModels.SchoolCitizens
{
    public partial class KiadoViewModel : BaseViewModelWithAsyncInitialization
    {
        [ObservableProperty]
        private ObservableCollection<Kiado> _kiadok = new ObservableCollection<Kiado>();

        [ObservableProperty]
        private Kiado _selectedKiado;

        private readonly IKiadoService? _kiadoService;



        public KiadoViewModel()
        {

            SelectedKiado = new Kiado();

        }
        public KiadoViewModel(IKiadoService? kiadoService)
        {

            SelectedKiado = new Kiado();

            _kiadoService = kiadoService;
        }
        public override async Task InitializeAsync()
        {
            if (_kiadoService is not null)
            {
                List<Kiado> kiadok = await _kiadoService.SelectAllKiado();
                Kiadok = new ObservableCollection<Kiado>(kiadok);
            }
        }

        [RelayCommand]
        public void DoSave(Kiado newKiado)
        {
            Kiadok.Add(newKiado);
            OnPropertyChanged(nameof(Kiadok));
        }

        [RelayCommand]
        void DoNewKiado()
        {
            SelectedKiado = new Kiado();
        }

        [RelayCommand]
        public void DoRemove(Kiado kiadoToDelete)
        {
            Kiadok.Remove(kiadoToDelete);
            OnPropertyChanged(nameof(Kiadok));
        }
    }
}
