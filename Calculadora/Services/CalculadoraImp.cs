using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {

        private List<string> listHistorico;
        private string data;

        public CalculadoraImp(string data){
            listHistorico = new List<string>();
            data = data;
        }

        public int Somar (int num1, int num2){
            int res = num1 + num2;
            listHistorico.Insert(0,$"Res : {res} - {data}");
            return res;
        }
        
        public int Subtrair (int num1, int num2){
            int res = num1 - num2;
            listHistorico.Insert(0,$"Res : {res} - {data}");
            return res;
        }

        public int Dividir (int num1, int num2){
            int res = num1 / num2;
            listHistorico.Insert(0,$"Res : {res} - {data}");
            return res;
        }

        public int Multiplicar (int num1, int num2){
            int res = num1 * num2;
            listHistorico.Insert(0,$"Res : {res} - {data}");
            return res;
        }

        public List<String> Historico(){

            listHistorico.RemoveRange(3, listHistorico.Count - 3);
            return listHistorico;
        }

    }
}