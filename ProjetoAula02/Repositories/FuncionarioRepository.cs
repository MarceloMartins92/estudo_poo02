using Newtonsoft.Json;
using ProjetoAula02.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ProjetoAula02.Repositories
{

    /// <summary>
    /// Classe para gravação dos dados de funcionario em arquivos
    /// </summary>
    public class FuncionarioRepository
    {
        public void ExportarJson(Funcionario funcionario)
        {
            var json = JsonConvert.SerializeObject(funcionario, Formatting.Indented);

            using (var streamWriter = new StreamWriter($"\\temp\\funcionario_{funcionario.Id}.json"))
            {
                streamWriter.WriteLine(json);
            }
        }

        public void ExportarXml(Funcionario funcionario)
        {
            var xml = new XmlSerializer (typeof(Funcionario));

            using (var streamWriter = new StreamWriter($"c:\\temp\\funcionario_{funcionario.Id}.xml"))
            {
                xml.Serialize(streamWriter, funcionario);
            }                    
        }   
    }
}
