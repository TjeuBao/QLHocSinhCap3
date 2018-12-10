using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiHocSinh
{
    public class ValidateInput
    {
        public Boolean validateEmail(string txtBox)
        {
            // Create string variables that contain the patterns   
            string emailPattern = @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$"; // Email address pattern    

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isEmailValid = Regex.IsMatch(txtBox, emailPattern);
            if (isEmailValid && !validateNull(txtBox))
            {
                return true;
            }
            else
                return false;
        }

        public Boolean validateText(string txtBox)
        {
            // Create string variables that contain the patterns   
            string lettersPattern = @"^[a-zA-Z]+$"; // Email address pattern    

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isLettersValid = Regex.IsMatch(txtBox, lettersPattern);
            if (isLettersValid && !validateNull(txtBox))
            {
                return true;
            }
            else
                return false;
        }

        public Boolean validateDiem(string txtBox)
        {
            int diem = int.Parse(txtBox);
            if (0 <= diem && diem <= 10)
            {
                return true;
            }
            else
                return false;
        }

        public Boolean validatePhone(string txtBox)
        {

            // Create string variables that contain the patterns   
            string phonePattern = @"^(\+[0-9]{9})$"; // Email address pattern    

            // Create a bool variable and use the Regex.IsMatch static method which returns true if a specific value matches a specific pattern  
            bool isphonelValid = Regex.IsMatch(txtBox, phonePattern);
            if (isphonelValid && !validateNull(txtBox))
            {
                return true;
            }
            else
                return false;
        }

        public Boolean validateNull(string txtBox)
        {
            return string.IsNullOrEmpty(txtBox);

        }

    }
}
