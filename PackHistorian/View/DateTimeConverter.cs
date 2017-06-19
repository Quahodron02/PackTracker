﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using Hearthstone_Deck_Tracker;

namespace PackChronicler.View {
  class DateTimeConverter : IValueConverter {
    static Config _config = Config.Instance;

    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
      if(value is DateTime) {
        CultureInfo cult = null as CultureInfo;
        try {
          string lang = _config.SelectedLanguage.Insert(2, "-");
          cult = new CultureInfo(lang);
        } catch (CultureNotFoundException) {
          cult = CultureInfo.InstalledUICulture;
        }

        return ((DateTime)value).ToString(cult);
      }

      return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
      throw new NotImplementedException();
    }
  }
}