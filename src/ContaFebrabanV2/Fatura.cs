using ContaFebrabanV2.Records;
using System.Collections.Generic;
using System.IO;

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

        public static Fatura Parse(Stream stream)
        {
            Fatura fatura = new Fatura();
            Recurso recurso = null;

            var recursoDictByTelefone = new Dictionary<string, Recurso>();

            var parse = new LayoutParser();
            var records = parse.Parse(stream);
            foreach (var record in records)
            {
                switch (record)
                {
                    case T0Header header:
                        fatura.Header = header;
                        break;
                    case T1Resumo resumo:
                        recurso = new Recurso();
                        recurso.Resumo = resumo;
                        fatura.Recursos.Add(recurso);
                        recursoDictByTelefone[recurso.Resumo.DDD + recurso.Resumo.Telefone] = recurso;
                        break;
                    case T2Endereco endereco:
                        recurso.Enderecos.Add(endereco);
                        break;
                    case T3Bilhete bilhete:
                        recurso.Bilhetes.Add(bilhete);
                        break;
                    case T4Servico servico:
                        if (string.IsNullOrWhiteSpace(servico.Telefone))
                        {
                            fatura.Servicos.Add(servico);
                        }
                        else
                        {
                            var rec = recursoDictByTelefone[servico.DDD + servico.Telefone];
                            rec.Servicos.Add(servico);
                        }
                        break;
                    case T5Desconto desconto:
                        recurso.Descontos.Add(desconto);
                        break;
                    case T9Trailer trailer:
                        fatura.Trailer = trailer;
                        break;
                }
            }
            return fatura;
        }
    }
}
