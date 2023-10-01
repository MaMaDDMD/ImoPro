using Dapper;
using Microsoft.Data.Sqlite;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;

namespace Imo.ViewModel
{
    public class DataViewModel : INotifyPropertyChanged
    {
        private dynamic? showingTable = new ExpandoObject();
        public dynamic? ShowingTable { get => showingTable; set { showingTable = value; RaisePropertyChanged(nameof(ShowingTable)); } }
        public event PropertyChangedEventHandler? PropertyChanged;
        public void RaisePropertyChanged(string PropertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        public bool ExecuteQuery(string QueryText)
        {
            using SqliteConnection ImoFriendsDb = new("Data Source=C:\\sqlite\\db\\imofriends.db");
            using SqliteConnection AccountDb = new("Data Source=C:\\sqlite\\db\\accountdb.db");
            bool Flag = true;
            ShowingTable = null;
            try
            {
                ShowingTable = ImoFriendsDb.Query<dynamic>(QueryText).ToList();
            }
            catch
            {
                try
                {
                    ShowingTable = AccountDb.Query<dynamic>(QueryText).ToList();
                }
                catch
                {
                    Flag = false;
                }
            }
            return Flag;
        }
    }
}