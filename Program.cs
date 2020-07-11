using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Create_Your_Serial_And_Test_
{
    class Program
    {

        static void Main(string[] args)
        {
            // My Logo
            Thread.Sleep(750);
            Console.WriteLine("               -- --    -----    -----    -- --   -- --    --                ");
            Console.WriteLine("               -----    --       --       -- --   -----    --                ");
            Console.WriteLine("               -----    -----    -----    -----   -----    --                ");
            Console.WriteLine("               -- --    --          --    -- --   -- --    --                ");
            Console.WriteLine("               -- --    -----    -----    -- --   -- --    --                ");
            // Initialize The Program
            Console.WriteLine("                             Random Key Generator                             ");
            Thread.Sleep(750);
            Console.WriteLine("                        Please Press 2 or Program Exit                        ");
            // Read If Number2 Are Pressed
            int numberpressed = Convert.ToInt32(Console.ReadLine());
            if (!(numberpressed == 2))
            {
                Console.WriteLine("                                Please Press 2                                ");
            }
            if (numberpressed == 2)
            {
            // 20 Sample Value Of Key
                string string1 = "FJTCC-";
                string string2 = "XEXQN";
                string string3 = "EMXNO-";
                string string4 = "NVTPG-";
                string string5 = "NFKWT";
                string string6 = "HHOPL";
                string string7 = "VVPOL-";
                string string8 = "XDERD-";
                string string9 = "REWIT-";
                string string10 = "EFIUX-";
                string string11 = "NNCSX-";
                string string12 = "XXEIU-";
                string string13 = "KJLLH-";
                string string14 = "QJHLG-";
                string string15 = "FQQJK-";
                string string16 = "ENNRR-";
                string string17 = "NJKFD-";
                string string18 = "VDOPR";
                string string19 = "JDNSC-";
                string string20 = "OCSDI-";
            // Sample Sum The String For KEY GENERATOR
                string serialletter1 = (string14 + string1 + string11 + string10 + string2 + "   Or....");
                string serialletter2 = (string15 + string19 + string12 + string9 + string5 + "    Or....");
                string serialletter3 = (string16 + string3 + string13 + string8 + string6 + "    Or....");
                string serialletter4 = (string17 + string4 + string20 + string7 + string18);
            // Generate 4 KEY
                string possiblekeyl = (serialletter1 + "  " + serialletter2 + "  " + serialletter3 + "  " + serialletter4 + "  ");
                Thread.Sleep(750);
                Console.WriteLine(possiblekeyl);
                Thread.Sleep(60000);
            }
        }
    }
}