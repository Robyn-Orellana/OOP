using Clase_6.Clases;

Carro miCarrito = new Carro("Toyota", 2022, "Azul", 180);
Carro EstefaniCarrito = new Carro("Ferrari", 2022, "Rojo", 280);
Carro Robyncarrito = new Carro("Mitsubishi", 2008, "Blanco", 290);

if (miCarrito.Modelo > EstefaniCarrito.Modelo)
{
    Console.WriteLine("El carro del profe es mas reciente");
}
else
{
    Console.WriteLine("El carro de Estefani es mas reciente");
}

Console.WriteLine($"teacher car is {miCarrito.Marca}");
Console.WriteLine($"Estafani's car is {EstefaniCarrito.Marca}");
Console.WriteLine($"Estafani's model car is {EstefaniCarrito.Modelo}");

EstefaniCarrito.EncendidoMotor();
Console.WriteLine(EstefaniCarrito.GetVelocidadActual());
//EstefaniCarrito.EncendidoMotor();
 

for (int i = 0; i < 5; i++)
{
    EstefaniCarrito.acelerar();
    
}

//EstefaniCarrito.acelerar(0);
//EstefaniCarrito.acelerar(6);
//EstefaniCarrito.acelerar(1);


for (int i = 0; i < 4; i++)
{
    
    EstefaniCarrito.desacelerar();

}

for (int i = 0; i < 5; i++)
{

    EstefaniCarrito.frenar();

}

EstefaniCarrito.apagarmotor();
EstefaniCarrito.apagarmotor();
EstefaniCarrito.EncendidoMotor();
EstefaniCarrito.Bocinar();

Console.WriteLine("\n");
Console.WriteLine("Carro de Robyn");
Console.WriteLine($"Marca: {Robyncarrito.Marca}");
Console.WriteLine($"Modelo: {Robyncarrito.Modelo}"); 
Console.WriteLine($"Color: {Robyncarrito.Color}");
Console.WriteLine($"Velocidad Maxima : {Robyncarrito.VMaxima} KM/H");

Robyncarrito.EncendidoMotor();
Robyncarrito.EncendidoMotor();
Console.WriteLine(Robyncarrito.GetVelocidadActual());

for (int i = 0; i < 15; i++)
{
    Robyncarrito.acelerar();
}
for (int i = 0; i < 5; i++)
{
    Robyncarrito.desacelerar();
}
for (int i = 0; i < 7; i++)
{
    Robyncarrito.frenar();
}
Robyncarrito.apagarmotor();
Robyncarrito.apagarmotor();
Robyncarrito.Bocinar();
Robyncarrito.acelerar();
Robyncarrito.frenar();
Robyncarrito.desacelerar();



