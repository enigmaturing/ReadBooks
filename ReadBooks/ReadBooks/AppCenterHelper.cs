﻿using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadBooks
{
    public class AppCenterHelper
    {
        public static void TrackError(Exception exception, Dictionary<string,string> properties = null)
        {
            Crashes.TrackError(exception, properties);
        }

        public static void TrackEvent(string eventName, Dictionary<string, string> properties = null)
        {
            Analytics.TrackEvent(eventName, properties);
        }
    }
}
