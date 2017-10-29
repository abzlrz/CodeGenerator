using System.Drawing;
using System.Windows.Forms;

namespace CodeGenerator
{
    public class Draggable
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private Form _form;

        public Draggable(Control ctrl, Form form)
        {
            ctrl = new Control();
            this._form = form;
        }

        public void Up(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        public void Down(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = _form.Location;
        }

        public void Move(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                _form.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
    }
}
