using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PersonelEklemeEF
{
    public class Metotlar
    {
        //Groupbox içerisinde BosAlanVarMi kontrolünü yapan metot (BosAlanVarMi)

        public  bool GroupBoxBosAlanVarMi(GroupBox a)
        {
            foreach (var item in a.Controls)
            {

                if (item is TextBox && (item is null || ((TextBox)item).Text.Trim() == ""))
                {
                    return true;
                }
                else if (item is DateTimePicker)
                {
                    if (((DateTimePicker)item).Value.Date >= DateTime.Now.Date)
                    {
                        return true;
                    }

                }
                else if (item is ComboBox)
                {
                    if (((ComboBox)item).SelectedIndex == -1)
                    {
                        return true;
                    }

                }

            }
            return false;
        }

        //Groupboxların içerisini temizleyen metot (Temizle)

        public  void GroupBoxTemizle(GroupBox a)
        {
            foreach (var item in a.Controls)
            {
                if (item is TextBox)
                {
                    ((TextBox)item).Text="";
                }
                else if (item is DateTimePicker)
                {
                    ((DateTimePicker)item).Value = DateTime.Now;
                }
                else if (item is RadioButton)
                {
                    ((RadioButton)item).Checked = false;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
                else if (item is ListBox)
                {
                    ((ListBox)item).DataSource = null;
                }
                else if (item is Label && ((Label)item).Name.StartsWith("lbl"))
                {
                    ((Label)item).Text = "";
                }
            }
        }


    }
}
