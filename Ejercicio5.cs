    class Cajero {
        double checkout, payment;
        public void CalculaElTotal() {
            Console.WriteLine("Escribe el total de la compra");
            checkout = double.Parse(Console.ReadLine());
        }

        public void PideDineroAlCliente() {
            Console.WriteLine("Cuanto te pago el cliente?");
            payment = double.Parse(Console.ReadLine());
        }

        public void CalculaElCambio() {
            if(payment > checkout) {
                Console.WriteLine("El cambio es: ");
                Console.WriteLine(payment - checkout);
            }

            if (checkout > payment) {
                Console.WriteLine("El cliente ha pagado menos de el total, por favor pidale que complete el pago.");
            }

            if (checkout == payment) {
                Console.WriteLine("El cliente ha pagado la cantidad exacta. No es necesario devolverle cambio.");
            }
        }
    }
