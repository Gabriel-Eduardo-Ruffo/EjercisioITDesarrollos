using System;

namespace Desafio
{
    class ValidationsText
    {
        private int countsCharValidates = 0;
        private bool error;
        private int lineOk;
        private int lineError;

        private char charValidate = ';';
        private char charValidateEndLine = '\n';

        public bool Validations(String _text)
        {
            countsCharValidates = 0;
            error = false;
            lineOk = 1;
            lineError = 0;

            //validamos si el archivo contine algo que puede ser valido en el peor caso posible
            if(_text.Length < 18)
            {
                return false;
            }
            //validacion simple para saber si hay 2 ; por cada renglon, y en que renglon esta el error....
            for (int x = 0; x < _text.Length; x++)
            {
                if (_text[x] == charValidate)
                {
                    countsCharValidates++;
                }
                if (_text[x] == charValidateEndLine)
                {
                    if(countsCharValidates == 2)
                    {
                        countsCharValidates = 0;
                        lineOk++;
                    }
                    else
                    {
                        countsCharValidates = 0;
                        lineError = lineOk;
                        error = true;
                    }
                }

                //esta validacion revisa el ultimo renglon... si tiene o no un enter no importa. revisa que tenga 2 ; y que no exista error encontrado anteriormente
                if(x ==_text.Length-1 && !error && countsCharValidates == 2)
                {
                    return true;
                }
            }

            if (!error)//si no hay errores
            {
                return true;
            }
            return false;
        }
    }
}
