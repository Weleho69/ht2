using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace HarjoitusTyo2
{
    


    class Tiedosto_Tallennus
    {
        
    
    public static void tallennaTiedotUser()

        { 
          
            string rivi = $" {UserConstructor.etunimi}, {UserConstructor.sukunimi}, {UserConstructor.kutsumanimi}, {UserConstructor.henkiloTunnus}, " +
                $"{UserConstructor.katuosoite}, {UserConstructor.postinumero}, {UserConstructor.postitoimipaikka}, {UserConstructor.aloituspaiva}," +
                $" {UserConstructor.lopetuspaiva}, {UserConstructor.nimike}, {UserConstructor.yksikko}"; //kaikki textboxien tiedot yhteen stringiin lyhennyksen vuoksi
            string tiedosto = "temp_tietokanta.txt";

           
          
            
            int TotalLines(string filePath)
            {
                
                    using (StreamReader r = new StreamReader(filePath))
                    {
                        int i = 1;
                        while (r.ReadLine() != null) { i++; }       //luetaan tiedoston rivit ja lisätään +1 per rivi
                        return i;       //palautetaan rivien lukumäärä
                    }
                
              
            }



            

            
            if (File.Exists(tiedosto))
                {                     
                        int i = TotalLines(tiedosto);      //Jos tiedosto on olemassa luetaan rivien määrä joidenka avulla voidaan määrittää ID

                        StreamWriter sw = new StreamWriter(tiedosto, true);
                        sw.Write(i + ","); //kirjoitetaan uuden rivin ID
                        sw.Close(); //suljetaan kirjoittaja                                            
                }                                                       
            else //jos ei ole tiedostoa
            {
                
                StreamWriter wr = new StreamWriter(tiedosto, true);    //luodaan tiedosto ja kirjoitetaan
                wr.Write(1 + ","); //alkaen luvusta 1, määrätään ID ensimmäiselle riville
                wr.Close();
                
            }
            StreamWriter writer = new StreamWriter(tiedosto, true);
            try
            {
                //lisätään muut tiedot jne...
                writer.Write(rivi + "\n");

                writer.Close();

                loki.WriteLog($"Lisättiin käyttäjä: {UserConstructor.etunimi}");
            }
            catch(Exception)
            {
                MessageBox.Show("Virhe lisätessä käyttäjää");
            }

        }
    }
}

