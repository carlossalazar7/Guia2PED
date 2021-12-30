namespace Guia2._3PED
{
    public partial class Form1 : Form
    {
        enum Position //define un set de constantes  que pueden  ser asignados a una variable
        {
            izquierda,derecha, arriba, abajo
        }

        private int x, y;
        private Position objposition;

        public Form1()
        {
            InitializeComponent();
            x = 50;
            y = 50;
            objposition = Position.abajo;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("leon.jpg"),x,y,65,65);    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(objposition == Position.derecha)
            {
                x += 10;
            }
            if (objposition == Position.izquierda)
            {
                x -= 10;
            }
            if (objposition == Position.arriba)
            {
                y -= 10;
            }
            if (objposition == Position.abajo)
            {
                y += 10;
            }
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                objposition = Position.izquierda;
            }
            if (e.KeyCode == Keys.Right)
            {
                objposition = Position.derecha;
            }
            if (e.KeyCode == Keys.Up)
            {
                objposition = Position.arriba;
            }
            if (e.KeyCode == Keys.Down)
            {
                objposition = Position.abajo;
            }
        }
    }
}