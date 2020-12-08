using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorSintatico
{
    class Lexico
    {
        static public List<Token> Analizar(string fuente)
        {
            List<Token> tokens = new List<Token>();

            string lexema, token;
            int i, estado, valor;

            i = 0;
            estado = 0;

            while (i <= (fuente.Length - 1) && estado == 0)
            {
                lexema = "";
                token = "";
                valor = -1;
                while (i <= (fuente.Length - 1) && estado != -1)
                {
                    if (estado == 0)
                    {
                        if (Char.IsWhiteSpace(fuente, i)) //ignorar espacios
                            estado = 0;
                        else if (Char.IsLetter(fuente, i) || fuente[i] == '_') //empieza id 
                        {
                            estado = 1;
                            lexema += fuente[i];
                            token = "id";
                            valor = 1;
                        }
                        else if (Char.IsDigit(fuente, i)) //empieza constante
                        {
                            estado = 2;
                            lexema += fuente[i];
                            token = "constante";
                            valor = 13;
                        }
                        else if (fuente[i] == ';') //Solo es un caracter por lo que no necesita estado propio
                        {
                            lexema += fuente[i];
                            token = ";";
                            valor = 2;
                            estado = -1;
                        }
                        else if (fuente[i] == ',') //Solo es un caracter por lo que no necesita estado propio
                        {
                            lexema += fuente[i];
                            token = ",";
                            valor = 3;
                            estado = -1;
                        }
                        else if (fuente[i] == '(') //Solo es un caracter por lo que no necesita estado propio
                        {
                            lexema += fuente[i];
                            token = "(";
                            valor = 4;
                            estado = -1;
                        }
                        else if (fuente[i] == ')') //Solo es un caracter por lo que no necesita estado propio
                        {
                            lexema += fuente[i];
                            token = ")";
                            valor = 5;
                            estado = -1;
                        }
                        else if (fuente[i] == '{') //Solo es un caracter por lo que no necesita estado propio
                        {
                            lexema += fuente[i];
                            token = "{";
                            valor = 6;
                            estado = -1;
                        }
                        else if (fuente[i] == '}') //Solo es un caracter por lo que no necesita estado propio
                        {
                            lexema += fuente[i];
                            token = "}";
                            valor = 7;
                            estado = -1;
                        }
                        else if (fuente[i] == '=') //Puede ser relacional o solo =
                        {
                            estado = 5;
                            lexema += fuente[i];
                            token = "=";
                            valor = 8;
                        }
                        else if (fuente[i] == '<' || fuente[i] == '>') //Relacional
                        {
                            estado = 5;
                            lexema += fuente[i];
                            token = "opRelacional";
                            valor = 17;
                        }
                        else if (fuente[i] == '!') //Es error a menos que siga un '='
                        {
                            estado = 5;
                            lexema += fuente[i];
                            token = "error";
                            valor = -1;
                        }
                        else if (fuente[i] == '+' || fuente[i] == '-') //Solo un caracter no necesita estado
                        {
                            lexema += fuente[i];
                            token = "opSuma";
                            valor = 14;
                            estado = -1;
                        }
                        else if (fuente[i] == '*' || fuente[i] == '/') //No necesita estado
                        {
                            lexema += fuente[i];
                            token = "opMultiplicacion";
                            valor = 16;
                            estado = -1;
                        }
                        else if (fuente[i] == '|' || fuente[i] == '&') //Estado opLogico
                        {
                            lexema += fuente[i];
                            token = "error";
                            valor = -1;
                            estado = 6;
                        }
                        else
                        {
                            lexema += fuente[i];
                            token = "error";
                            valor = -1;
                            estado = -1;
                        }
                        i++;
                    }
                    else if (estado == 1)  //Estado del id
                    {
                        if (Char.IsLetter(fuente, i) || fuente[i] == '_' || Char.IsDigit(fuente, i))
                        {
                            estado = 1;
                            lexema += fuente[i];
                            i++;
                        }
                        else //se determina si es palabra reservada
                        {
                            estado = -1;
                            if (lexema == "int" || lexema == "float" || lexema == "char" || lexema == "void")
                            {
                                token = "tipoDeDato";
                                valor = 0;
                            }
                            else if (lexema == "if")
                            {
                                token = lexema;
                                valor = 9;
                            }
                            else if (lexema == "while")
                            {
                                token = lexema;
                                valor = 10;
                            }
                            else if (lexema == "return")
                            {
                                token = lexema;
                                valor = 11;
                            }
                            else if (lexema == "else")
                            {
                                token = lexema;
                                valor = 12;
                            }
                            else
                            {
                                token = "id";
                                valor = 1;
                            }
                        }
                    }
                    else if (estado == 2) //estado de entero (constante)
                    {
                        if (Char.IsDigit(fuente, i))
                        {
                            estado = 2;
                            lexema += fuente[i];
                            i++;
                        }
                        else if (fuente[i] == '.') // puede ser real (constante)
                        {
                            estado = 3;
                            lexema += fuente[i];
                            i++;
                            token = "error";
                            valor = -1;
                        }
                        else
                            estado = -1;
                    }
                    else if (estado == 3) // Estado de transicion entero a real
                    {
                        if (Char.IsDigit(fuente, i))
                        {
                            estado = 4;
                            lexema += fuente[i];
                            token = "constante";
                            valor = 13;
                            i++;
                        }
                        else
                            estado = -1;

                    }
                    else if (estado == 4) // Estado de real (constante)
                    {
                        if (Char.IsDigit(fuente, i))
                        {
                            estado = 4;
                            lexema += fuente[i];
                            i++;
                        }
                        else
                            estado = -1;
                    }
                    else if (estado == 5) //Estado relacional
                    {
                        if (fuente[i] == '=') //Si llegan a este estado (=,<,>,!) pueden recibir un '=' mas
                        {
                            lexema += fuente[i];
                            token = "opRelacional"; // '=' se vuelve opRelacional
                            valor = 17;
                            i++;
                        }
                        estado = -1;    //Si no es un '=' se mantienen igual y sale
                    }
                    else if (estado == 6) //Estado opLogico
                    {
                        if (lexema[0] == fuente[i])
                        {
                            lexema += fuente[i];
                            token = "opLogico";
                            valor = 15;
                            i++;
                        }
                        estado = -1;
                    }
                    else //NO DEBERIA DE ENTRAR NUNCA
                        estado = -1;
                } // fin while por lexema
                estado = 0;
                if(lexema != "")
                    tokens.Add(new Token() { tipo = token, identificador = valor, lexema = lexema });
            } //fin while que recorre la cadena

            tokens.Add(new Token() { tipo = "$", identificador = 18, lexema = "$" });

            return tokens;
        }
    }
}