using Clase_6.Clases;

int mangas = 3;

ClsRace carrera= new ClsRace();
carrera.PedirDatosCarrera();

for (int i = 0; i < mangas; i++)
{
    Console.WriteLine($"Manga {i + 1}");
    carrera.IniciarCarrera();
    Console.WriteLine("---------------------------------------------");    
}












