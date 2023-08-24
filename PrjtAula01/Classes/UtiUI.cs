using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjtAula01.Classes
{
    public static class UtiUI
    { 
        public static void LimpaForm(Form form)
        {
            // variavel do tipo control "*c*"
            foreach (Control c in form.Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.Text = String.Empty;
                }
                else if (c is DateTimePicker)
                {
                    c.Text = DateTime.Now.ToString();
                }
            }
        } 
    
    
    }    
        
        
}
