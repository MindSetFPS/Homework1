    class Persona {
        string nombre;
        string apellido;
        public void IngresarDatos() {
            Console.WriteLine("Escribe tu primer nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Escribe tu primer apellido");
            apellido = Console.ReadLine();

        }      

        public void DameLosNombres(){
            Console.WriteLine(nombre + " " + apellido);
            Console.WriteLine(apellido + " " + nombre);
        } 
    }
