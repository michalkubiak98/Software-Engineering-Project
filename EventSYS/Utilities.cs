using Bunifu.Framework.UI;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace EventSYS
{
    internal class Utilities
    {
        //set length of textBoxes https://stackoverflow.com/questions/49424788/how-to-set-max-length-for-bunifu-net-ui-framework-text-box

        public static void BunifuMetro(BunifuMetroTextbox metroTextbox, int length)
        {
            foreach (var ctl in metroTextbox.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    var txt = (TextBox)ctl;
                    txt.MaxLength = length;
                }
            }
        }

        public static bool IsValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}