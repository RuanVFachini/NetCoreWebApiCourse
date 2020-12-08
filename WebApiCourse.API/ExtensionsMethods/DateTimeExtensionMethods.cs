using System;

namespace WebApiCourse.API.ExtensionsMethods
{
    public static class DateTimeExtensionMethods
    {
        public static int GetCurrentAge(this DateTime date)
        {
            return DateTime.UtcNow.Year - date.Year;
        }
        
    }
}