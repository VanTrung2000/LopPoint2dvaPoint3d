using System;
using System.Collections.Generic;
using System.Text;

namespace LopPoint2dPoint3d
{
    class Point2d
    {
        private float X;
        private float Y;
        public Point2d(float _X, float _Y)
        {
            X = _X;
            Y = _Y;
        }
        public Point2d()
        {

        }
        public float GetX()
        {
            return X;
        }
        public float GetY()
        {
            return Y;
        }
        public void SetX(float _X)
        {
            X = _X;
        }
        public void SetY(float _Y)
        {
            Y = _Y;
        }
        public void SetXY(float _X, float _Y)
        {
            X = _X;
            Y = _Y;
        }
        public float[] GetXY()
        {
            float[] xy = new float[2] { X, Y };
            return xy;
        }

        public override string ToString()
        {
            return "X = " + GetX() + " Y = " + GetY() + " (X,Y) = " + string.Join(',', GetXY());
        }
    }
}
