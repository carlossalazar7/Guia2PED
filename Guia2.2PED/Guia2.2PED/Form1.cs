namespace Guia2._2PED
{
    public partial class Form1 : Form
    {
        Graphics area; //área de trabajo
        public Form1()
        {
            InitializeComponent();
            area = areadibujo.CreateGraphics();
        }

        private void btndibujar_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black);
            switch (cmbcolor.SelectedIndex)
            {
                case 0: lapicero.Color = Color.LightGoldenrodYellow; break;
                case 1: lapicero.Color = Color.Red; break;
                case 2: lapicero.Color = Color.Blue; break;
                case 3: lapicero.Color = Color.Black; break;
            }

            int iteraciones = int.Parse(txtcantidad.Text);
            int espacio = int.Parse(txtespaciado.Text);

            area.Clear(Color.White);
            int puntoinicio = 50;
            
            for (int i = 0;i < iteraciones; i++)
            {
                if (radioButton1.Checked)
                {
                    area.DrawLine(lapicero, 20, puntoinicio + (espacio * i), 300, puntoinicio + (espacio * i));

                }
                else if (radioButton2.Checked)
                {
                    area.DrawLine(lapicero,puntoinicio + (espacio * i), 20, puntoinicio + (espacio * i), 300);
                }else if (radioButton3.Checked)
                {
                    area.DrawLine(lapicero, puntoinicio + (espacio * i), 20, (puntoinicio * 3) + (espacio * i), 300);
                }
                else
                {
                    area.DrawLine(lapicero, (puntoinicio * 3)+ (espacio * i),20, puntoinicio + (espacio * i), 300);
                }
            }
        }
    }
}