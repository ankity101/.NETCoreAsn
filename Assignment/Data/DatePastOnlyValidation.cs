using System.ComponentModel.DataAnnotations;

namespace Assignment.Data
{
    public class DatePastOnlyValidation : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
             if(value is DateTime dob)
             {
                return dob < DateTime.Now;
             }
            return false;
        }
    }
}
