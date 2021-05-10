namespace Task0
{
    internal class ArrowsPosition
    {
        float X;
        float Y;
        public ArrowsPosition() { }
        public ArrowsPosition(float X, float Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public float GetX()
        {
            return X;
        }
        public float GetY()
        {
            return Y;
        }
        public void SetX(float value)
        {
            X = value;
        }
        public void SetY(float value)
        {
            Y = value;
        }
    }
}