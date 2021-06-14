using System;
using System.IO;

namespace Desafio
{
    class ReadAllFile
    {
        //lee todo el archivo y lo guarda en un string.
        private string allFileReading;

        private ValidationsText validations = new ValidationsText();
        public string Read(string filePathRead)
        {
            try
            {
                TextReader tr = new StreamReader(filePathRead);
                allFileReading = tr.ReadToEnd();

                if (validations.Validations(allFileReading))
                {
                    return allFileReading;
                }
                else
                {
                    return null;
                }               
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("ERROR NO SE ENCUENTRA EL ARCHIVO: " + e.Message);
            }
            catch (FileLoadException e)
            {
                Console.WriteLine("ERROR DE LECTURA DE ARCHIVO: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR GENERAL: " + e.Message);
            }
            return null;
        }
    }
}
