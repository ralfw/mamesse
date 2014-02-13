using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mam.steuerung.serverportal.tests
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var server = new ServerPortal())
            {
                server.Zurücksetzungswunsch += () => Console.WriteLine("Zurücksetzungswunsch");
                server.Fehler += () => Console.WriteLine("Fehler");
                server.Reparaturwunsch += () => Console.WriteLine("Reparaturwunsch");
                server.HilfeUnterwegs += () => Console.WriteLine("Hilfe unterwegs");
                server.Starten();

                Console.WriteLine("Test running...");
                Console.ReadLine();
            }
        }
    }
}
