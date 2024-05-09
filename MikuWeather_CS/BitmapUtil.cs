using System.Drawing;
using System.Drawing.Drawing2D;

namespace MikuWeather {
    public abstract class BitmapUtil {
        public static GraphicsPath GetNoneTransparentRegion(Bitmap img, byte alpha) {
            var height = img.Height;
            var width = img.Width;

            var grpPath = new GraphicsPath();
            for (var y = 0; y < height; y++) {
                for (var x = 0; x < width; x++) {
                    while (x < width && img.GetPixel(x, y).A <= alpha) {
                        x++;
                    }

                    var xStart = x;
                    while (x < width && img.GetPixel(x, y).A > alpha) {
                        x++;
                    }

                    var xEnd = x;
                    if (img.GetPixel(x - 1, y).A > alpha) {
                        grpPath.AddRectangle(new Rectangle(xStart, y, xEnd - xStart, 1));
                    }
                }
            }

            return grpPath;
        }
    }
}