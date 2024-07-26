using K4os.Compression.LZ4.Encoders;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice.Data
{
    internal class TimeToStart
    {
        public int value;
        string imenit_padej;
        string rodit_padej;
        string rodit_padej_ed_number;
        public TimeToStart(string imenit_padej, string rodit_padej, string rodit_padej_ed_number)
        {
            value = 0;
            this.imenit_padej = imenit_padej;
            this.rodit_padej= rodit_padej;
            this.rodit_padej_ed_number = rodit_padej_ed_number;
        }
        public string ChangeValue()
        {
            int ValueTime = value;
            if (ValueTime > 100)
                ValueTime = ValueTime % 100;
            if (ValueTime > 11 && ValueTime <= 14)
                return " " + rodit_padej + " ";
            ValueTime = ValueTime % 10;
            switch (ValueTime)
            {
                case 1:
                    return " " + imenit_padej + " ";
                case 2:
                case 3:
                case 4:
                    return " " + rodit_padej_ed_number + " ";
                default:
                    return " " + rodit_padej + " ";
            }
        }
    }
}
