using System.Drawing;

namespace CleanCode.Names
{
    public class Names
    {
        public Bitmap GerarImagens(string path)  //Se eu renomear apagando e escrevendo vou ter problemas + CTRL + R + R
        {
            var bitmap = new Bitmap(path);
            var graphics = Graphics.FromImage(bitmap);
            graphics.DrawString("a", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 0));
            graphics.DrawString("b", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 20));
            graphics.DrawString("c", SystemFonts.DefaultFont, SystemBrushes.Desktop, new PointF(0, 30));
            return bitmap;
        }
    }


    public class GraficosClientes
    {
        public void ImprimirGraficos()
        {
            Names names = new Names();
            var eixo = names.GerarImagens("eixox");
        }

    }
}
