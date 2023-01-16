using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Admissao__Digital.Core.Interface.Services;

namespace Admissao__Digital.Core.Services
{
    public class ValidadorFotosService : IValidadorFotosService
    {
        public string ConverterImagemBase64()
        {
            byte[] imageBytes = File.ReadAllBytes("E:\\Imagem\\imagem.jpg");
            return Convert.ToBase64String(imageBytes);
        }
    }
}
