namespace Guia2PED
{
    public partial class Form1 : Form
    {
        int x, y;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = panel1.CreateGraphics(); //establece zona para dibujo
            Pen lapiz = new Pen(Color.Blue);      //declaro color de pen a utilizar

            if (listBox1.SelectedIndex == 0)
            {
                SolidBrush sb = new SolidBrush(Color.Red);//brush en rojo
                g.DrawEllipse(lapiz, x - 50, y - 50, 100, 100);  //dibujara elipse utilizando ese pen, con la posición en x,y menos 50 y dimensiones 100
                g.FillEllipse(sb,x - 50,y - 50,100,100); //rellena de color la elipse dada
            }

            if (listBox1.SelectedIndex == 1)
            {
                SolidBrush sb = new SolidBrush(Color.Green);//brush en rojo
                g.DrawRectangle(lapiz, x - 50, y - 50, 100, 100);  //dibujara elipse utilizando ese pen, con la posición en x,y menos 50 y dimensiones 100
                g.FillRectangle(sb, x - 50, y - 50, 100, 100); //rellena de color la elipse dada
            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Point punto = new(e.X, e.Y);
            x = punto.X;
            y = punto.Y;

            panel1.Invalidate();

        }
    }
}