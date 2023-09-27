    class Recibo {
        double metros_cubicos;
        public void DameMetrosCubicos() {
            Console.WriteLine("Cuantos litros cubicos gastaste?");
            metros_cubicos =    double.Parse(Console.ReadLine());
        }

        public void TransformaMetrosCubicosALitros(){
            Console.WriteLine("Has gastado " + metros_cubicos * 1000 + " litros de agua.");
        }
    }
