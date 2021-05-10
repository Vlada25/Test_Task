using System.Drawing;
using System.Windows.Forms;

namespace Task0
{
    internal class MyArrows
    {
        readonly static ArrowsPosition startPosition = new ArrowsPosition(141, 141);
        public static ArrowsPosition GetStartPosition()
        {
            return startPosition;
        }
        public static void DrawArrow(Pen pen, float endX, float endY, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, GetStartPosition().GetX(), GetStartPosition().GetY(), endX, endY);
        }
    }
}