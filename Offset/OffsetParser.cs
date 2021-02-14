using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSGOHack.Offset
{
    class OffsetParser
    {
        public static readonly String sectionParentTag = "UserdefinedSymbols";
        public static readonly String itemStartingTag = "SymbolEntry";
        public static Dictionary<String, int> ParseOffsets(String filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNode definedOffsets = doc.DocumentElement.SelectSingleNode(sectionParentTag);
            Dictionary<string, int> offsets = new Dictionary<string, int>();

            foreach (XmlNode symbolEntry in definedOffsets.ChildNodes)
            {
                XmlNodeList entries = symbolEntry.ChildNodes;
                String key = entries.Item(0).InnerText;
                int offset = Convert.ToInt32(entries.Item(1).InnerText, 16);
                offsets.Add(key, offset);
            }
            return offsets;
        }
    }
}
