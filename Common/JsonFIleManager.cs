using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Dongmin.Common
{
    public static class JsonFileManager
    {
        public static async Task<T> ReadJsonFile<T>(string fullFilePath)
            where T : new()
        {
            using (var reader = File.OpenText(fullFilePath))
            {
                string json = await reader.ReadToEndAsync();
                return JsonConvert.DeserializeObject<T>(json);
            }
        }
        
        public static async Task WriteJsonFile<T>(string fullFilePath, T jsonObject)
        {
            using (var file = File.CreateText(fullFilePath))
            {
                using (var writer = new JsonTextWriter(file))
                {
                    string json = JsonConvert.SerializeObject(jsonObject);
                    await writer.WriteRawAsync(json);
                }
            }
        }
    }
}