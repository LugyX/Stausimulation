using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework.Storage;

namespace Stausimulation
{
    class reader
    {
        private static void DoOpen(StorageDevice device)
        {
            IAsyncResult result =
                device.BeginOpenContainer("StorageDemo", null, null);

            // Wait for the WaitHandle to become signaled.
            result.AsyncWaitHandle.WaitOne();

            StorageContainer container = device.EndOpenContainer(result);

            // Close the wait handle.
            result.AsyncWaitHandle.Close();

            // Add the container path to our file name.
            string filename = "demobinary.sav";

            Stream file = container.OpenFile(filename, FileMode.Open);
            file.Close();

            // Dispose the container.
            container.Dispose();
        }

        public static void ReadFile()
        {          
                var fileInfo = new FileInfo("map.txt");

                // Prüfen ob die Datei existiert
                if (fileInfo.Exists)
                {
                    // Datei in einen FileStream laden
                    var fileStream = fileInfo.Open(FileMode.Open, FileAccess.Read);

                    // StreamReader initialisieren
                    var reader = new StreamReader(fileStream);

                    String line;

                    // Lese Datei, Zeile für Zeile
                    while ((line = reader.ReadLine()) != null)
                    {
                        variables.map += line;
                        
                    }

                    reader.Close();
                    fileStream.Close();
                }
                else
                {
                    Console.WriteLine("Die Datei {0} wurde nicht gefunden.", "a");
                }
            
           
        }
    }
}
