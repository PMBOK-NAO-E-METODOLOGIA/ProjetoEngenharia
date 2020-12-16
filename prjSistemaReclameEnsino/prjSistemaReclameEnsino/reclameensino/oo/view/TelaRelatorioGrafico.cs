using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using prjSistemaReclameEnsino.reclameensino.oo.model;

namespace prjSistemaReclameEnsino.reclameensino.oo.view
{
    public partial class TelaRelatorioGrafico : Form
    {
        public TelaRelatorioGrafico()
        {
            InitializeComponent();
        }

        private void TelaRelatorioGrafico_Load(object sender, EventArgs e)
        {
            GerarGraficoPizza();
        }

        public void GerarGraficoPizza()
        {

            Comentario comentario = new Comentario();

            Legend legend = new Legend();
            chGrafico.Legends.Add(legend);
            chGrafico.Legends[0].Title = "Legenda";


            Title title = new Title();
            title.Font = new Font("Arial", 14, FontStyle.Bold);
            title.ForeColor = Color.Brown;
            title.Text = "Análise Percentual";
            chGrafico.Titles.Add(title);

            //Criando a série de dados - respondidas
            chGrafico.Series.Add("sugestoes_resp");

            chGrafico.Series["sugestoes_resp"].LegendText = "Respondidas";

            chGrafico.Series["sugestoes_resp"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chGrafico.Series["sugestoes_resp"].BorderWidth = 4;

            chGrafico.Series["sugestoes_resp"].Points.AddXY("Respondidas", comentario.RetornarQtdRespondidos());

            //Criando a série de dados - vistadas
            chGrafico.Series.Add("sugestoes_vist");

            chGrafico.Series["sugestoes_vist"].LegendText = "Vistadas";

            chGrafico.Series["sugestoes_vist"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

            chGrafico.Series["sugestoes_vist"].BorderWidth = 4;

            chGrafico.Series["sugestoes_vist"].Points.AddXY("Vistadas", comentario.RetornarQtdVistados());

        }

    }
}
