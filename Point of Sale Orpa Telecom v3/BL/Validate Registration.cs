using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Point_of_Sale_Orpa_Telecom_v3.DAL;
using System.Windows;
using Point_of_Sale_Orpa_Telecom_v3.PL;

namespace Point_of_Sale_Orpa_Telecom_v3.BL
{
    class Validate_Registration
    {
        
        public static void validateRegistration()
        {
            string storedMac = FileManagement.getProductReg().ElementAt(1); //stpred in file
            string decryptedMac = Register.Decrypt(storedMac, Register.ProductKey);
            string encryptMac;
            if (FileManagement.getProductReg().Count() == 0) // if the file empty
            {
                MessageBox.Show("This copy of product is not registered. Please Enter the details to register the product.");
                Registration rr = new Registration();
                rr.Show();
            }
            else if (decryptedMac != Register.getPcMac())
            {
                MessageBox.Show("Please contact with the developer.");
            }
            else
            {
                PL.Login login = new PL.Login();
                login.Show();
            }
        }
    }
}
