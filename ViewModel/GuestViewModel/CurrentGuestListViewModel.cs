using Microsoft.EntityFrameworkCore;
using Storage;
using System.Collections.ObjectModel;

namespace ViewModel.GuestViewModel
{
    public class CurrentGuestListViewModel
    {
        public ObservableCollection<DataModel.Directories.CheckIn> CheckIns { get; set; }

        public CurrentGuestListViewModel()
        {
            using (var context = new MyDbContext())
            {
                // Загрузка данных CheckIn вместе с Guest и Room
                var checkIn = context.CheckIns
                    .Include(c => c.Guest)
                    .Include(c => c.Room)
                    .ToList();

                CheckIns = new ObservableCollection<DataModel.Directories.CheckIn>(checkIn);
            }
        }
    }
}