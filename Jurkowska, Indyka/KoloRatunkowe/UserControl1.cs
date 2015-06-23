using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt
{
    public partial class A : UserControl
    {
      
       private List<Form> Observers = new List<Form>();
        private Form1 form;

        public A(){}
        public A(Form1 form)
        {
            InitializeComponent();//inicjalizacja komponentu
            this.form = form;//przypisanie go do formatki
             this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click); //przypisanie wywolania metody Click do zdarzenia klikniecia nakontrolke
        }

        public void Click(object sender,MouseEventArgs e)//wywolywanie metody klikania
        {
            this.form.RemoveKontrolka((UserControl)sender);//wywolanie usuwania kontrolek
        }
        
    }

}
