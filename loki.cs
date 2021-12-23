using System;
using System.IO;
using System.Collections;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace HarjoitusTyo2
{
    public static class loki
    {

        public static void WriteLog(string message)
        {
            
            string logPath = "temp_lokitiedosto.txt"; //Tiedostonpolku
            

            string currentUser = Environment.UserName; // Tallennetaan userintiedot Current userin variableen.
               using (StreamWriter writer = new StreamWriter(logPath, true))

                {
                    writer.WriteLine($"{DateTime.Now} / Käyttäjä: {currentUser} / {message}");
                }
           

        }
    }
}