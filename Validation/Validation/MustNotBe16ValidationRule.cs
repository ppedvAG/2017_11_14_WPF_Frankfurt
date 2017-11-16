using System.Globalization;
using System.Windows.Controls;

namespace Validation
{
    internal class MustNotBe16ValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo) =>
            (string)value == "16"
                ? new ValidationResult(false, "Sechzehn ist ein ungültiger Wert! Bitte wenden Sie sich an ihren Systemadministrator.")
                : ValidationResult.ValidResult;
    }
}
