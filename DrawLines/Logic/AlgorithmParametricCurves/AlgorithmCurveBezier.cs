using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines.Logic
{
    public class AlgorithmCurveBezier
    {
        public List<PointF> PuntosControl { get; private set; } = new List<PointF>();
        public List<PointF> CurvaGenerada { get; private set; } = new List<PointF>();

        public float tActual { get; private set; } = 0;
        public float PasoT { get; set; } = 0.01f;

        public AlgorithmCurveBezier()
        {
            Reset();
        }

        public void AgregarPunto(PointF p)
        {
            if (PuntosControl.Count < 4)
                PuntosControl.Add(p);
        }

        public bool ListoParaAnimar()
        {
            return PuntosControl.Count == 4;
        }

        public void Reset()
        {
            PuntosControl.Clear();
            CurvaGenerada.Clear();
            tActual = 0;
        }

        public void ReiniciarAnimacion()
        {
            CurvaGenerada.Clear();
            tActual = 0;
        }

        public (PointF A, PointF B, PointF C, PointF D, PointF E, PointF F)? AvanzarPaso()
        {
            if (!ListoParaAnimar() || tActual > 1)
                return null;

            PointF P0 = PuntosControl[0];
            PointF P1 = PuntosControl[1];
            PointF P2 = PuntosControl[2];
            PointF P3 = PuntosControl[3];

            float t = tActual;

            PointF A = Lerp(P0, P1, t);
            PointF B = Lerp(P1, P2, t);
            PointF C = Lerp(P2, P3, t);

            PointF D = Lerp(A, B, t);
            PointF E = Lerp(B, C, t);

            PointF F = Lerp(D, E, t);

            CurvaGenerada.Add(F);
            tActual += PasoT;

            return (A, B, C, D, E, F);
        }

        private PointF Lerp(PointF p1, PointF p2, float t)
        {
            return new PointF(
                p1.X + (p2.X - p1.X) * t,
                p1.Y + (p2.Y - p1.Y) * t
            );
        }
    }

}
