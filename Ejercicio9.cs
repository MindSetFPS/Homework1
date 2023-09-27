    public class Pago {
        double salario_diario;
        double salario_mensual;
        public void DameElSalarioDiario() {
            Console.WriteLine("Cual es el salario diario?");
            salario_diario = double.Parse(Console.ReadLine());

            salario_mensual = salario_diario * 30;
        }

        public void DimeElSalarioMensual() {
            Console.WriteLine("El salario mensual es antes de impuestos es $" + salario_mensual);

            double salario_neto_mensual = salario_mensual - (salario_mensual * 0.25); 
            Console.WriteLine("El salario mensual despues de impuestos es $" + salario_neto_mensual);

            double salario_neto_mensual_prestamo = salario_neto_mensual - (200 * 2);
            Console.WriteLine("Salario neto mensual menos prestamos $" + salario_neto_mensual_prestamo);
        }
    }
