// using System;


// public class TestCandidatos {
//         static void Main(string[] args){
//            const string PASSWORD = "finalizar";
            
//            Console.WriteLine("Ingrese el nombre del primer candidato:");
//            string nombre1 = Console.ReadLine();
//            Candidato candidato1 = new Candidato(nombre1);
//            Console.WriteLine("Ingrese el nombre del segundo candidato:");
//            string nombre2 = Console.ReadLine();
//            Candidato candidato2 = new Candidato(nombre2);
//            Console.WriteLine("Ingrese el nombre del tercer candidato:");
//            string nombre3 = Console.ReadLine();
//            Candidato candidato3 = new Candidato(nombre3);
//            int intentos = 0;
//            int opc=0;
//            int v1 = 0;
//            int v2=0;
//            int v3=0;
//            string password = string.Empty;
//            bool votacionFinalizada = false;
//            do{
//                 Console.WriteLine("1.- Votar por candidato "+ nombre1);
//                 Console.WriteLine("2.- Votar por candidato "+ nombre2);
//                 Console.WriteLine("3.- Votar por candidato "+ nombre3);
//                 Console.WriteLine("4.- Cerrar casilla");
//                 if (int.TryParse(Console.ReadLine(), out opc)){
//                         switch (opc){
//                                 case 1:
//                                         v1++;
//                                         break;
//                                 case 2:
//                                         v2++;
//                                         break;
//                                 case 3:
//                                         v3++;   
//                                         break;
//                                 case 4:
//                                         do{
//                                                 intentos =0;
//                                                 Console.WriteLine("Para terminar la votación");
//                                                 Console.WriteLine("debe ingresar la contraseña:");
//                                                 password = Console.ReadLine();
//                                                 if(password.Equals(PASSWORD)){
//                                                         Console.WriteLine("Votación finalizada");
//                                                         if(v1 == 0 && v2==0 && v3==0 ){
//                                                                 Console.WriteLine("Urna vacia");
//                                                         }else if (v1 == v2){
//                                                                 Console.WriteLine("Se cayó el sistema");
//                                                         }else if(v2 == v3){
//                                                                 Console.WriteLine("Se cayó el sistema");
//                                                         }else if(v1 > v2){
//                                                                 Console.WriteLine("El ganador es el candidato: " + nombre1+ " con un total de: "+ v1+ " votos");
//                                                         }else if(v2 > v1){
//                                                                 Console.WriteLine("El ganador es el candidato: " + nombre2+" con un total de: "+ v1+ " votos");
//                                                         }else{
//                                                                 Console.WriteLine("El ganador es el candidato: " + nombre3+ " con un total de: "+ v1+ " votos");
//                                                         }
//                                                         votacionFinalizada = true;
//                                                 }else{
//                                                         Console.WriteLine("Contraseña incorrecta");
//                                                         intentos++;
//                                                         Console.WriteLine("Le quedan "+ (3-intentos)+ " intentos");
//                                                 }
//                                         }while(intentos <= 3);
//                                         break;
                                        
//                                 default:
//                                         break;
//                         }
//                 }else{
//                    Console.WriteLine("El dato ingresado NO ES UN UNA OPCIÓN CORRECTA");     
//                 }
//            }while(!votacionFinalizada);
         
//         }
// }
