using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nucleo.Negocio
{
    public class ImagemTratada
    {

        public ImagemTratada(byte[] imagemByte)
        {
            ImagemByte = ImagemByte;
        }

        public Image Imagem => Imagem != null ? Imagem : ConvertaEmImagem(ImagemByte);
        public byte[] ImagemByte { get; set; }

        public Image ConvertaEmImagem(byte[] imagemByte)
        {
                using (var ms = new MemoryStream(imagemByte))
                {
                    return Image.FromStream(ms);
                }
        }
    }
}
