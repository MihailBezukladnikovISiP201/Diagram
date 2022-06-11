using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagram
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double five, four, three, two;

        private void btnGisto_Click(object sender, EventArgs e)
        {
            chartMy.Visible = false;
            chart1.Visible = true;

            chartMy.Series[0].Points.Clear();
            chart1.Series[0].Points.Clear();

            five = double.Parse(fiveTB.Text);
            chart1.Series[0].Points.AddXY("", five);
            four = double.Parse(fourTB.Text);
            chart1.Series[0].Points.AddXY("", four);
            three = double.Parse(threeTB.Text);
            chart1.Series[0].Points.AddXY("", three);
            two = double.Parse(twoTB.Text);
            chart1.Series[0].Points.AddXY("", two);

            chart1.Series[0].Points[0].LegendText = $"Пятёрки %{Math.Round(five / (five + three + four + two) * 100, 0)}";
            chart1.Series[0].Points[1].LegendText = $"Четвёрки %{Math.Round(four / (five + three + four + two) * 100, 0)}";
            chart1.Series[0].Points[2].LegendText = $"Тройки %{Math.Round(three / (five + three + four + two) * 100, 0)}";
            chart1.Series[0].Points[3].LegendText = $"Двойки %{Math.Round(two / (five + three + four + two) * 100, 0)}";
        }
        
        private void btnDiagram_Click(object sender, EventArgs e)
        {
            chartMy.Visible = true;
            chart1.Visible = false;

            chartMy.Series[0].Points.Clear();
            chart1.Series[0].Points.Clear();

            five = double.Parse(fiveTB.Text);
            chartMy.Series[0].Points.AddXY("",five);
            four = double.Parse(fourTB.Text);
            chartMy.Series[0].Points.AddXY("", four);
            three = double.Parse(threeTB.Text);
            chartMy.Series[0].Points.AddXY("", three);
            two = double.Parse(twoTB.Text);
            chartMy.Series[0].Points.AddXY("", two);

            chartMy.Series[0].Points[0].LegendText = $"Пятёрки %{Math.Round(five / (five + three + four + two) * 100,0)}";
            chartMy.Series[0].Points[1].LegendText = $"Четвёрки %{Math.Round(four / (five + three + four + two) * 100,0)}";
            chartMy.Series[0].Points[2].LegendText = $"Тройки %{Math.Round(three / (five + three + four + two) * 100,0)}";
            chartMy.Series[0].Points[3].LegendText = $"Двойки %{Math.Round(two / (five + three + four + two) * 100,0)}";
        }
    }
}
