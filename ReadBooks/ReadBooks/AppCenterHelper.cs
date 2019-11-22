using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadBooks
{
    public class AppCenterHelper
    {
        public static void TrackError(Exception exception)
        {
            Crashes.TrackError(exception);
        }
    }
}
