using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; //Adicionado 
using System.IO; //Adicionado 

namespace Skateshop.sql
{
    class Util
    {
        public byte[] PreparaFoto(Image img)
        {
            //Image img = Image.FromFile(openFileDialog1.FileName); 
            MemoryStream mem = new MemoryStream();
            //byte[] arrayImagem = {0}; 
            byte[] arrayImagem = null;

            if (img != null)
            {
                img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg);
                mem.Flush();
                arrayImagem = new byte[mem.Length];
                mem.Seek(0, SeekOrigin.Begin);
                mem.Read(arrayImagem, 0, arrayImagem.Length);
                mem.Close();
            }
            return arrayImagem;
        }

        public byte[] ConverterImagemParaBytes(string caminhoImagem)
        {
            byte[] arraybytes = null;
            FileInfo informacoesFicnheiro = new FileInfo(caminhoImagem);
            long numeroBytes = informacoesFicnheiro.Length;

            FileStream fStream = new FileStream(caminhoImagem, FileMode.Open, FileAccess.Read);

            BinaryReader br = new BinaryReader(fStream);
            arraybytes = br.ReadBytes((int)numeroBytes);
            return arraybytes;
        }

        public Image RecuperaImagem(byte[] vetorImagem)
        {
            string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
            FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);

            fs.Write(vetorImagem, 0, vetorImagem.Length);
            fs.Flush();
            fs.Close();

            return Image.FromFile(strNomeArquivo);
        }
    }
}
