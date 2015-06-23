using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public abstract class CreatorKontrolek //klasa abstrakcyjna CreatorKontrolek
    {
    }

    public class CreatorProstokatow : CreatorKontrolek //CreatorProstokatow dziedziczy po CreatorKontrolek
    {
        private List<UserControl> ListaKontrolek = new List<UserControl>();// prywatny atrybut kreatora kontrolek - kontener przechowujacy liste kontrolek

       

        public void RegisterKontorlke(UserControl kontr) // metoda dodajaca kontrolke do listy, umozliwia dodawanie, akcesor
        {
            this.ListaKontrolek.Add(kontr);
        }

        public UserControl CreateKontrolke(Form1 form) //tworzenie kontrolek
        {
            Random rnd = new Random(); //inicjalizacja generatora liczb pseudolosowych
            switch (rnd.Next(1,6)) //losowanie liczby z zakresu
            {
                case 1: //pierwsza kontrolka
                    {
                        A a = new A(form);//utworzenie
                        form.Controls.Add(a); //dodanie do listy kontrolek w formatce
                        a.Top = rnd.Next(10, form.Size.Height-a.Size.Height);//pozycja od gory
                        a.Left = rnd.Next(10, form.Size.Width-a.Size.Width);//pozycja od lewej
                        return a;//zwrocenie kontrolki
                        //return new A();
                    }
                case 2:
                    {
                        B b = new B(form);
                        form.Controls.Add(b);
                        b.Top = rnd.Next(10, form.Size.Height - b.Size.Height);
                        b.Left = rnd.Next(10, form.Size.Width - b.Size.Width);
                        return b;
                       // return new B();
                    }
                case 3:
                    {
                        C c = new C(form);
                        form.Controls.Add(c);
                        c.Top = rnd.Next(10, form.Size.Height - c.Size.Height);
                        c.Left = rnd.Next(10, form.Size.Width - c.Size.Width);
                        return c;
                       // return new C();
                    }
                case 4:
                    {
                        D d = new D(form);
                        form.Controls.Add(d);
                        d.Top = rnd.Next(10, form.Size.Height - d.Size.Height);
                        d.Left = rnd.Next(10, form.Size.Width - d.Size.Width);
                        return d;
                        //return new A();
                    }
                case 5:
                    {
                        E e = new E(form);
                        form.Controls.Add(e);
                        e.Top = rnd.Next(10, form.Size.Height - e.Size.Height);
                        e.Left = rnd.Next(10, form.Size.Width - e.Size.Width);
                        return e;
                        //return new A();
                    }
                case 6:
                    {
                        F f = new F(form);
                        form.Controls.Add(f);
                        f.Top = rnd.Next(10, form.Size.Height - f.Size.Height);
                        f.Left = rnd.Next(10, form.Size.Width - f.Size.Width);
                        return f;
                        //return new A();
                    }
                default: return null;

            }

        }
    }
}
