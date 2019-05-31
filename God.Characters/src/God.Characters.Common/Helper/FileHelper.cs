using Newtonsoft.Json;
using System.IO;
using System.Reflection;
using System.Text;

namespace God.Characters.Common.Helper
{
    public static class FileHelper
    {
        public static Stream GetFile<fileSource>(string fileName)
        {
            var typeInfo = typeof(fileSource).GetTypeInfo();
            var assembly = typeInfo.Assembly;
            var baseName = typeInfo.Namespace;

            var file = assembly.GetManifestResourceStream($"{baseName}.{fileName}");

            return file;
        }

        public static DestinyType GetFromJson<DestinyType, SourceFile>(string fileName)
        {
            var jsonFileName = $"{fileName}.json";
            using (var file = new StreamReader(GetFile<SourceFile>(jsonFileName), Encoding.UTF8))
            {
                string json = file.ReadToEnd();
                return JsonConvert.DeserializeObject<DestinyType>(json);
            }
        }
    }
}
