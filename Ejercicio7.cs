    class CalculadoraDeAlimento {
        double days;
        public void PreguntarTiempo() {
            Console.WriteLine("Cuantos dias te vas?");
            days = double.Parse(Console.ReadLine());
        }

        public void CuantaComidaDejo() {
            Console.WriteLine("Deberias dejar " + days * 750 + " gramos.");
        }
    }
