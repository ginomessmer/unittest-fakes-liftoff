using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestFakesLiftoff.Core.Common
{
    /// <summary>
    /// Base class for ViewModels, implements OnPropertyChanged. Nothing further to do.
    /// </summary>
    public partial class ViewModelBase : INotifyPropertyChanged
    {
        public ViewModelBase()
        {
        }

        #region Property Changed
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
