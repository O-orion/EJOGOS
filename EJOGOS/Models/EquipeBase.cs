using System.IO;

namespace EJOGOS.Models
{
    public class EquipeBase
    {
        public void CriaPastaArquivo(string _path)
        {
            //Pegando o nome da pasta e do arquivo, do caminho que recebemos como parâmetros;
            string pasta = _path.Split('/')[0];
            string arquivo = _path.Split("/")[1];

            //Se a pasta não existir criamos ela
            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            };

            //Se o arquivo não existir, então criamos ele
            if (!File.Exists(arquivo))
            {
                File.Create(arquivo).Close();
            }
        }
    }
}
