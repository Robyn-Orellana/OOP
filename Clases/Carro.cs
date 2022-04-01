using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6.Clases
{
    internal class Carro
    {
        public string Marca { get; }   //obtener y cambiar informacion
        //public int Modelo { get; }
        //public string Color { get; set; }
        //public int VMaxima { get; }

        public string owner { get; set; }

        private int Encendido = 0;
        private int velocidad_actual = 0;


        public Carro(string _marca, string _owner)
        {
            Marca = _marca;
            owner = _owner;
            //Modelo = _modelo;
            //Color = _color;
            //VMaxima = _vmaxima;
            Encendido = 0;
            this.velocidad_actual = 0;
        }
        //public Carro(string _marca, int _modelo, int _vmaxima, string _owner)
        //{
        //    Marca= _marca;  
        //    Modelo= _modelo;
        //    VMaxima= _vmaxima;  
        //    owner = _owner;
        //    this.velocidad_actual= 0;
        //}
        public int GetVelocidadActual()
        {
            return velocidad_actual;
        }

        public string EncendidoMotor()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                this.velocidad_actual = 0;
                return "Listo para correr";
                
            }
            else
            {
                return "Ya esta encendido tu carro!!!";
            }
        }

        //public string acelerar()
        //{
        //    string mensaje = "";
        //    if (Encendido == 0)
        //    {
        //        mensaje = $"no puedo acelerar con el carro apagado";
        //        return mensaje;
        //    }

        //    velocidad_actual += 10;
        //    if (velocidad_actual <= VMaxima)
        //    {
        //        mensaje = $"Vas a {velocidad_actual}KM/H";
        //    }
        //    else
        //    {
        //        velocidad_actual = VMaxima;
        //        mensaje = $"{velocidad_actual}KM/H Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
        //    }

        //    return mensaje;

        //}

        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"No puedo acelerar con el carro apagado";
                return mensaje;

            }
            else
            {
                velocidad_actual += CuantosKPH;
                mensaje = $"{velocidad_actual} KM/H";
                return mensaje;
            }
        }

        public string desacelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                return "No puedes desacelerar si el carro esta apagado!!";
               
            }
            else
            {
                velocidad_actual -= 30;
                if (velocidad_actual>=0)
                {

                    
                    mensaje = $"Vas desacelerando, tu velocidad actual es {velocidad_actual}";
                
                    
                }

                else
                {
                    velocidad_actual = 0;   
                    mensaje = $"Ya no podemos desacelerar mas!!! vamos a {velocidad_actual} ";

                }

            } 
            
                return mensaje;
            
        }

        public string frenar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = "El carro esta apagado, no podemos frenar";
            }
            else
            {
                velocidad_actual -= 25;
                if (velocidad_actual >= 0)
                {
                    mensaje = $"Andale, vamos frenando, tu velocidad es {velocidad_actual}KM/H";

                }
                else
                {
                    velocidad_actual= 0;    
                    mensaje = $"Ya no puedes frenar, vamos a {velocidad_actual}KM/H";
                }
            }
            
            return mensaje; 
        }

        public string apagarmotor()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje= "Ups! el carro ya estaba apagado";

            }
            else
            {
                velocidad_actual = 0;
                Encendido = 0;
                mensaje= "Apagado motor...";
                                
            }
          
            return mensaje; 
        }

        public string Bocinar()
        {
            string mensaje = "Pipiiiiii!!! tu carro esta bocinando!";
            return mensaje;
        }
    }
}

    
