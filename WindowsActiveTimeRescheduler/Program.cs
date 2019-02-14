using System;
using Microsoft.Win32;

namespace WindowsActiveTimeRescheduler
{
  class Program
  {
    static void Main()
    {
      var maxHours = 18;

      var dt = DateTime.Now;

      var ActiveHoursStart = dt.Subtract(new TimeSpan(1, 0, 0)).Hour;
      var ActiveHoursEnd = dt.Add(new TimeSpan(maxHours - 1, 0, 0)).Hour;

      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings","ActiveHoursStart", ActiveHoursStart);
      Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\WindowsUpdate\\UX\\Settings","ActiveHoursEnd", ActiveHoursEnd);
    }
  }
}
