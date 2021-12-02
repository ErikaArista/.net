// See https://aka.ms/new-console-template for more information
string palabra = " ";
string mostrar = " ";
string ver = " ";
char  letra;
int n;
int intentos = 5;
bool acierto = false;

Console.WriteLine("Bienvenido al juego del ahorcado");
Console.WriteLine("Escribe el largo de tu palabra");
n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese una palabra");
palabra = Console.ReadLine();

for (int i = 0; i < n; i++){
    if (palabra[i] == ' '){
        mostrar = mostrar + " ";
    }
    else{
        mostrar = mostrar + "-";

    }
}

Console.WriteLine("Palabra oculta: " + mostrar);
Console.WriteLine("Te quedan:" + intentos + " intentos");

Console.WriteLine("Ingrese una letra");
letra = Convert.ToChar(Console.ReadLine());

if (palabra.IndexOf(letra) == -1){
    intentos--;
}

for ( int z = 0; z < n; z ++){
    if ( letra == palabra[z]){
        ver = ver + letra;
    }
    else{
        ver = ver + mostrar[z];

    }
}
palabra = ver;

if (palabra.IndexOf("-") < 0){
    Console.WriteLine("Felicidades adivinaste la palabra" + palabra);
}
else{
    Console.WriteLine("Palabra oculta: " + palabra);
    Console.WriteLine("Te quedan:" + intentos + " intentos");
    Console.WriteLine("Ingrese una letra");
    letra = Convert.ToChar(Console.ReadLine());
    if (palabra.IndexOf(letra) == -1){
        intentos--;
    }
    for ( int z = 0; z < n; z ++){
        if ( letra == palabra[z]){
            ver = ver + letra;
        }
        else{
            ver = ver + mostrar[z];

        }
    }
    palabra = ver;
    if (palabra.IndexOf("-") == -1){
        Console.WriteLine("Felicidades, ganaste");
        acierto = true;
    }
    else{
        if(intentos == 0 ){
            Console.WriteLine("Perdiste, la palabra era: " + palabra);
            acierto = true;

        }
    }
    Console.WriteLine();
    

}
