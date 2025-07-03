using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines.Logic.AlgorithmParametricCurves
{
    public class BSplineAlgorithm
    {
        public List<PointF> ControlPoints { get; private set; } = new List<PointF>();
        public List<PointF> GeneratedCurve { get; private set; } = new List<PointF>();
        private float currentT = 0f;
        public float StepT { get; set; } = 0.01f;

        public void AddPoint(PointF p)
        {
            ControlPoints.Add(p);
        }

        public void Reset()
        {
            ControlPoints.Clear();
            GeneratedCurve.Clear();
            currentT = 0f;
        }

        public void RestartAnimation()
        {
            GeneratedCurve.Clear();
            currentT = 0f;
        }

        public bool ReadyToAnimate()
        {
            return ControlPoints.Count >= 4;
        }

        public PointF? AdvanceStep()
        {
            if (!ReadyToAnimate() || currentT > ControlPoints.Count - 3)
                return null;

            PointF point = CalculateBSpline(currentT);
            GeneratedCurve.Add(point);
            currentT += StepT;
            return point;
        }

        public void GenerateFullCurve()
        {
            GeneratedCurve.Clear();
            for (float t = 0; t <= ControlPoints.Count - 3; t += StepT)
            {
                GeneratedCurve.Add(CalculateBSpline(t));
            }
        }

        private PointF CalculateBSpline(float t)
        {
            int i = (int)Math.Floor(t);
            float u = t - i;

            if (i + 3 >= ControlPoints.Count)
                return ControlPoints[ControlPoints.Count - 1];

            PointF P0 = ControlPoints[i];
            PointF P1 = ControlPoints[i + 1];
            PointF P2 = ControlPoints[i + 2];
            PointF P3 = ControlPoints[i + 3];

            float u2 = u * u;
            float u3 = u2 * u;

            float x = (1f / 6f) * (
                (-u3 + 3 * u2 - 3 * u + 1) * P0.X +
                (3 * u3 - 6 * u2 + 4) * P1.X +
                (-3 * u3 + 3 * u2 + 3 * u + 1) * P2.X +
                u3 * P3.X);

            float y = (1f / 6f) * (
                (-u3 + 3 * u2 - 3 * u + 1) * P0.Y +
                (3 * u3 - 6 * u2 + 4) * P1.Y +
                (-3 * u3 + 3 * u2 + 3 * u + 1) * P2.Y +
                u3 * P3.Y);

            return new PointF(x, y);
        }
    }
}
