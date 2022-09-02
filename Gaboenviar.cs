	int irdiferencia1;
    do{
    Console.WriteLine ("Ingresa tu nombre 1");
	String nombre1 = Console.ReadLine ();
	Console.WriteLine ("Ingresa tu apellido");
	String apellido = Console.ReadLine ();
	Console.WriteLine ("ingresa tu nombre 2"); 
	String nombre2 = Console.ReadLine ();
    Console.WriteLine ("Escribeme el primer numero");
    int numero = Convert.ToInt32(Console.ReadLine ());
    Console.WriteLine ("termina hasta que la diferencia sea de 1000000");
	Console.WriteLine ("Ingrese salario 1");
	int salario1 = Convert.ToInt32(Console.ReadLine ());
	Console.WriteLine ("Ingrese salario 2");
	int salario2 = Convert.ToInt32 (Console.ReadLine ()) ;
	 irdiferencia1=(salario1-salario2)^2;
	if (salario1>  salario2) {
		Console.WriteLine ("Tiene mas salario") ;
    }
		
	else{
		if (salario1<salario1) {
			Console.WriteLine ("su diferencia es") ;
        }else{
			Console.WriteLine ("la diferencia de salario es")  ;
		}
		
	}
}while( irdiferencia1>10000000);
            
	

	
		
	