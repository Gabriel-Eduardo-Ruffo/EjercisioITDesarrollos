using System;
using System.Collections.Generic;

namespace Desafio
{
    class SortGroup
    {
        List<String> masculino;
        List<String> femenino;
        List<String> errorsSex;

        int repM;
        int repF;
        int repErr;

        int totalReg;

        int totalErr;

        public void InitGroups(string[] _text)
        {
            masculino = new List<String>();
            femenino = new List<String>();
            errorsSex = new List<String>();

            repM = 0;
            repF = 0;
            repErr = 0;

            totalReg = 0;
            totalErr = 0;

            //agrupamos por sexo los datos separados (todo lo que sea distinto a "M" o "F" se tomara como error por que no entra dentro de la categoria solicitada
            for (int x = 0; x < _text.Length; x++)
            {
                totalReg++;
                if (_text[x].IndexOf('M') > 0)
                {
                    _text[x] = _text[x].TrimEnd();
                    masculino.Add(_text[x]);
                    masculino.Sort();
                }
                else if (_text[x].IndexOf('F') > 0)
                {
                    _text[x] = _text[x].TrimEnd();
                    femenino.Add(_text[x]);
                    femenino.Sort();
                }
                else
                {
                    _text[x] = _text[x].TrimEnd();
                    errorsSex.Add(_text[x]);
                    errorsSex.Sort();
                    totalErr++;
                }
            }

            //sacamos los datos que no nos piden en el enunciado
            masculino = CleanData(masculino);
            femenino = CleanData(femenino);
            errorsSex = CleanData(errorsSex);

            //verificamos que no se repitan los datos
            masculino = FindRepeat(masculino, "M");
            femenino = FindRepeat(femenino, "F");
            errorsSex = FindRepeat(errorsSex);

        }

        public List<string> CleanData(List<string> _persons)
        {
            for (int x = 0; x < _persons.Count; x++)
            {
                int tempIndexDelete = _persons[x].IndexOf(";");
                if (tempIndexDelete > 0)
                {
                    _persons[x] = _persons[x].Remove(tempIndexDelete);
                }

                _persons[x] = _persons[x].Replace("-", "");
            }
            return _persons;
        }

        public List<string> FindRepeat(List<string> _persons, string type = null)
        {
            for (int x = 0; x < _persons.Count; x++)
            {
                for (int y = x + 1; y < _persons.Count; y++)
                {
                    if (_persons[x].ToString() == _persons[y].ToString())
                    {
                        _persons.Remove(_persons[y]);//borramos el registro duplicado

                        if(type == "M")
                        {
                            repM++;
                        }else if(type == "F")
                        {
                            repF++;
                        }
                        else
                        {
                            repErr++;
                        }
                    }
                }
            }
            return _persons;
        }

        public int TotalRep()
        {
            return repM + repF + repErr;
        }
        public int TotalErr()
        {
            return totalErr;
        }

        public int TotalReg()
        {
            return totalReg;
        }

        public int TotalRegOk()
        {
            return totalReg - TotalRep() - TotalErr();
        }

        public List<string> Masculino()
        {
            return masculino;
        }
        public List<string> Femenino()
        {
            return femenino;
        }
        public List<string> ErrorsSex()
        {
            return errorsSex;
        }
    }
}
