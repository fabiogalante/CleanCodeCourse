﻿using System.Drawing;

namespace CleanCode.Names
{
    public class Names
    {
        public Bitmap Method1(string n)  //Se eu renomear apagando e escrevendo vou ter problemas
        {
            var b = new Bitmap(n);
            var g = Graphics.FromImage(b);
            g.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            g.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 20));
            g.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 30));
            return b;
        }
    }


    public class GraficosClientes
    {
        public void ImprimirGraficos()
        {
            Names names = new Names();
            var eixo = names.Method1("eixox");
        }

    }
}
