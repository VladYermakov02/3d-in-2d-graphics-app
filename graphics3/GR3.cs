using System;
using System.Collections.Generic;
using System.Drawing;

namespace graphics3
{
    enum projType { above, left, front, isometry, dimetry }
    enum axe { ox, oy, oz }

    struct point3D
    {
        public double x, y, z;
        public point3D(double ax, double ay, double az)
        {
            x = ax;
            y = ay;
            z = az;
        }
        public Point project(projType proj)
        {
            switch (proj)
            {
                case projType.above:
                    return new Point(100 + (int)x, 100 + (int)z);
                case projType.left:
                    return new Point(80 + (int)z, 80 + (int)y);
                case projType.front:
                    return new Point(80 + (int)x, 80 + (int)y);
                case projType.dimetry:
                    return new Point(150 + (int)(x * 0.935 - 0.354 * z), 150 + (int)(-0.118 * x + 0.943 * y - 0.312 * z));
                case projType.isometry:
                    return new Point(230 + (int)(x * 0.707 - 0.707 * z), 230 + (int)(-0.408 * x + 0.816 * y - 0.408 * z));
                default:
                    return new Point(0, 0);
            }
        }
    }

    class GraphObject
    {
        public point3D[] points;
        protected int pointNum;
        public virtual void draw(Graphics g, projType proj, bool hide = false)
        { }

        private point3D center()
        {
            point3D c = new point3D(0, 0, 0);
            for (int i = 0; i < pointNum; i++)
            {
                c.x += points[i].x;
                c.y += points[i].y;
                c.z += points[i].z;
            }
            c.x /= pointNum;
            c.y /= pointNum;
            c.z /= pointNum;
            return c;
        }

        public virtual void rotate(double angle, axe ax)
        {
            point3D cnt = center();
            double rad = angle * Math.PI / 180;
            for (int i = 0; i < pointNum; i++)
            {
                point3D tmp = points[i];
                switch (ax)
                {
                    case axe.ox:
                        points[i].y = (tmp.y - cnt.y) * Math.Cos(rad) - (tmp.z - cnt.z) * Math.Sin(rad) + cnt.y;
                        points[i].z = (tmp.y - cnt.y) * Math.Sin(rad) + (tmp.z - cnt.z) * Math.Cos(rad) + cnt.z;
                        break;
                    case axe.oy:
                        points[i].x = (tmp.x - cnt.x) * Math.Cos(rad) - (tmp.z - cnt.z) * Math.Sin(rad) + cnt.x;
                        points[i].z = (tmp.x - cnt.x) * Math.Sin(rad) + (tmp.z - cnt.z) * Math.Cos(rad) + cnt.z;
                        break;
                    case axe.oz:
                        points[i].x = (tmp.x - cnt.x) * Math.Cos(rad) - (tmp.y - cnt.y) * Math.Sin(rad) + cnt.x;
                        points[i].y = (tmp.x - cnt.x) * Math.Sin(rad) + (tmp.y - cnt.y) * Math.Cos(rad) + cnt.y;
                        break;
                }
            }
        }
        public virtual void scale(double sx, double sy, double sz)
        {
            point3D cnt = center();
            for (int i = 0; i < pointNum; i++)
            {
                points[i].x = (points[i].x - cnt.x) * sx + cnt.x;
                points[i].y = (points[i].y - cnt.y) * sy + cnt.y;
                points[i].z = (points[i].z - cnt.z) * sz + cnt.z;
            }
        }
        public virtual void move(double dx, double dy, double dz)
        {
            for (int i = 0; i < pointNum; i++)
            {
                point3D tmp = points[i];
                points[i].x = tmp.x + dx;
                points[i].y = tmp.y + dy;
                points[i].z = tmp.z + dz;
            }
        }
        public void drawAxes(Graphics g, projType proj)
        {
            int startDot = 100;
            switch (proj)
            {
                case projType.above:
                    drawAxisProj(g, Brushes.Red, Pens.Red, "x", startDot, startDot, 200, 100); // x
                    drawAxisProj(g, Brushes.Green, Pens.Green, "y", startDot, startDot, 100, 100); // y
                    drawAxisProj(g, Brushes.Blue, Pens.Blue, "z", startDot, startDot, 100, 200); // z
                    break;
                case projType.left:
                    drawAxisProj(g, Brushes.Red, Pens.Red, "x", startDot, startDot, 100, 100); // x
                    drawAxisProj(g, Brushes.Green, Pens.Green, "y", startDot, startDot, 100, 0); // y
                    drawAxisProj(g, Brushes.Blue, Pens.Blue, "z", startDot, startDot, 0, 100); // z
                    break;
                case projType.front:
                    drawAxisProj(g, Brushes.Red, Pens.Red, "x", startDot, startDot, 200, 100); // x
                    drawAxisProj(g, Brushes.Green, Pens.Green, "y", startDot, startDot, 100, 0); // y
                    drawAxisProj(g, Brushes.Blue, Pens.Blue, "z", startDot, startDot, 100, 100); // z
                    break;
                case projType.dimetry:
                    point3D p3dStart = calculateDimetryDot(150, 150, 150);
                    point3D p3d_1 = calculateDimetryDot(250, 150, 150);
                    point3D p3d_2 = calculateDimetryDot(150, 50, 150);
                    point3D p3d_3 = calculateDimetryDot(150, 150, 250);
                    drawAxisProj(g, Brushes.Red, Pens.Red, "x", (int)p3dStart.x, (int)p3dStart.y, (int)p3d_1.x, (int)p3d_1.y); // x
                    drawAxisProj(g, Brushes.Green, Pens.Green, "y", (int)p3dStart.x, (int)p3dStart.y, (int)p3d_2.x, (int)p3d_2.y); // y
                    drawAxisProj(g, Brushes.Blue, Pens.Blue, "z", (int)p3dStart.x, (int)p3dStart.y, (int)p3d_3.x, (int)p3d_3.y); // z
                    break;
                case projType.isometry:
                    point3D p3dStartIsom = calculateIsometryDot(150, 150, 150);
                    point3D p3d_1Isom = calculateIsometryDot(250, 150, 150);
                    point3D p3d_2Isom = calculateIsometryDot(150, 50, 150);
                    point3D p3d_3Isom = calculateIsometryDot(150, 150, 250);
                    drawAxisProj(g, Brushes.Red, Pens.Red, "x", 70 + (int)p3dStartIsom.x, 70 + (int)p3dStartIsom.y, 70 + (int)p3d_1Isom.x, 70 + (int)p3d_1Isom.y); // x
                    drawAxisProj(g, Brushes.Green, Pens.Green, "y", 70 + (int)p3dStartIsom.x, 70 + (int)p3dStartIsom.y, 70 + (int)p3d_2Isom.x, 70 + (int)p3d_2Isom.y); // y
                    drawAxisProj(g, Brushes.Blue, Pens.Blue, "z", 70 + (int)p3dStartIsom.x, 70 + (int)p3dStartIsom.y, 70 + (int)p3d_3Isom.x, 70 + (int)p3d_3Isom.y); // z
                    break;
                default:
                    break;
            }
        }
        private point3D calculateDimetryDot(int x, int y, int z)
        {
            point3D p3d = new point3D(x, y, z);
            p3d.x = p3d.x * 0.935 - 0.354 * p3d.z;
            p3d.y = -0.118 * p3d.x + 0.943 * p3d.y - 0.312 * p3d.z;
            return p3d;
        }

        private point3D calculateIsometryDot(int x, int y, int z)
        {
            point3D p3d = new point3D(x, y, z);
            p3d.x = p3d.x * 0.707 - 0.707 * p3d.z;
            p3d.y = -0.408 * p3d.x + 0.816 * p3d.y - 0.408 * p3d.z;
            return p3d;
        }
        private void drawAxisProj(Graphics g, Brush brush, Pen pen, String axisName,
            int startDotX, int startDotY, int xFinal, int yFinal)
        {
            g.DrawLine(pen, startDotX, startDotY, xFinal, yFinal);
            g.DrawString(axisName, SystemFonts.DefaultFont, brush, xFinal + 5, yFinal + 5);
        }
    }
    class Pyramid : GraphObject
    {
        const int baseSidesNum = 3;

        public Pyramid(int cx, int cz, int rad1, int rad2, int height)
        {
            pointNum = 6;
            points = new point3D[pointNum];
            double ang = 0;
            for (int i = 0; i < baseSidesNum; i++, ang += 360 / baseSidesNum)
            {
                double rad = Math.PI * ang / 180;
                points[i] = new point3D(cx + rad1 * Math.Sin(rad), 0, cz + rad1 * Math.Cos(rad));
                points[i + baseSidesNum] = new point3D(cx + rad2 * Math.Sin(rad), height, cz + rad2 * Math.Cos(rad));
            }
        }
        private point3D centerPoint(List<point3D> pnt)
        {
            point3D c = new point3D(0, 0, 0);
            for (int i = 0; i < pnt.Count; i++)
            {
                c.x += points[i].x;
                c.y += points[i].y;
                c.z += points[i].z;
            }
            c.x /= pnt.Count;
            c.y /= pnt.Count;
            c.z /= pnt.Count;
            return c;
        }

        public override void draw(Graphics g, projType proj, bool hide)
        {
            List<List<point3D>> rects = new List<List<point3D>>();
            rects.Add(new List<point3D>());
            rects.Add(new List<point3D>());

            for (int i = 0; i < baseSidesNum; i++)
            {
                rects[0].Add(points[i]); // top
                rects[1].Add(points[i + baseSidesNum]); // bottom
                rects.Add(new List<point3D> { points[i], points[i + baseSidesNum], points[(i + 1) % baseSidesNum + baseSidesNum] }); // edges
                //rects.Add(new List<point3D> { points[i], points[i + baseSidesNum], points[(i + 1) % baseSidesNum + baseSidesNum], points[(i + 1) % baseSidesNum] }); // edges
                /*g.DrawLine(Pens.Black, points[i].project(proj), points[(i + 1) % baseSidesNum].project(proj)); // top
                g.DrawLine(Pens.Black, points[i + baseSidesNum].project(proj), points[(i + 1) % baseSidesNum + baseSidesNum].project(proj)); // bottom
                g.DrawLine(Pens.Black, points[i].project(proj), points[i + baseSidesNum].project(proj)); // edges*/
            }

            //hidden edges
            if (hide)
            {
                rects.Sort(delegate (List<point3D> rect1, List<point3D> rect2)
                {
                    return centerPoint(rect1).z > centerPoint(rect2).z ? 1 : -1;
                });
            }

            foreach (var rect in rects)
            {
                List<Point> projRect = new List<Point>();
                foreach (point3D p in rect)
                    projRect.Add(p.project(proj));
                projRect.Add(projRect[0]);

                g.DrawLines(Pens.Black, projRect.ToArray());
                if (hide)
                    g.FillPolygon(Brushes.White, projRect.ToArray());
            }
        }
    }

    class Matrix
    {
        public double[,] elem = new double[4, 4];
        int n, m;
        public Matrix(int an, int am)
        {
            n = am; m = am;
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    elem[i, j] = 0;
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix res = new Matrix(m1.n, m2.m);
            for (int i = 0; i < res.m; i++)
            {
                for (int j = 0; j < res.n; j++)
                {
                    double s = 0;
                    for (int k = 0; k < m1.m; k++)
                        s += m1.elem[j, k] * m2.elem[k, i];
                    res.elem[j, i] = s;
                }
            }
            return res;
        }
    }

    /*class BiezSurface : GraphObject
    {
        // mh - Матрица Эрмита
        // mhT - Матрица Эрмита транспонированная
        public Matrix Mh = new Matrix(4, 4);
        public Matrix MhT = new Matrix(4, 4);

        public BiezSurface(point3D[] aPoints)
        {
            pointNum = 16;
            points = aPoints;
            double[,] mh =
            {
                { 2, -2, 1, 1},
                { -3, 3, -2, -1},
                { 0, 0, 1, 0},
                { 1, 0, 0, 0},
            };

            Mh.elem = mh;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    MhT.elem[i, j] = Mh.elem[i, j];
        }

        public override void draw(Graphics g, projType proj, bool hide = false)
        {
            Matrix S = new Matrix(1, 4);
            Matrix T = new Matrix(4, 1);
            Matrix Px = new Matrix(4, 4);
            Matrix Py = new Matrix(4, 4);
            Matrix Pz = new Matrix(4, 4);

            for (int i = 0; i < 16; i++)
            {
                Px.elem[i / 4, i % 4] = points[i].x;
                Py.elem[i / 4, i % 4] = points[i].y;
                Pz.elem[i / 4, i % 4] = points[i].z;
            }

            double stp = 0.05; // step
            for (double t = 0; t <= 1; t += stp)
            {
                T.elem[0, 0] = t * t * t;
                T.elem[1, 0] = t * t;
                T.elem[2, 0] = t;
                T.elem[3, 0] = 1;
                for (double s = 0; s <= 1; s += stp)
                {
                    S.elem[0, 0] = s * s * t;
                    S.elem[0, 1] = s * s;
                    S.elem[0, 2] = s;
                    S.elem[0, 3] = 1;

                    point3D p;
                    p.x = 500 + (S * Mh * Px * MhT * T).elem[0, 0];
                    p.y = 500 + (S * Mh * Py * MhT * T).elem[0, 0];
                    p.z = (S * Mh * Pz * MhT * T).elem[0, 0];

                    Point pt = p.project(proj);

                    g.FillEllipse(Brushes.Black, pt.X, pt.Y, 4, 4);
                }
            }
        }
    }*/

    class BiezSurface : GraphObject
    {
        // mb - Матрица Безье
        // mbT - Матрица Безье транспонированная
        public Matrix Mb = new Matrix(4, 4);
        public Matrix MbT = new Matrix(4, 4);

        public BiezSurface(point3D[] aPoints)
        {
            pointNum = 16;
            points = aPoints;
            double[,] mb =
            {
                { -1, 3, -3, 1},
                { 3, -6, 3, 0},
                { -3, 3, 0, 0},
                { 1, 0, 0, 0},
            };

            Mb.elem = mb;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                    MbT.elem[i, j] = Mb.elem[i, j];
        }

        public override void draw(Graphics g, projType proj, bool hide = false)
        {
            Matrix S = new Matrix(1, 4);
            Matrix T = new Matrix(4, 1);
            Matrix Px = new Matrix(4, 4);
            Matrix Py = new Matrix(4, 4);
            Matrix Pz = new Matrix(4, 4);
            int i = 0, j = 0;

            for (i = 0; i < 16; i++)
            {
                Px.elem[i / 4, i % 4] = points[i].x;
                Py.elem[i / 4, i % 4] = points[i].y;
                Pz.elem[i / 4, i % 4] = points[i].z;
            }

            double stp = 0.05; // step
            Point[,] rects = new Point[(int)(1 / stp + 1), (int)(1 / stp + 1)];
            i = 0;
            for (double t = 0; t <= 1; t += stp)
            {
                T.elem[0, 0] = t * t * t;
                T.elem[1, 0] = t * t;
                T.elem[2, 0] = t;
                T.elem[3, 0] = 1;
                j = 0;
                for (double s = 0; s <= 1; s += stp)
                {
                    S.elem[0, 0] = s * s * t;
                    S.elem[0, 1] = s * s;
                    S.elem[0, 2] = s;
                    S.elem[0, 3] = 1;

                    point3D p;
                    p.x = (S * Mb * Px * MbT * T).elem[0, 0];
                    p.y = (S * Mb * Py * MbT * T).elem[0, 0];
                    p.z = (S * Mb * Pz * MbT * T).elem[0, 0];

                    Point pt = p.project(proj);

                    rects[i, j] = pt;
                    j++;
                    //g.FillEllipse(Brushes.Black, pt.X, pt.Y, 4, 4);
                }
                i++;
            }
            for (i = 0; i < 1 / stp - 1; i++)
            {
                for (j = 0; j < 1 / stp - 1; j++)
                {
                    List<Point> sp = new List<Point> { rects[i, j], rects[i + 1, j], rects[i + 1, j + 1], rects[i, j + 1], rects[i, j] };
                    g.DrawLines(Pens.Black, sp.ToArray());
                }
            }
        }
    }
}

/* FIRST LOOK
public void drawAxes(Graphics g, projType proj)
        {
            int startDot = 100;
            Pen pXRed = new Pen(Brushes.Red);
            Pen pYGreen = new Pen(Brushes.Green);
            Pen pZBlue = new Pen(Brushes.Blue);
            switch (proj)
            {
                case projType.above:
                    draw2DProjAxes(g, Brushes.Red, pXRed, "x", startDot, 200, 100); // x
                    draw2DProjAxes(g, Brushes.Green, pYGreen, "x", startDot, 100, 100); // x
                    draw2DProjAxes(g, Brushes.Blue, pZBlue, "x", startDot, 100, 200); // x
                    //g.DrawLine(pXRed, 100, 100, 200, 100); // x
                    //g.DrawString("x", SystemFonts.DefaultFont, Brushes.Red, 205, 105);
                    //g.DrawLine(pYGreen, 100, 100, 100, 100); // y
                    //g.DrawString("y", SystemFonts.DefaultFont, Brushes.Green, 105, 105);
                    //g.DrawLine(pZBlue, 100, 100, 100, 200); // z
                    //g.DrawString("z", SystemFonts.DefaultFont, Brushes.Blue, 105, 205);
                    break;
                case projType.left:
                    g.DrawLine(pXRed, 100, 100, 100, 100); // x
                    g.DrawLine(pYGreen, 100, 100, 100, 0); // y
                    g.DrawLine(pZBlue, 100, 100, 0, 100); // z
                    break;
                case projType.front:
                    g.DrawLine(pXRed, 100, 100, 200, 100); // x
                    g.DrawLine(pYGreen, 100, 100, 100, 0); // y
                    g.DrawLine(pZBlue, 100, 100, 100, 100); // z
                    break;
                case projType.dimetry:
                    double x = 200, y = 120, z = 150;
                    double x2 = 80, y2 = 170, z2 = 20;
                    g.DrawLine(pXRed, 100, 100, (int)(x * 0.935 - 0.354 * z), (int)(-0.118 * x + 0.943 * y - 0.312 * z)); // x
                    g.DrawLine(pYGreen, 100, 100, 100, 0); // y
                    g.DrawLine(pZBlue, 100, 100, (int)(x2 * 0.935 - 0.354 * z2), (int)(-0.118 * x2 + 0.943 * y2 - 0.312 * z2)); // z
                    break;
                case projType.isometry:
                    g.DrawLine(pXRed, 100, 100, 100, 100); // x
                    g.DrawLine(pYGreen, 100, 100, 100, 0); // y
                    g.DrawLine(pZBlue, 100, 100, 0, 100); // z
                    break;
                default:
                    break;
            }
        } 
*/
/* MOVE, second variant
//public override void move2(int distance, axe ax)
        //{
        //    for (int i = 0; i < angleNum; i++)
        //    {
        //        point3D tmp = points[i];
        //        switch (ax)
        //        {
        //            case axe.ox:
        //                points[i].x = tmp.x + distance;
        //                break;
        //            case axe.oy:
        //                points[i].y = tmp.y + distance;
        //                break;
        //            case axe.oz:
        //                points[i].z = tmp.z + distance;
        //                break;
        //        }
        //    }
        //}
*/