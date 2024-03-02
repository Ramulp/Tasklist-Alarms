using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasklist_Alarms.Classes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Tasklist_Alarms.JSONParse
{
    public class JSON_Parser
    {
        public static void SaveToJSON(AlarmTask task)
        {
            string dataDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tasklist Alarms");

            // Crear el directorio si no existe
            if (!Directory.Exists(dataDirectory))
            {
                Directory.CreateDirectory(dataDirectory);
            }

            // Ruta completa al archivo JSON en el directorio de datos
            string JSONFileLocation = Path.Combine(dataDirectory, "AlarmInfo.json");



            // Guardar los datos en el archivo JSON
            if (!File.Exists(JSONFileLocation))
                CreateJson(JSONFileLocation, task);
            else
                AddToJson(JSONFileLocation, task);
            
        }

        private static void CreateJson(string _JSONFileLocation, AlarmTask task)
        {
            List<AlarmTask> alarms = new List<AlarmTask>();
            alarms.Add(task);
            var alarmToJsonify = new { alarms = alarms }; 
            string JSONData = JsonConvert.SerializeObject(alarmToJsonify);
            File.WriteAllText(_JSONFileLocation, JSONData);
        }

        private static void AddToJson(string _JSONFileLocation, AlarmTask task)
        {
            if (!File.Exists(_JSONFileLocation))
            {
                string errMsg = String.Format("No existe el archivo en la ruta {0}", _JSONFileLocation);
                throw new Exception(errMsg);
            }
            string FileData = File.ReadAllText(_JSONFileLocation);


            JObject jObjectParsed = JObject.Parse(FileData);


            JArray jObjectArray = (JArray)jObjectParsed["alarms"];

            List<AlarmTask> alarmList = jObjectArray.ToObject<List<AlarmTask>>();


            alarmList.Add(task);
            var alarmToJsonify = new { alarms = alarmList };
            string JSONData = JsonConvert.SerializeObject(alarmToJsonify);
            File.WriteAllText(_JSONFileLocation, JSONData);

        }

        public static void PrintToJSON(List<AlarmTask> tasks)
        {

        }


        public static List<AlarmTask> ReadBackup()
        {
            string dataDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Tasklist Alarms");

            // Crear el directorio si no existe
            if (!Directory.Exists(dataDirectory))
            {
                string errMsg = String.Format("No existe el directorio {0}", dataDirectory);
                throw new Exception(errMsg);
            }

            // Ruta completa al archivo JSON en el directorio de datos
            string JSONFileLocation = Path.Combine(dataDirectory, "AlarmInfo.json");

            if (!File.Exists(JSONFileLocation))
            {
                string errMsg = String.Format("No existe el archivo en la ruta {0}", dataDirectory);
                throw new Exception(errMsg);
            }

            string FileData = File.ReadAllText(JSONFileLocation);


            JObject jObjectParsed = JObject.Parse(FileData);


            JArray jObjectArray = (JArray)jObjectParsed["alarms"];

            List<AlarmTask> alarmList = jObjectArray.ToObject<List<AlarmTask>>();


            return alarmList.OrderBy(o => o.Id).ToList();
        }

    }
}
