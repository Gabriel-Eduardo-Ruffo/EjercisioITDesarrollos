using System;

namespace Desafio
{
    class Path
    {
        //El caracter que filtramos es el "\" Dependiendo los sistemas operativos se puede hacer un array de caracteres a filtrar para saber el path
        private char filter = (char)92;
        private int tempIndex;

        //Seteamos el path donde se guardaran los archivos creados, es el mismo donde esta el archivo de origen
        public string SettingPath(string tempPath)
        {
            try
            {
                //intentamos crear la ruta donde sera guardo los 3 archivos solicitados
                tempIndex = tempPath.LastIndexOf(filter);
                tempIndex++;//ajustamos correctamente el index final para usarlo con el metodo remove.
                return tempPath.Remove(tempIndex);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
