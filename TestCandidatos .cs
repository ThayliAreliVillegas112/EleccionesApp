using System;

public class TestCandidatos {
    static void Main(string[] args){
        const string PASSWORD = "finalizar";
        Console.WriteLine("////////////////////////////////////////////");
        Console.WriteLine("         ELECCIONES MUNICIPALES");
        Console.WriteLine("////////////////////////////////////////////");
        Console.WriteLine("Ingrese el nombre del primer candidato:");
        string nombre1 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre1)) {
                Console.WriteLine("El nombre del primer candidato no puede estar vacío");
                return; // Salir del programa o realizar alguna acción apropiada
        }
        Candidato candidato1 = new Candidato(nombre1);
        Console.WriteLine("-------------------------------------------");
        // Console.WriteLine(candidato1.Nombre);
        Console.WriteLine("Ingrese el nombre del segundo candidato:");
        string nombre2 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre2)) {
                Console.WriteLine("El nombre del primer candidato no puede estar vacío");
                return; // Salir del programa o realizar alguna acción apropiada
        }
        Candidato candidato2 = new Candidato(nombre2 );
        Console.WriteLine("-------------------------------------------");
        Console.WriteLine("Ingrese el nombre del tercer candidato:");
        string nombre3 = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nombre3)) {
                Console.WriteLine("El nombre del primer candidato no puede estar vacío");
                return; // Salir del programa o realizar alguna acción apropiada
        }
        Candidato candidato3 = new Candidato(nombre3);
        
        int v1 = 0;
        int v2 = 0;
        int v3 = 0;
        string password = string.Empty;

        bool votacionFinalizada = false;

        do {
            Console.WriteLine("********************CANDIDATOS***********************");
            Console.WriteLine("1.- Votar por candidato " + candidato1.Nombre);
            Console.WriteLine("2.- Votar por candidato " + candidato2.Nombre);
            Console.WriteLine("3.- Votar por candidato " + candidato3.Nombre);
            Console.WriteLine("4.- Cerrar casilla");
            int opc;
            if (int.TryParse(Console.ReadLine(), out opc)){
                Console.WriteLine("******************************************************");
                switch (opc){
                    case 1:
                        v1++;
                        break;
                    case 2:
                        v2++;
                        break;
                    case 3:
                        v3++;   
                        break;
                    case 4:
                    int intentos =0;
                    int totalVotos = v1+v2+v3;
                    int porcentaje =0;
                        do{
                           Console.WriteLine("Para terminar la votación, debe ingresar la contraseña:");
                           password = Console.ReadLine();
                           Console.WriteLine("******************************************************");
                           if (password.Equals(PASSWORD)){
                                
                                if (v1 == 0 && v2 == 0 && v3 == 0) {
                                    Console.WriteLine("Urna vacía");
                                    Console.WriteLine("-------------------------------------");
                                } else if (v1 == v2) {
                                    Console.WriteLine("Se cayó el sistema");
                                     Console.WriteLine("-------------------------------------");
                                } else if (v2 == v3) {
                                   Console.WriteLine("Se cayó el sistema");
                                    Console.WriteLine("-------------------------------------");
                                } else if (v1 > v2) {
                                    porcentaje = (v1 * 100)/totalVotos;
                                     Console.WriteLine("---------------------------------------------------------------------------------------------");
                                    Console.WriteLine("El ganador es el candidato: " + candidato1.Nombre + " con un total de: " + v1 + " votos que equivale a " + porcentaje + "%");
                                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                                } else if (v2 > v1) {
                                    porcentaje = (v2 * 100)/totalVotos;
                                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                                    Console.WriteLine("El ganador es el candidato: " + candidato2.Nombre + " con un total de: " + v2 + " votos que equivale a " + porcentaje + "%");
                                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                                } else {
                                    porcentaje = (v3 * 100)/totalVotos;
                                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                                    Console.WriteLine("El ganador es el candidato: " + candidato3.Nombre + " con un total de: " + v3 + " votos que equivale a " + porcentaje + "%");
                                    Console.WriteLine("---------------------------------------------------------------------------------------------");
                                }
                                Console.WriteLine("VOTACIÓN FINALIZDA");
                                 votacionFinalizada = true;
                                 intentos = 4;
                             } else {
                            
                                intentos++;
                                Console.WriteLine("Contraseña incorrecta. Le quedan " + (3 - intentos) + " intentos.");
                             }
                        }while(intentos < 3);
                        
                        break;
                }
            } else {
                Console.WriteLine("El dato ingresado NO ES UNA OPCIÓN CORRECTA");
            }
        } while (!votacionFinalizada);

        // Resto del código después de finalizar la votación (si hay alguna)
    }
}
