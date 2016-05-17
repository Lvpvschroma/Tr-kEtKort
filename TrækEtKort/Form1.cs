using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrækEtKort {
    public partial class TrækEtKort : Form {
        public TrækEtKort() {
            InitializeComponent();



        }

        private void Form1_Load(object sender, EventArgs e) {






        }

        private void dealCard_Click(object sender, EventArgs e) {
            Random rnd = new Random();
            int kort = rnd.Next(1, 14); // virker!
            int suit = rnd.Next(1, 5);  // virker!
            //string suitResultat = suit.ToString();
            string kortResultat = kort.ToString();


            if (kort == 1) {
                cardResult.Text = "ES";
            } else if (kort == 11) {
                cardResult.Text = "Knægt";

            } else if (kort == 12) {
                cardResult.Text = "Dame";
            } else if (kort == 13) {
                cardResult.Text = "Konge";
            } else {
               cardResult.Text = kortResultat;

            }
            // noget kunne tyde på mit skift font farve projekt med kort+suit kræver en richtextbox ---- arbejd videre herfra! <--- *******
            
            if (suit == 1) {
                cardSuit.ForeColor = Color.Red;
                cardSuit.Text = "♦";
            } else if (suit == 2) {
                cardSuit.ForeColor = Color.Black;
                cardSuit.Text = "♣";
            } else if (suit == 3) {
                cardSuit.ForeColor = Color.Red;
                cardSuit.Text = "♥";
            } else if (suit == 4) {
                cardSuit.ForeColor = Color.Black;
                cardSuit.Text = "♠";
            } else {
                cardSuit.Text = "Noget er vist gået galt her??!!";
            }

            // cardResult.Text = suitResultat;  //virker! indsæt funktion der ændrer til unicode kort symbol - ændrer font color sort/rød
            //cardResult.Text = kortResultat; // virker! indsæt funktion der ændrer 1=es, 11=knægt, 12=dame, 13=konge


            // cardSuit.Text = "♦ ♣ ♥ ♠"; // virker! tjek ændring af font farve! - TBD

            // pak det hele ind i en if/else blok? if.værdi.==1, 11,12,13 (lav om til tekst istedet for tal værdi, knægt, dame, es osv) else giv .int resultat
            // tilføj suit, tjek for billedkort-es

            // ArrayList <--- til senere potentielt at indeholde _hele_ kort spillet i forbindelse med den udvidede opgave - using collections
            // tilføjet, ctrl+"." <-- for at tilføje manglende using. <--
            // List<T> <-- muligvis bedre... collection kan indeholde alt _men_ du skal specificere _hvad_ ting er, kan smide exception errors hvis forkert indhold bliver thrown

            /* --------- til senere brug, kort class der kan skrives til List dernæst write til en textbox, burde løse opgaven
             * funktion til at sætte dem pænt i orden så _ingen_ random, to counters i form af for indenfor for loop
             * første sætter suit1, kører alle kort tal igennem, dernæst add til næste suit, repeat, indtil hele listen er genereret 
             class Kort
             {
             public string Kort { get; set; }
             public string Suit { get; set; }
             }
            
            *** OBS *** unicode indeholder chars for kort-suit <-- drop billed idéen, find ud af hvordan man bruger unicode i en string hvis muligt


            // denne burde kunne sortere data i tilfælde af jeg kvajer mig og ikke genererer listen i rigtig rækkefølge
            var orderedKort = from kortListe in korteneFærdige
                            orderby kort.indsætværdi descending
                               select kort;

            // eller LINQ versionen
            var orderedKort = mineKort.OrderByDescending(p => p.kortTal);


            kort.ForEach(p => outputdataher("{0} {1}", pkortTal, p.kortSuit)); <--- output kortets tal værdi og suit for alle kort i List

            List<Kort> alleKort = new List<Kort>() {
                new Kort { Suit=" ** add suit fra for/for loop her!", Kort=" ** add fra for/for loop nummer her!" }; 
                */


        }

        private static Color GetRed() {
            return Color.Red;
        }
    }
}


// skal bruge: rand gen 1-13    DONE!
// rand gen 1-5 -- til suit -- DONE!
// funktion der laver 1 = es, 11 = knægt, 12 = dronning, 13 = konge <-- "if" <-- måske?
// knap til at starte det hele --- navn dealCard -- DONE!
// output felt --- navn: cardResult  -- DONE!
// <-- picture box? skal man blære og finde de 4 suit ikoner et sted og smide dem i form af et billede?
// unicode indeholder suit chars
// funktion der ændrer font color - rød / sort
// rand array klør/spar/hjerte/ruder -- navn: cardSuit ****** til næste opgave, flet ind i dette program?
// ♦ ♣ ♥ ♠ <----- nææææææh se der er de sørme! - DONE!