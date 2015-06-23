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
    public partial class E : UserControl
{
      
        private List<Form> Observers = new List<Form>();
        private Form1 form;
        
         public E(){}
        public E(Form1 form)
        {
            InitializeComponent();
            this.form = form;
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Click);
        }

        public void Click(object sender, MouseEventArgs e)
        {
            this.form.RemoveKontrolka((UserControl)sender);
        }
    }
}
