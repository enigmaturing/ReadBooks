using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReadBooks
{
    public class Book
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string ISBN { get; set; }

        public bool SaveBook()
        {
            // save to some db
            AppCenterHelper.TrackEvent("book_saved");
            Crashes.GenerateTestCrash();
            return false;
        }
    }
}
