using System;
using System.IO;

namespace Desafio
{
    class CreateFile
    {
        //Crear archivo y ser guardado en la direccion que le pasamos (solo el archivo Historia es true para ir agregando la info logueada)
        public bool Create(string _filePathSave, string _data, DateTime startProcces, bool _writeAdd = false, int _ok = 0, int _err = 0, int _total = 0, int _rep = 0)
        {
            try
            {
                StreamWriter sw = new StreamWriter(_filePathSave, _writeAdd);
                sw.WriteLine(_data);
                
                //si viene seteado en true agrega informacion en el archivo existente. (solo para el caso de Historial)
                if (_writeAdd)
                {
                    DateTime endProcess = DateTime.Now;
                    TimeSpan result = endProcess - startProcces;

                    sw.WriteLine("Procesados totales:   " + _total.ToString());
                    sw.WriteLine("Procesados OK:        " + _ok.ToString());
                    sw.WriteLine("Procesados error:     " + _err.ToString());
                    sw.WriteLine("Procesados repetidos: " + _rep.ToString());
                    sw.WriteLine("Inicio: " + startProcces.ToString("yyyy / MM / dd / HH:mm: ss:ffffff"));
                    sw.WriteLine("Final:  " + endProcess.ToString("yyyy / MM / dd / HH:mm: ss:ffffff"));
                    sw.WriteLine("Total:  " + result.ToString());
                    sw.WriteLine("------------------------------");
                }
                sw.Close();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR GENERAL Al CREAR LOS ARCHIVOS: " + e.Message);
                return false;
            }
        }
    }
}
