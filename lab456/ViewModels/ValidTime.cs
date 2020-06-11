using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Web;
namespace lab456.ViewModels
{
    [AttributeUsage(AttributeTargets.Property)]
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value) {
            DateTime dateTime;
            var isValid = DateTime.TryParseExact(Convert.ToString(value), "HH:mm", CultureInfo.CurrentCulture, DateTimeStyles.None, out dateTime);
            return isValid;
        }
    }
}