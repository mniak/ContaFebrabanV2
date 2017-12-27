using ContaFebrabanV2.Records;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ContaFebrabanV2
{
    public class Fatura
    {
        public T0Header Header { get; set; }
        public List<Recurso> Recursos { get; set; } = new List<Recurso>();
        public T9Trailer Trailer { get; set; }
        public List<T4Servico> Servicos { get; set; } = new List<T4Servico>();

        public class Recurso
        {
            public T1Resumo Resumo { get; set; }
            public List<T2Endereco> Enderecos { get; set; } = new List<T2Endereco>();
            public List<T3Bilhete> Bilhetes { get; set; } = new List<T3Bilhete>();
            public List<T4Servico> Servicos { get; set; } = new List<T4Servico>();
            public List<T5Desconto> Descontos { get; set; } = new List<T5Desconto>();
        }

        public static Fatura Parse(Stream stream, Encoding encoding = null)
        {
            Fatura fatura = new Fatura();

            var recursoDictByTelefone = new Dictionary<(string, string), Recurso>();

            var parser = new LayoutParser();
            if (encoding != null)
                parser.Encoding = encoding;
            var records = parser.Parse(stream);
            foreach (var record in records)
            {
                switch (record)
                {
                    case T0Header header:
                        fatura.Header = header;
                        break;
                    case T1Resumo resumo:
                        var recurso = new Recurso();
                        recurso.Resumo = resumo;
                        fatura.Recursos.Add(recurso);
                        recursoDictByTelefone[(recurso.Resumo.DDD, recurso.Resumo.Telefone)] = recurso;
                        break;
                    case T9Trailer trailer:
                        fatura.Trailer = trailer;
                        break;
                }
            }
            foreach (var record in records)
            {
                Recurso recurso;
                switch (record)
                {
                    case T2Endereco endereco:
                        recurso = recursoDictByTelefone[(endereco.DDD, endereco.Telefone)];
                        recurso.Enderecos.Add(endereco);
                        break;
                    case T3Bilhete bilhete:
                        recurso = recursoDictByTelefone[(bilhete.DDD, bilhete.Telefone)];
                        recurso.Bilhetes.Add(bilhete);
                        break;
                    case T4Servico servico:
                        if (string.IsNullOrWhiteSpace(servico.Telefone))
                        {
                            fatura.Servicos.Add(servico);
                        }
                        else
                        {
                            recurso = recursoDictByTelefone[(servico.DDD, servico.Telefone)];
                            recurso.Servicos.Add(servico);
                        }
                        break;
                    case T5Desconto desconto:
                        recurso = recursoDictByTelefone[(desconto.DDD, desconto.Telefone)];
                        recurso.Descontos.Add(desconto);
                        break;
                }
            }
            return fatura;
        }
    }
}
