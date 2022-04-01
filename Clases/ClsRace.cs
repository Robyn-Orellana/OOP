using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6.Clases
{
    internal class ClsRace
    {
        private Carro CarroA;
        private Carro CarroB;
        private Carro CarroC;
        private int mcarroA = 0;
        private int mcarroB = 0;
        private int mcarroC = 0;

        public void PedirDatosCarrera()
        {
            
            CarroA = GetData();
            Console.WriteLine("Ahora datos del B");
            CarroB = GetData();
            Console.WriteLine("Ahora datos del C");
            CarroC = GetData();

        }

        public void IniciarCarrera()
        {
            string msgCarroA, msgCarroB, msgCarroC;
            string msgCarroAA, msgCarroBA, msgCarroCA;
            Random velRandom = new Random();
          

           msgCarroA = CarroA.EncendidoMotor();
            msgCarroB = CarroB.EncendidoMotor();
            msgCarroC = CarroC.EncendidoMotor();
            Console.WriteLine($"{CarroA.Marca} {msgCarroA}");
            Console.WriteLine($"{CarroB.Marca} {msgCarroB}");
            Console.WriteLine($"{CarroC.Marca} {msgCarroC}");

            for (int i = 1; i < 11; i++)
            {
                int acelera;
                
                
                acelera = velRandom.Next(1, 21);
                msgCarroA = CarroA.acelerar(acelera);
                acelera = velRandom.Next(1, 21);
                msgCarroB = CarroB.acelerar(acelera);
                acelera = velRandom.Next(1, 21);
                msgCarroC = CarroC.acelerar(acelera);

                Console.WriteLine($"{i}- {CarroA.owner}: {msgCarroA}; {CarroB.owner}: {msgCarroB}; {CarroC.owner}: {msgCarroC}");

            }
           
            if ((CarroA.GetVelocidadActual() > CarroB.GetVelocidadActual()) && (CarroA.GetVelocidadActual() > CarroC.GetVelocidadActual()) )
            {
                mcarroA += 1;
                Console.WriteLine($"{CarroA.owner} Wins!!!");
               
            }
            else if ( CarroB.GetVelocidadActual() > CarroC.GetVelocidadActual())
            {
                mcarroB += 1;  
                Console.WriteLine($"{CarroB.owner} Wins!!!");
            }
            else if ( (CarroA.GetVelocidadActual() == CarroB.GetVelocidadActual()) && (CarroA.GetVelocidadActual() == CarroC.GetVelocidadActual()))
            {
                Console.WriteLine("Es un empate!");
                
            } 
            else
            {
                mcarroC += 1;
                Console.WriteLine($"{CarroC.owner} Wins!!!");
            }

            Console.WriteLine($"{CarroA.owner} {mcarroA}; {CarroB.owner} {mcarroB}; {CarroC.owner} {mcarroC}; ");
            msgCarroAA = CarroA.apagarmotor();
            msgCarroBA = CarroB.apagarmotor();
            msgCarroCA = CarroC.apagarmotor();
            Console.WriteLine($"{CarroA.owner} {msgCarroAA}");
            Console.WriteLine($"{CarroB.owner} {msgCarroBA}");
            Console.WriteLine($"{CarroC.owner} {msgCarroCA}");

        }

        private Carro GetData()
        {
            string marca;
            //int modelo;
            //int velocidad;
            string propietario;
            Carro carroTemporal;

            Console.WriteLine("Ingrese Marca");
            marca = Console.ReadLine();

            //Console.WriteLine("Ingrese Modelo");
            //modelo = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese velocidad Maxima");
            //velocidad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Propietario");
            propietario = Console.ReadLine();

            carroTemporal = new Carro(marca, propietario);
            return carroTemporal;
        }

    }
}
