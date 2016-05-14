using ColdSort.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColdSort.Services
{
    public static class SchemaLoader
    {
        public static SortationSchema LoadSortationSchema(string path)
        {
            SortationSchema sortationSchema = new SortationSchema();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string jsonInput = reader.ReadToEnd();
                    //TODO import data
                }
            }
            catch
            {
                //TODO: Add exception info!
                return null;
            }

            return sortationSchema;
        }
    }
}
