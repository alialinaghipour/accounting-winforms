﻿namespace WinForm.Infrastructure
{
    internal static class StringUtils
    {
        public static bool IsBlank(this string? value)
        {
            return string.IsNullOrWhiteSpace(value);
        }
    }
}
