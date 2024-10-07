using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animals;

namespace Portee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Animals.Chien.Marcher();
            Chien bulldog;
            bulldog = new Chien();
            bulldog.Japper();
            bulldog.PeutSauter();

            MonChien pitbull=new MonChien();
            pitbull.PeutCoucher();
        }
    }
}
namespace Animals
{
    public class Chien
    {
        public static void Marcher()
        {
            //utiliser les membres sans creer une nouvelle instance
            MessageBox.Show("Marcher");

        }

        public void Japper()
        {
            //pas de restrictions accessible partout
            MessageBox.Show("japper");

        }
        private void Sauter()
        {
            //accesible que dans son contexte
            MessageBox.Show("sauter");
            Sauter();
        }

        public void PeutSauter()
        {
            Sauter();
        }

        protected void Coucher()
        {//aaccessible <linterieur  de son contexte et es classes derivees
            MessageBox.Show("coucher");

        }
        //public void PeutCoucher()
        //{
        //    Coucher();
        //}
    }

   
}
namespace Animals
{
    public class MonChien:Chien
    {
        public void PeutCoucher()
        {
            Coucher();
        }

    }

}