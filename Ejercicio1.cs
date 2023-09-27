class Program {
    static void Main() {
        Console.WriteLine("working");
        Square square;
        square = new Square();

        square.DameUnLado();
        square.CalcularPerimetro();
    }
}

// Ejercicio #01. Problemática: 
// Se requiere hacer un algoritmo que sea capaz de calcular el perímetro de un cuadrado.
public class Square {
    
    float side_size;
    float perimeter;
    public void DameUnLado() {
        Console.WriteLine("Cuanto mide un lado del cuadrado?");
        side_size = int.Parse(Console.ReadLine());
    }

    public void CalcularPerimetro() {
        perimeter = side_size * 4;
        Console.WriteLine("El cuadrado tiene " + perimeter + " de perimetro");
    }
}
