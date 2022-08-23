using System.Xml.Linq;
using WinForm.Infrastructure.Convartor;

namespace WinForm.Infrastructure
{
    internal static class MessageBoxFactory
    {
        /// <summary>
        /// ققط فیلد اجباری را به بنویسید
        /// </summary>
        /// <param name="text"> </param>
        public static void Required(string text)
        {
            var value = $"لطفا {text} را وارد کنید";
            RtlMessageBox.Show(value, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Duplicate(string text)
        {
            var value = text + " تکراری است";
            RtlMessageBox.Show(value, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Successful(string text)
        {
            RtlMessageBox.Show(text, "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Successful()
        {
            var text = "عملیات موفقیت آمیز بود";
            RtlMessageBox.Show(text, "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Error(string text)
        {
            RtlMessageBox.Show(text, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void Error()
        {
            var text = "خطایی رخ داد است دوباره امتحان کنید";
            RtlMessageBox.Show(text, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MessageRequired(string text)
        {
            MessageBoxFactory.Required(text);
        }

        public static void MessageSuccessful(string text)
        {
            MessageBoxFactory.Successful(text);
        }

        public static void MessageError(string text)
        {
            Error(text);
        }

        public static DialogResult Warning(string value)
{
           return RtlMessageBox.Show($"آیا از حذف {value} مطمئن هستید ؟", "اخطار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
