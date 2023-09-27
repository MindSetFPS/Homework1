    public class Boxes {
        
        const int RECORRIDO = 28;
        public void CalcularTiempo() {
            Console.WriteLine("Escribe el tiempo de cambio de neumaticos en segudos");
            double tiempo_de_cambio = double.Parse(Console.ReadLine());
            tiempo_de_cambio = tiempo_de_cambio + (RECORRIDO * 2);
            Console.WriteLine("El tiempo perdido es de " + tiempo_de_cambio + " segundos");
        }
    }
