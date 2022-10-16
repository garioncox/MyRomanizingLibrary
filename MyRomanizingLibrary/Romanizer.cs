using System.ComponentModel;

namespace MyRomanizingLibrary
{
    public class Romanizer
    {
        public int Number { get; set; }
        public string Numeral { get; private set; }

        public Romanizer() {
            Numeral = "";
            Number = 0;
        }

        public void Convert()
        {
            string result = "";

            if (Number < 0 || Number > 3000)
            {
                this.Numeral = "error";
                return;
            }

            char[] num = Number.ToString().ToCharArray();
            Array.Reverse(num);
            for (int i = 0; i < num.Length; ++i)
            {
                string beg = "";
                string mid = "";
                string end = "";

                if (i == 0)
                {
                    beg = "i";
                    mid = "v";
                    end = "x";
                }
                else if (i == 1)
                {
                    beg = "x";
                    mid = "l";
                    end = "c";
                }
                else if (i == 2)
                {
                    beg = "c";
                    mid = "d";
                    end = "m";
                }
                else if (i == 3)
                {
                    beg = "m";
                }

                switch (num[i])
                {
                    case '1':
                        result = beg + result;
                        break;
                    case '2':
                        result = beg + beg + result;
                        break;
                    case '3':
                        result = beg + beg + beg + result;
                        break;
                    case '4':
                        result = beg + mid + result;
                        break;
                    case '5':
                        result = mid + result;
                        break;
                    case '6':
                        result = mid + beg + result;
                        break;
                    case '7':
                        result = mid + beg + beg + result;
                        break;
                    case '8':
                        result = mid + beg + beg + beg + result;
                        break;
                    case '9':
                        result = beg + end + result;
                        break;
                    default:
                        break;
                }
            }

                this.Numeral = result;
        }
    }
}