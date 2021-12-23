using System;
using System.Collections.Generic;
using System.Text;

namespace HarjoitusTyo2
{

    /// <summary>
    /// Tähän tulee user Constructor. Tarkoitus on tallentaa eri formin2 usertietoa.
    /// </summary>
    /// 

    class UserConstructor
    {
        // Henkilö tiedot
        public static string etunimi;
        public static string sukunimi;
        public static string kutsumanimi;
        public static string henkiloTunnus;

        public static string katuosoite;
        public static string postinumero;
        public static string postitoimipaikka;

        public static string aloituspaiva;
        public static string lopetuspaiva;

        // Toimisuhteentiedot

        public static string nimike;
        public static string yksikko;

        public static void tyhjenna_userConstructor()
        {

            UserConstructor.etunimi = "";
            UserConstructor.sukunimi = "";
            UserConstructor.kutsumanimi = "";
            UserConstructor.henkiloTunnus = "";
            UserConstructor.katuosoite = "";
            UserConstructor.postinumero = "";
            UserConstructor.postitoimipaikka = "";
            UserConstructor.aloituspaiva = "";
            UserConstructor.postitoimipaikka = "";
        }

    }
}
