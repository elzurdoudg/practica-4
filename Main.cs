using System;
using System.IO;
namespace Practica4
{
	class Principal
	{

		public Principal(){

		}

		public void IniciarPrograma()
		{ 
			StreamReader LeyendoArchivo1;
			StreamReader LeyendoArchivo2;
			StreamReader LeyendoArchivoFinal;
			StreamWriter CreandoArchivo1;
			StreamWriter CreandoArchivo2;
            StreamWriter CreandoArchivoFinal;


			string nombreFichero1;
			string nombreFichero2;
			string nombreFicheroFinal;
			string lineasFichero1;
			string lineasFichero2;
			string linea;
			
			Console.WriteLine("Introduzca el nombre del fichero 1"); 
			nombreFichero1 = Console.ReadLine();
		    CreandoArchivo1=File.CreateText(nombreFichero1);
			CreandoArchivo1.Write ("Hola mundo\nlinea2");
			
			Console.WriteLine("Introduzca el nombre del fichero 2"); 
			nombreFichero2 = Console.ReadLine();
			CreandoArchivo2=File.CreateText(nombreFichero2);
			CreandoArchivo2.Write ("Programacion 3\nCUTonala");
			
			CreandoArchivo1.Close ();
			CreandoArchivo2.Close ();

			
				LeyendoArchivo1 = File.OpenText(nombreFichero1); 
				LeyendoArchivo2 = File.OpenText(nombreFichero2); 

				Console.WriteLine("Introduzca el nombre del fichero Final"); 
				nombreFicheroFinal=Console.ReadLine();
				CreandoArchivoFinal=File.CreateText(nombreFicheroFinal);
				do 
				{ 
					lineasFichero1 = LeyendoArchivo1.ReadLine(); 
					lineasFichero2 =LeyendoArchivo2.ReadLine();
					if (lineasFichero1 != null) {
						CreandoArchivoFinal.WriteLine(lineasFichero1); 
					}
					if(lineasFichero2 != null){
						CreandoArchivoFinal.WriteLine(lineasFichero2); 
					}
				} 
				while (lineasFichero1 != null && lineasFichero2 != null );
					 


				LeyendoArchivo1.Close();
				LeyendoArchivo2.Close();
				CreandoArchivoFinal.Close ();

		
			LeyendoArchivoFinal= File.OpenText(nombreFicheroFinal);
			try 
			{ 
				do //imprime las cuatro lineas de string linea en la consola
				{ 
					linea =  LeyendoArchivoFinal.ReadLine(); 
					if (linea != null) 
						Console.WriteLine( linea ); 
				} 

				while (linea != null);
				LeyendoArchivoFinal.Close();
			}
			catch ( Exception e)
			{ 
				Console.WriteLine("error intenta con :.txt  {0} ",e.Message);
			}

		}

		




		public static void Main() 
		{

			Principal miPrograma = new Principal();
			miPrograma.IniciarPrograma();

		}
	}
}