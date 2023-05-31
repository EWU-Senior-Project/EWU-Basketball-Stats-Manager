using CsvHelper;
using  CsvHelper.Configuration;
using CsvHelper.TypeConversion;

namespace server.Data.Mappings.MappingUtils;

public class CustomInt32Converter: Int32Converter {
        //move to utils
    public override object ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
    {
        if (text == "NA") return 0;
        return base.ConvertFromString(text, row, memberMapData)!;
    }
}