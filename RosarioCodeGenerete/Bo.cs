using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosarioCodeGenerete
{
    class Bo
    {
        public static List<string> codigos = new List<string>();
        public static void WriteNotePad(string path) {
            foreach (var item in codigos)
            {
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(path, true))
                {
                    file.WriteLine(item);
                }
            }
        }
        public static int CalculateVerificationNumber(string number) {
            int a = int.Parse(number.Substring(number.Length-1,1));
            int b = int.Parse(number.Substring((number.Length)-2,1));
            int valueXor = b ^ a;
            for (int i = 0; i < (number.Length-2); i++)
            {
                b = int.Parse(number.Substring((number.Length) - 3-i,1));
                valueXor ^= b;
            }
            string aux  = valueXor.ToString();
            valueXor= int.Parse(aux.Substring((aux.Length) - 1, 1));
            return valueXor;
        }
        public static void GerarListaDeCodigos(string NumeroCorrelaton, int NumberOfCards,string CardNumber,string path) {
            Int64 aux = 0;
            string LaserNumber = "";
            string CodigoNaLateral = "";
            string Barcode = "";
            string texto = "";
            string fmt = "000000";
            bool auxx = false;
            int comeco = 0;
            int fim = 0;
            codigos.Clear();
            for (int i = 0; i < NumberOfCards; i++)
            {
                auxx = true;

                    if (i==0)
                    {
                        texto = CardNumber + NumeroCorrelaton;
                        aux = Int64.Parse(texto);
                        LaserNumber = aux.ToString();
                        NumeroCorrelaton = LaserNumber.Substring(LaserNumber.Length - 8, 8);
                        CodigoNaLateral = LaserNumber + CalculateVerificationNumber(NumeroCorrelaton);
                        Barcode = LaserNumber + CalculateVerificationNumber(NumeroCorrelaton) + "0";
                        texto = (i + 1).ToString(fmt) + " - " + CodigoNaLateral + "                " + LaserNumber + "                " + Barcode + "                " + invertNumber(NumeroCorrelaton) + "                " + NumeroCorrelaton;
                        codigos.Add(texto);
                    }
                    else
                    {
                        texto = CardNumber + NumeroCorrelaton;
                        aux = Int64.Parse(texto);
                        aux++;
                        LaserNumber = aux.ToString();
                        NumeroCorrelaton = LaserNumber.Substring(LaserNumber.Length - 8, 8);
                        CodigoNaLateral = LaserNumber + CalculateVerificationNumber(NumeroCorrelaton);
                        Barcode = LaserNumber + CalculateVerificationNumber(NumeroCorrelaton)+"0";
                        texto = (i + 1).ToString(fmt) + " - " + CodigoNaLateral + "                " + LaserNumber + "                " + Barcode + "                " + invertNumber(NumeroCorrelaton) + "                " + NumeroCorrelaton;
                        codigos.Add(texto);
                    }

                    
                if (i!=0 && (i+1)%10000==0 )
                {
                    fim = i+1;
                    string a  = path+ comeco+"_ate_" + fim+".txt";
                    WriteNotePad(a);
                    codigos.Clear();
                    auxx = false;
                    comeco = fim+1;
                }
            }
            if (auxx)
            {
                string a = path + comeco + "_ate_" + NumberOfCards + ".txt";
                WriteNotePad( a);
            }
            
        }
        public static string invertNumber(string text) {
            string aux=null;
            string devolve=null;
            for (int i = 0; i < 8; i++)
            {
                aux = text.Substring(i,2);
                byte[] bytes = Encoding.ASCII.GetBytes(aux);
                Array.Reverse(bytes, 0, bytes.Length);
                devolve += Encoding.ASCII.GetString(bytes);
                i++;
            }
            return devolve;
        }
    }
}
