using System;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using OfficeOpenXml;




namespace HarjoitusTyo2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            txt_tyylitys();

            btnLisaaKauttaja.BackColor = Color.FromArgb(210, 37, 110);
            btnLisaaKauttaja.ForeColor = Color.FromArgb(255, 255, 255);

        }



        private void txt_tyylitys()
        {
            foreach (TextBox textBox in panel1.Controls.OfType<TextBox>())
            {
                textBox.Font = new Font(textBox.Font.FontFamily, 10);
                textBox.ForeColor = Color.FromArgb(37, 37, 38);
            }
        }

        private void lbl_otsikonTyylitys()
        { // Päivitetään otsikot oikean tyyliseksi.

            foreach (Label lbl in panel1.Controls.OfType<Label>())
            {
                lbl.Font = new Font(lbl.Font.FontFamily, 10);
                lbl.ForeColor = Color.FromArgb(210, 37, 110);
            }
        }


        // Aika komponentin validointi.

        private void paivanTarkistaja(object sender, EventArgs e)
        {
            if (pickerStart.Value > pickerEnd.Value)
            {
                MessageBox.Show("Päivä ei voi olla menneisyydessä");
                pickerEnd.Value = DateTime.Now;
            }

        }

        // Tallentaa käyttäjän

        private void btnLisaaKauttaja_Click(object sender, EventArgs e)
        {
            // Erillinen tiedosto funktio tallennukselle. Tallentaa textboxeissa olevat tiedot temp_tietokanta.txt tiedostoon.
            Tiedosto_Tallennus.tallennaTiedotUser();

            // Tyhjennetään kaikki txtboksit aktiiviselta formilta.
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
            };

            func(Controls);


            // Tyhjentää kokonaan variablet.
            // Tästä vois kysyä opetajalta et voisko laittaa suoraan looppiin ja kerralla resetoida ne.

            UserConstructor.etunimi = "";
            UserConstructor.sukunimi = "";
            UserConstructor.kutsumanimi = "";
            UserConstructor.henkiloTunnus = "";
            UserConstructor.katuosoite = "";
            UserConstructor.postinumero = "";
            UserConstructor.postitoimipaikka = "";
            UserConstructor.aloituspaiva = "";
            UserConstructor.postitoimipaikka = "";

            MessageBox.Show("Tiedot tallennettu!!!");
        }


        private void tekstibox_Keypress(object sender, KeyPressEventArgs e)
        {
            //Keypress eventti joka sallii vain kirjaimet a-Z, 0-9 numerot, ääkköset, backspace ja whitespace kirjaimet
            var regex = new Regex(@"[^a-zA-ZäöüåÅÄÖÜß0-9-\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }
        
        private void postinumero_Keypress(object sender, KeyPressEventArgs e)
        {
            //keypress eventti postinumero textboxille joka sallii vain numerot ja backspace
            var regex = new Regex(@"[^0-9-\s\b]");
            if (regex.IsMatch(e.KeyChar.ToString()))
            {
                e.Handled = true;
            }
        }

        private void tallennus_Leave(object sender, EventArgs e)
        {
            UserConstructor.etunimi = txtEtunimi.Text.Replace(",", "");
            UserConstructor.sukunimi = txtSukunimi.Text.Replace(",", "");
            UserConstructor.kutsumanimi = txtKutsumanimi.Text.Replace(",", "");
            
       
            UserConstructor.katuosoite = txtKatuosoite.Text.Replace(",", "");
            UserConstructor.postinumero = txtPostinumero.Text.Replace(",", "");
            UserConstructor.postitoimipaikka = txtPostitoimipaikka.Text.Replace(",", "");
            UserConstructor.aloituspaiva = pickerStart.Value.ToString("dd'.'MM'.'yyyy");
            UserConstructor.lopetuspaiva = pickerEnd.Value.ToString("dd'.'MM'.'yyyy");
            UserConstructor.nimike = txtNimike.Text.Replace(",", "");
            UserConstructor.yksikko = txtYksikko.Text.Replace(",", "");
        }

        //Tähän tulee datetime tallennus

        private void testidate_Click(object sender, EventArgs e)
        {
            var MyString = pickerStart.Value.Date;

            MessageBox.Show(Convert.ToString(MyString));
        }

        private char HetuTarkistus(int tarkaste)
        {
            //tässä funktiossa tarkistetaan suomalaisen henkilötunnuksen tarkiste kirjain/numero
            char[] vs = { 'A', 'B', 'C', 'D', 'E', 'F', 'H', 'J', 'K', 'L', 'M', 'N', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y' };
            char jäänne;
            switch (tarkaste)
            {
                case 0:
                    jäänne = '0';       
                    break;
                case int i when i > 0 && i <= 9:    //jakojäänteet 0-9 ovat tarkiste numerot 0-9
                    jäänne = char.Parse(tarkaste.ToString());
                    break;
                case int j when j > 9 && j <= 30:   //jakojäänteet 10-30 ovat kirjaimet järjestyksessä mitkä näkyvät "vs"-char taulukossa missä 10 = A jne.
                    jäänne = vs[j - 10];
                    break;
                default:
                    jäänne = '0';
                    break;
            }
            return jäänne;  //palautetaan tarkaste kirjain/numero

        }
        private void hetu_Leave(object sender, EventArgs e)
        {
            try
            {
                string s = txtHetu.Text;
                char[] cArr = s.ToCharArray();

                int result = int.Parse(string.Join(string.Empty, Regex.Matches(s, @"\d+").OfType<Match>().Select(m => m.Value))); //kerätään vain luvut syötteestä
                int jäännös = result % 31; //kerätään jakojäännös
                char tarkistus = HetuTarkistus(jäännös);//suoritetaan tarkastus jakojäännöksellä


                if (tarkistus == cArr[10])                  //verrataan syötettyä tarkastetta ja tarkastetta minkä sen pitäisi olla esim. 160427-937R palauttaa kirjaimen R joten Henkilötunnus on oikeassa formaatissaan
                {
                    UserConstructor.henkiloTunnus = txtHetu.Text.Replace(",", ""); 
                }
                else
                {
                    throw new Exception(); //hetu ei oikea joten heitetään virhe
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Henkilötunnus ei ole oikea");
            }
        }
        private void henkiloTunnusValidointi_TextChanged(object sender, EventArgs e)
        {
            /*Validoi hetun, jos ei ole oikeassa formaatissa labeli on punainen
            Jos on niin silloin muuttu takaisin mustaksi
             */
            

            if (txtHetu.Text.IsValidSsn())
                lblHetu.ForeColor = Color.FromArgb(0, 0, 0);
            else
                lblHetu.ForeColor = Color.Red;
        }


    }
}


