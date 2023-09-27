    class Aguinaldo {
        double payment;
        public void DimeTuSalarioMensual() {
            Console.WriteLine("Cual es tu salario mensual?");
            payment = double.Parse(Console.ReadLine());
        }

        public void DarAguinaldo(){
            Console.WriteLine("Tu aguinalo sería de $" +  payment / 2 );
        }
    }
