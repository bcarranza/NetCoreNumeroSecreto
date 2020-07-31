using System;

namespace DonetCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                    var r = new Random();
                    int numeroSecreto=r.Next(0,20);
                    int x=0;
                    int i=0;
                    int j=20;

                    EscribirLista(i,j);
                    do{
                        Console.WriteLine("");
                        Console.WriteLine("Advine le número secreto? ");
                        x=Convert.ToInt32(Console.ReadLine());
                        if(x==numeroSecreto)
                            Adivino();
                        else{
                            if(numeroSecreto>x){
                                NoAdivinoMayor(x);
                                i=x;
                                EscribirLista(i,j);
                            }
                            else{
                                NoAdivinoMenor(x);
                                j=x;
                                EscribirLista(i,j);
                            }
                        }
                    } while(x!=numeroSecreto);
                }
                catch(Exception ex){
                    Console.Write(ex.Message);
                }
                Console.ReadKey();
        }
        private static void Adivino(){
            Console.WriteLine("Buen trabajo, adivinó el número");
        }
        private static void NoAdivinoMayor(int a){
            Console.WriteLine($"El número secreto es mayor que {a}");
        }
        private static void NoAdivinoMenor(int a){
            Console.WriteLine($"El número secreto es menor que {a}");
        }
        private static void EscribirLista(int i, int j){
            for(int x=i; x<=j; x++){
                Console.Write($"{x} ");
            }
        }
    }
}

//dotnet new console
//dotnet run
//dotnet build
