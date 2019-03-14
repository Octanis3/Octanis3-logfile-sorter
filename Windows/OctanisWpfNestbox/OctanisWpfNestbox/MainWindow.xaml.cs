using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace OctanisWpfNestbox
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, RoutedEventArgs e)
        {


            int compteur = 0;
            int exceptions = 0;


            
            String line;
            try
            {
                string[] files = Directory.GetFiles(Source.Text, "LOG*");
                StreamWriter srP = new StreamWriter(Destination.Text + "\\" + Pbox.Text + ".csv");
                StreamWriter srO = new StreamWriter(Destination.Text + "\\" + Obox.Text + ".csv");
                StreamWriter srH = new StreamWriter(Destination.Text + "\\" + Hbox.Text + ".csv");
                StreamWriter srT = new StreamWriter(Destination.Text + "\\" + Tbox.Text + ".csv");
                StreamWriter srD = new StreamWriter(Destination.Text + "\\" + Dbox.Text + ".csv");
                StreamWriter srX = new StreamWriter(Destination.Text + "\\" + Xbox.Text + ".csv");
                StreamWriter srR = new StreamWriter(Destination.Text + "\\" + Rbox.Text + ".csv");
                StreamWriter srE = new StreamWriter(Destination.Text + "\\" + Ebox.Text + ".csv");
                StreamWriter srU = new StreamWriter(Destination.Text + "\\" + Ubox.Text + ".csv");
                StreamWriter srA = new StreamWriter(Destination.Text + "\\" + Abox.Text + ".csv");
                StreamWriter srS = new StreamWriter(Destination.Text + "\\" + Sbox.Text + ".csv");



                int i = 0;
                for (i = 0; i < files.Length; i++)
                {
                    StreamReader sr = new StreamReader(files[i], System.Text.Encoding.UTF8);
                    //Read the first line of text
                    line = string.Empty;
                    //Continue to read until you reach end of file
                    while (line != null)
                    {
                        line = sr.ReadLine();

                        if (line != null)
                        {
                            compteur++;
                            //Read the next line

                            if (line.Contains("P,"))
                            {
                                srP.WriteLine(line);
                            }

                            if (line.Contains("O,"))
                            {
                                srO.WriteLine(line);
                            }

                            if (line.Contains("H,"))
                            {
                            }

                            if (line.Contains("T,"))
                            {
                                srT.WriteLine(line);
                            }

                            if (line.Contains("D,"))
                            {
                                srD.WriteLine(line);
                            }

                            if (line.Contains("X,"))
                            {
                                srX.WriteLine(line);
                            }

                            if (line.Contains("R,"))
                            {
                                srR.WriteLine(line);
                            }

                            if (line.Contains("E,"))
                            {
                                srE.WriteLine(line);
                            }

                            if (line.Contains("U,"))
                            {
                                srU.WriteLine(line);
                            }

                            if (line.Contains("A,"))
                            {
                                srA.WriteLine(line);
                            }

                            if (line.Contains("S,"))
                            {
                                srS.WriteLine(line);
                            }
                        }
                    }
                    sr.Close();
                }
                srP.Close();
                srO.Close();
                srH.Close();
                srT.Close();
                srD.Close();
                srX.Close();
                srR.Close();
                srE.Close();
                srU.Close();
                srA.Close();
                srS.Close();
            }



            catch (Exception )
            {
                exceptions++;
            }





            if (exceptions == 0 && compteur != 0)
            {
                MessageBox.Show("Operation completed successfully", "Info");
            }
            else
            {
                MessageBox.Show("An error occurred during the operation", "Error");
            }




        }

        private void BtnParcourir_Click(object sender, RoutedEventArgs e)
        {
            

            
        }
    }
}
