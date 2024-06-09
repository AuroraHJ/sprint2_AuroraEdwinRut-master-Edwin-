using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;
using System.Windows.Forms.DataVisualization.Charting;



namespace sprint2_AuroraEdwinRut
{
    public partial class config_balises : Form
    {
        SerialPort portArduino;
        string response;
        Dictionary<int, string> diccionario_info; //diccionario para almacenar int contador string resultado arduino


        public config_balises()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        
        private void cmb_ports_Enter(object sender, EventArgs e)
        {
            cmb_ports.Items.Clear();
            String[] ports;
            ports = SerialPort.GetPortNames();
            cmb_ports.Items.AddRange(ports);
        }
       
        private void btn_connectar_Click(object sender, EventArgs e)
        {
            portArduino = new SerialPort(cmb_ports.Text);
            portArduino.Open();
            //portArduino.Write("\n"); NO TANQUEM EL PORT PER REBRE DADES
            //if (portArduino.IsOpen)
            //{
            //    portArduino.Close();
            //}
            SerialReceive();

        }

        Thread filEscolta;

        private void SerialReceive()
        {
            filEscolta = new Thread(ReceiveData);
            filEscolta.Start();
        }

        private void ReceiveData()
        {
            int number;
            diccionario_info = new Dictionary<int, string>();
            int cc = 0;
            
            while (cc<60)
            {
                response = portArduino.ReadLine();

                txt_prova.Text = response;                

                int.TryParse(txt_cicles.Text, out number);

                diccionario_info.Add(cc, response);

                dtg_dades.Rows.Add(cc, response);

                chrt_resultats.Series.Clear();
                chrt_resultats.Series.Add("Valors");
                chrt_resultats.Series["Valors"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chrt_resultats.Series["Valors"].Points.DataBindXY(diccionario_info.Keys, diccionario_info.Values);
                chrt_resultats.ChartAreas[0].AxisY.Minimum = 0;
                chrt_resultats.ChartAreas[0].AxisX.Minimum = 0;
                chrt_resultats.Series["Valors"].BorderWidth = 5;

                cc++;
            }
        }


        private void btn_config_Click(object sender, EventArgs e)
        {
            int num_cicle = int.Parse(txt_cicles.Text);
            int num_divisor = int.Parse(txt_divisor.Text);
            string envio_datos;


            if (num_cicle >= num_divisor)
            {
                envio_datos = txt_cicles.Text + "#" + txt_divisor.Text;
                portArduino.Write(envio_datos + "\n");
            } else
            {
                lbl_aviscicles.Text = "Ingressa un número més gran que el divisor";
                lbl_aviscicles.ForeColor = Color.Red;
                txt_cicles.Text = "";
            }
        }

        private void txt_validating(object sender, CancelEventArgs e)
        {

            //Regex rgx = new Regex(@"^\d{1,2}$");  cadena de verbatim (@"...") en lugar de una cadena regular para que la barra invertida sea interpretada literalmente y no como un carácter de escape

            Regex rgx = new Regex("^\\d{1,2}$");
            bool correcte = rgx.IsMatch(txt_cicles.Text);

            if (correcte)
            {
                int num_grups = int.Parse(txt_cicles.Text);

                if (num_grups < 5 || num_grups > 20)
                {
                    lbl_aviscicles.Text = "ingresa un numero entre 5 y 20";
                    lbl_aviscicles.ForeColor = Color.Red;
                    txt_cicles.Text = "";
                    e.Cancel = true;

                }
                else
                {
                    lbl_aviscicles.Text = "correcte";
                    lbl_aviscicles.ForeColor = Color.Green;
                }
            }
            else
            {
                lbl_aviscicles.Text = "ingresa un numero entre 5 y 20";
                lbl_aviscicles.ForeColor = Color.Red;
                txt_cicles.Text = "";
                e.Cancel = true;
            }
            //TextBox ctr = (TextBox)sender;
            //int valor;

            //if (!int.TryParse(ctr.Text, out valor))
            //{
            //    ctr.Text = "";
            //    e.Cancel = true;
            //}
        }

        private void txt_divisor_Validating(object sender, CancelEventArgs e)
        {
            List<int> divisores = new List<int> { 1, 3, 5, 7 };
            Regex rgx = new Regex("^\\d{1}$");
            bool correcte = rgx.IsMatch(txt_divisor.Text);
            String mensaje_error = "ingresa un numero 1,2,3,5,7";

            //en lugar de usar expresion regular se puede usar try parseint
            // if (int.TryParse(txt_divisor.Text, out int valorIngresado))
            if (correcte)
            {
                if (divisores.Contains(int.Parse(txt_divisor.Text)))
                {
                    lbl_avisdivisor.Text = "correcto";
                    lbl_avisdivisor.ForeColor = Color.Green;
                }
                else
                {
                    lbl_avisdivisor.Text = mensaje_error;
                    lbl_avisdivisor.ForeColor = Color.Red;
                    txt_divisor.Text = "";
                    e.Cancel = true;
                }
            }
            else
            {
                lbl_avisdivisor.Text = mensaje_error;
                lbl_avisdivisor.ForeColor = Color.Red;
                txt_divisor.Text = "";
                e.Cancel = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (portArduino.IsOpen)
            {
                portArduino.Close();
            }
            //if (filEscolta.IsAlive)
            //{
            //    filEscolta.Abort();
            //}
        }
    }
}
