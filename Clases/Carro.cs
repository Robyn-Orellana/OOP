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
        public int Modelo { get; }
        public string Color { get; set; }
        public int VMaxima { get; }

        private int Encendido = 0;
        private int velocidad_actual = 0;
        private const int MAXVELOCIDAD = 150;

        public Carro(string _marca, int _modelo, string _color, int _vmaxima)
        {
            Marca = _marca;
            Modelo = _modelo;
            Color = _color;
            VMaxima= _vmaxima; 
            Encendido = 0;
            this.velocidad_actual = 0;
        }
        public string GetVelocidadActual()
        {
            return $"vamos a {velocidad_actual} KM/H";
        }

        public string EncendidoMotor()
        {
            if (Encendido == 0)
            {
                Encendido = 1;
                this.velocidad_actual = 0;
                return "Tu carro esta listo para correr";
                
                
            }
            else
            {
                return "Ya esta encendido tu carro!!!";
            }
        }

        public string acelerar()
        {
            string mensaje = "";
            if (Encendido == 0)
            {
                mensaje = $"no puedo acelerar con el carro apagado";
                return mensaje;
            }

            velocidad_actual += 20;
            if (velocidad_actual <= VMaxima)
            {
                mensaje = $"Vas a {velocidad_actual}KM/H";
            }
            else
            {
                velocidad_actual = VMaxima;
                mensaje = $"{velocidad_actual}KM/H Aguas rapido y furioso, vas muy rapido y ya llegaste al tope";
            }

            Console.WriteLine(mensaje);
            return mensaje;

        }

        public string acelerar(int CuantosKPH)
        {
            string mensaje = "";
            if (Encendido==0)
            {
                mensaje = $"No puedo acelerar con el carro apagado";
                return mensaje;

            }

            velocidad_actual += CuantosKPH;
            if (velocidad_actual<=MAXVELOCIDAD)
            {
                mensaje = $"Vas a {velocidad_actual} KM/H";
            }
            else
            {
                velocidad_actual=MAXVELOCIDAD;
                mensaje = $"{velocidad_actual} KM/H Aguas toreto, Vas muy rapido y ya llegaste a; tope";
            }
            Console.WriteLine(mensaje);
            return mensaje;
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
            Console.WriteLine(mensaje);
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
            
            
            Console.WriteLine(mensaje);
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
                Encendido = 0;
                mensaje= "El Carro esta siendo apagado... El carro ya está apagado";
                                
            }
            Console.WriteLine(mensaje);
            return mensaje; 
        }

        public string Bocinar()
        {
            string mensaje = "Pipiiiiii!!! tu carro esta bocinando!";
            Console.WriteLine(mensaje); 
            return mensaje;
        }
    }
}

    
