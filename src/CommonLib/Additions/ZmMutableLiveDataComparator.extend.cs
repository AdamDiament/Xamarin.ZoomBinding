using System;
using System.Collections.Generic;
using System.Text;
using AndroidX.Lifecycle;
using Object = Java.Lang.Object;

namespace US.Zoom.Androidlib.Mvvm.Data
{
    public partial class ZmMutableLiveDataComparator
    {
        public int Compare(Java.Lang.Object? o1, Object? o2)
        {
            return Compare((ZmMutableLiveData)o1, (ZmMutableLiveData)o2);
        }
    }
}
