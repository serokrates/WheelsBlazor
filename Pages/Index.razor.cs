using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.DataProtection.Repositories;
using WheelsBlazor.Data;
using WheelsBlazor.Data.Entities;

namespace WheelsBlazor.Pages
{
    public partial class Index
    {
        [Inject]
        protected IWheelsRepository Repository { get; set; }
        protected WheelsService Service { get; set; }
        private string _brandType;
        public bool ShowCreate { get; set; }
        public Alutec? NewAlutec { get; set; }
        public AlloyWheel? NewAlloyWheel { get; set; }
        public WheelsTable? NewWheel { get; set; }
        bool PopupVisible;
        private string[] _filterTypes;
        private FetchedData[] _fetchedData;

        protected override async Task OnInitializedAsync()
        {
            PopupVisible = false;
            ShowCreate = false;
            _fetchedData = await Repository.GetCombinedWheelsDataAsync();
            _filterTypes = _fetchedData.Select(a => a.Brand).Distinct().ToArray();
            _brandType = _filterTypes[0];
        }

        public void ShowCreateForm()
        {
            NewAlloyWheel = new AlloyWheel();
            ShowCreate = true;
        }
        protected void PopupClick() 
        {
           if (PopupVisible)
            {
                PopupVisible = false; ShowCreateForm();
            }
        }
        protected void SaveData() 
        {
            var newWheel = new WheelsTable()
            {
                BrandType = _brandType
            };
            Repository.CreateWheel(newWheel);

            switch (_brandType)
            {
                case "Alutec":
                    Repository.CreateAlutec(new Alutec()
                    {
                        WheelsTableID = newWheel.ID,
                        Diameter = NewAlloyWheel.Diameter,
                        BoltCircle = NewAlloyWheel.BoltCircle,
                        Offset = NewAlloyWheel.Offset,
                    });

                    break;
                case "Anzio":
                    Repository.CreateAnzio(new Anzio()
                    {
                        WheelsTableID = newWheel.ID,
                        Diameter = NewAlloyWheel.Diameter,
                        BoltCircle = NewAlloyWheel.BoltCircle,
                        Offset = NewAlloyWheel.Offset,
                    });

                    break;
                case "Ats":
                    Repository.CreateAts(new Ats()
                    {
                        WheelsTableID = newWheel.ID,
                        Diameter = NewAlloyWheel.Diameter,
                        BoltCircle = NewAlloyWheel.BoltCircle,
                        Offset = NewAlloyWheel.Offset,
                    });

                    break;
                case "Rial":
                    Repository.CreateRial(new Rial()
                    {
                        WheelsTableID = newWheel.ID,
                        Diameter = NewAlloyWheel.Diameter,
                        BoltCircle = NewAlloyWheel.BoltCircle,
                        Offset = NewAlloyWheel.Offset,
                    });

                    break;
            }
            PopupVisible = true;
        }
    }
}
