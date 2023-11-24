using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GamesList.Interface
{
    class FileWriter
    {
        private Dictionary<string, string> configurations = new Dictionary<string, string>();

        public FileWriter(string filePath)
        {
            LoadConfigurations(filePath);
        }

        public string GetConfiguration(string clave)
        {
            // Try to obtain the value of the configuration per key
            configurations.TryGetValue(clave, out string val);
            return val;
        }

        private void LoadConfigurations(string filePath)
        {
            try
            {
                // Reads all lines of the file
                string[] lines = File.ReadAllLines(filePath);

                // Processes each line
                foreach (string line in lines)
                {
                    // Ignores comment lines and empty lines
                    if (!string.IsNullOrWhiteSpace(line) && !line.Trim().StartsWith("#"))
                    {
                        // Splits the line into key and value
                        string[] parts = line.Split('=');

                        // Make sure there are at least two parts (key and value).
                        if (parts.Length >= 2)
                        {
                            // Assigns the configuration to the dictionary
                            configurations[parts[0].Trim()] = parts[1].Trim();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading configs: {ex.Message}");
            }
        }
    }
}
