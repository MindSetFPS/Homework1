class Rectangle {
  int a_side = 0;
  int b_side = 0;
  public void DameMisMedidas() {
      Console.WriteLine("Cual es la medida del lado 1?");
      a_side = int.Parse(Console.ReadLine());
      Console.WriteLine("\nCual es la medida del lado 2?");
      b_side = int.Parse(Console.ReadLine());
  }
  public void CalcularPerimetro() {
      int medidas = a_side * 2 + b_side * 2;
      Console.WriteLine("Mi perimetro es " + medidas);
  }
  public void CalculaTuArea() {
      Console.WriteLine("Mi area es " + a_side * b_side);
  }
}
