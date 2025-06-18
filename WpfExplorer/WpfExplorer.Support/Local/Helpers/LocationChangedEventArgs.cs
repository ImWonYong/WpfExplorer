using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfExplorer.Support.Local.Models;

namespace WpfExplorer.Support.Local.Helpers
{
    public class LocationChangedEventArgs : EventArgs
    {
        public FileInfoBase Current { get; }

        public LocationChangedEventArgs(FileInfoBase current) { Current = current; }
    }
}
