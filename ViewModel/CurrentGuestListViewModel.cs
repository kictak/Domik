using DataModel.Directories;

namespace ViewModel
{
    public class CurrentGuestListViewModel
    {
        public List<CheckIn> CheckIns { get; set; }

        public string NameFilterText {  get; set; }
    }
}
