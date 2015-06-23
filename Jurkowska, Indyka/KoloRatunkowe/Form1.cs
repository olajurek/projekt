using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class Form1 : Form
    {
        CreatorProstokatow CreatorProstokatow = new CreatorProstokatow(); //tworzenie obiektu klasy CreatorProstokatow
        private List<UserControl> ListaKontrolek = new List<UserControl>(); //prywatny atrybut klasy Form1- Lista Kontrolek
       
        public Form1() //kreator formatki
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

     
        public UserControl kontrolka() //metoda wywolujaca tworzenie kontrolek
        {
            UserControl kontrolka;
            
            kontrolka = CreatorProstokatow.CreateKontrolke(this);
            this.ListaKontrolek.Add(kontrolka);
            return kontrolka;
        }

        public void RemoveKontrolka(UserControl kontr) //metoda usuwajaca kontrolke
        {
            for(int i=1;i<this.Controls.Count;i++)//iteracja przez wszystkie kontrolki w formatce
                if (this.ListaKontrolek.Exists(x => x.GetType() == kontr.GetType()))// po kolei sprawdza kontrolki, czy sa zadanego typu
                {
                    this.Controls.Remove(this.ListaKontrolek.Find(x => x.GetType() == kontr.GetType()));//jak kontrolka sie zgadza, to usuwa z formatki
                    this.ListaKontrolek.Remove(this.ListaKontrolek.Find(x => x.GetType() == kontr.GetType()));//i z listy kontrolek
                }
        }

        private void FMouseClick(object sender, MouseEventArgs e)//
        {
            if (sender.GetType().ToString() == "projekt.Form1")//jezeli jest klikniecie na formatke, to wywolana zostaje metoda kontrolka
                this.kontrolka();
       
        }

     
        
    }
}
