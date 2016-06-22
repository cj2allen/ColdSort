//----------------------------------
// <copyright file="SchemaLoader.cs" company="None">
//     Copyright (c) 2016 Christopher James Allen
// </copyright>
// <author>Christopher James Allen</author>
//-----------------------------------------------------------------------
using System.IO;
using ColdSort.Models;

namespace ColdSort.Services
{
    /// <summary>
    /// Loads and save sortation schemas
    /// </summary>
    /// <remarks> Not implemented yet </remarks>
    public static class SchemaLoader
    {
        /// <summary>
        /// Load schema information
        /// </summary>
        /// <param name="path"> The path to the schema file </param>
        /// <returns> A sortation schema </returns>
        public static SortationSchema LoadSortationSchema(string path)
        {
            SortationSchema sortationSchema = new SortationSchema();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    // TODO import data
                    string jsonInput = reader.ReadToEnd();
                }
            }
            catch
            {
                // TODO: Add exception info!
                return null;
            }

            return sortationSchema;
        }
    }
}
