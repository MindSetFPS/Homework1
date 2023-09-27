 class Circle {
    float radio_size;
    public void CualEsMiRadio() {
       Console.WriteLine("Escribe el radio del circulo");
       radio_size = Input.EnsureItsNumber();
    }

    public void CalculaTuPerimetro() {
       Console.WriteLine("\nMi perimetro es " + 2 * Math.PI * radio_size);
    }

    public void CalculaTuArea() {
       Console.WriteLine("Mi area es " + Math.PI * Math.Pow(radio_size, 2));
    }
 }
