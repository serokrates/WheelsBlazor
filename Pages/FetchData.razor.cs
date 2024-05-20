using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using WheelsBlazor.Data;
using WheelsBlazor.Data.Entities;

namespace WheelsBlazor.Pages
{
    public partial class FetchData
    {
        [Inject]
        protected WheelsService Service { get; set; }
        [Inject]
        protected IWheelsRepository Repository { get; set; }
        private bool _popupVisible;
        public bool ShowCreate { get; set; }
        public Alutec? NewAlutec { get; set; }
        public AlloyWheel? NewAlloyWheel { get; set; }
        public WheelsTable? NewWheel { get; set; }
        private FetchedData[] _fetchedData { get; set; }
        private FetchedData[] _filteredData { get; set; }
        private string[] _filterTypes;
        private string _response;
        private string _selectedOption;
        private void ChangeFilter(ChangeEventArgs e) 
        {
            _selectedOption = e.Value.ToString();
            FilterData(_selectedOption);
        }
        private void FilterData(string selectedOption)
        {
            if (string.IsNullOrWhiteSpace(selectedOption) || selectedOption.Equals("All"))
            {
                _filteredData = _fetchedData;
            }
            else 
            {
                _filteredData = _fetchedData.Where(a => a.Brand.Equals(selectedOption, StringComparison.OrdinalIgnoreCase)).ToArray();
            }
        }
        private async Task DeleteItem(int Id) 
        {
            _response = await Service.DeleteItemService(Id);
            if (_response != null) { _popupVisible = true; }
        }
        protected override async void OnInitialized()
        {
            _popupVisible = false;
            base.OnInitialized();
            _fetchedData = await Repository.GetCombinedWheelsDataAsync();
            _filterTypes = _fetchedData.Select(a => a.Brand).Distinct().ToArray();
            FilterData("");
        }
        private async void PopupClick() 
        {
            if (_popupVisible != false) 
            {
                _fetchedData = await Repository.GetCombinedWheelsDataAsync();

                _popupVisible = false;
                FilterData(_selectedOption);            
            }
        }
    }
}
