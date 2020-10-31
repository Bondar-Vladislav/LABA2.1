using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp1
{
    public partial class Form1 : Form
    {
        public string name = "Бондарь Владислав";

        public Form1()
        {
            InitializeComponent();

            for (double i = 0; i <= 10; i += 0.1)
                chart1.Series[0].Points.AddXY(i, Program.TheFunc(name, i));
            double c = Program.TheFunc(name, 0);
            double a = (Program.TheFunc(name, 1) + Program.TheFunc(name, -1)) / 2 - c;
            double b = (Program.TheFunc(name, 1) - Program.TheFunc(name, -1)) / 2;

            label1.Text = $"A = {a}     B = {b}     C = {c}";
        }
    }
}
