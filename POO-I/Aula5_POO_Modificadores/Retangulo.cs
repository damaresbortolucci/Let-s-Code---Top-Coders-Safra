using System;
using System.Collections.Generic;


namespace Aula5_POO_Modificadores
{
    public class Retangulo
    {
        private float largura;
        private float comprimento;

        public Retangulo(float largura, float comprimento)
        {  
            Largura = largura;
            Comprimento = comprimento;
        }

        public float Largura 
        { 
            get { return largura; } 
            set 
            {
                if (value <= 0.0)
                    throw new ArgumentOutOfRangeException("O valor da altura não pode ser menor ou igual a 0");

                largura = value; 
            } 
        }

        public float Comprimento 
        {
            get { return comprimento; } 
            set 
            {
                if (value <= 0.0)
                    throw new ArgumentOutOfRangeException("O valor do comprimento não pode ser menor ou igual a 0");

                comprimento = value; 
            } 
        }

        public float Area()
        {
            return Largura * Comprimento;
        }
    }
}
