using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HalloMVVM.ViewModels
{
    internal abstract class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        protected void Set<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null)
        {
            if(field == null || !field.Equals(newValue))
            {
                field = newValue;
                RaisePropertyChanged(propertyName);
            }
        }
    }
}
