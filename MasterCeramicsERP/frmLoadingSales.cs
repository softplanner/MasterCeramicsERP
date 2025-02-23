using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MasterCeramicsERP
{
    public partial class frmLoadingSales : Form
    {
        public frmLoadingSales()
        {
            InitializeComponent();
        }

        private void frmLoadingSales_Load(object sender, EventArgs e)
        {
            //Thread a = new Thread(new ThreadStart(loadingPage1));
            //Thread b = new Thread(new ThreadStart(loadingPage2)); ;
            //a.Start();
            //b.Start();
          //  Launcher la = new Launcher();

            Thread firstThread = new Thread(new ThreadStart(Coundown));
            Thread secondThread = new Thread(new ThreadStart(Coundown));
            Thread thirdThread = new Thread(new ThreadStart(Coundown));

            firstThread.Start();
            secondThread.Start();
            thirdThread.Start();
        }
        public void Coundown()
        {

            lock (this)
            {

                for (int i = 4; i >= 0; i--)
                {

                    Console.WriteLine("{0} seconds to start", i);

                }

                Console.WriteLine("GO!!!!!");

            }

        } 

        //private void loadingPage1()
        //{
            
        //    for (int i = 1; i <= 10; i++)
        //    {
        //        Console.WriteLine(i.ToString());
        //        Thread.Sleep(500);
        //    }
        //}
        //private void loadingPage2()
        //{

        //    for (int i = 2; i <= 10; i=i+2)
        //    {
        //        Console.WriteLine(i.ToString());
        //        Thread.Sleep(500);
        //    }
        //}
    }
}
