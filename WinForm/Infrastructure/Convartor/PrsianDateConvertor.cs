using System.Globalization;
using System.Text;

namespace WinForm.Infrastructure.Convartor
{
    public static class PrsianDateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            var result = new StringBuilder()
                .Append(pc.GetYear(value))
                .Append("/")
                .Append(pc.GetMonth(value).ToString("00"))
                .Append("/")
                .Append(pc.GetDayOfMonth(value).ToString("00"))
                .ToString();
            return result;
        }

        public static DateTime ToMiladi(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, new System.Globalization.PersianCalendar());
        }
    }
}
