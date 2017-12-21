using FlatFile.Core;
using FlatFile.FixedLength;
using FlatFile.FixedLength.Implementation;
using ContaFebrabanV2.Layouts;
using ContaFebrabanV2.Records;
using System;
using System.Collections.Generic;
using System.IO;

namespace ContaFebrabanV2
{
    internal class LayoutParser
    {
        private readonly IFlatFileMultiEngine reader;
        public LayoutParser()
        {
            var factory = new FixedLengthFileEngineFactory();
            var layouts = new ILayoutDescriptor<IFixedFieldSettingsContainer>[] {
              new T0HeaderLayout(),
              new T1ResumoLayout(),
              new T2EnderecoLayout(),
              new T3BilheteLayout(),
              new T4ServicoLayout(),
              new T5DescontoLayout(),
              new T9TrailerLayout(),
            };
            this.reader = factory.GetEngine(layouts, ChooseLayout);
        }

        private Type ChooseLayout(string line, int lineNumber)
        {
            var typeCode = line.Substring(0, 1);
            switch (typeCode)
            {
                case "0": return typeof(T0Header);
                case "1": return typeof(T1Resumo);
                case "2": return typeof(T2Endereco);
                case "3": return typeof(T3Bilhete);
                case "4": return typeof(T4Servico);
                case "5": return typeof(T5Desconto);
                case "9": return typeof(T9Trailer);
                default: return null;
            }
        }

        public IEnumerable<BaseRecord> Parse(Stream stream)
        {
            reader.Read(stream);
            var records = new List<BaseRecord>();
            records.AddRange(reader.GetRecords<T0Header>());
            records.AddRange(reader.GetRecords<T1Resumo>());
            records.AddRange(reader.GetRecords<T2Endereco>());
            records.AddRange(reader.GetRecords<T3Bilhete>());
            records.AddRange(reader.GetRecords<T4Servico>());
            records.AddRange(reader.GetRecords<T5Desconto>());
            records.AddRange(reader.GetRecords<T9Trailer>());
            return records;
        }
    }
}
