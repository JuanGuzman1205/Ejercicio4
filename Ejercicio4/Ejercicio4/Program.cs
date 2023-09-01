/*4.	Realizar un algoritmo con C# donde me permita calcular el perímetro/circunferencia y área de las siguientes
 * figuras geométricas: cuadrado, rectángulo, triángulo y círculo. 
 * Mostrar en pantalla los valores calculados por cada figura geométrica.*/


using System;

public class Ejercicio4
{
     static void Main(string[] args)
        {
        Decimal Cuadradolado, RecAltura, RecAncho, AreaCuadrado, PerimetroCuadrado, AreaRectangulo, PerimetroRectangulo,
            PerimetroTriangulo, AreaCirculo, PerimetroCirculo, TrianguloBase, TrianguloLado1, TrianguloLado2, TrianguloAltura, AreaTriangulo, CircRadio;

       
        const decimal pi = 3140/1000;

        Console.Write("Ingrese la medida del lado L del cuadrado:");
        Cuadradolado = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese la altura h de su rectangulo:");
        RecAltura = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese la medida de la base de su rectangulo:");
        RecAncho = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese la medida de la base de su triangulo:");
        TrianguloBase = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese la medida de la altura h de su triangulo:");
        TrianguloAltura = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese la medida del lado 1 de su triangulo:");
        TrianguloLado1 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese la medida del lado 2 de su triangulo:");
        TrianguloLado2 = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Ingrese la medida del radio de su circulo:");
        CircRadio = Convert.ToDecimal(Console.ReadLine());


        AreaCuadrado = (Cuadradolado * Cuadradolado);
        PerimetroCuadrado = (Cuadradolado * 4);
        PerimetroRectangulo= ((RecAltura * 2) + (RecAncho * 2));
        AreaRectangulo = (RecAltura * RecAncho);
        AreaTriangulo = ((TrianguloBase * TrianguloAltura) / 2);
        PerimetroTriangulo = (TrianguloBase + TrianguloLado1 + TrianguloLado2);
        AreaCirculo = ((CircRadio * CircRadio) * pi);
        PerimetroCirculo = (((pi) * 2) * CircRadio);
        


        Console.Write("El area del cuadrado es de:" + AreaCuadrado);
        Console.Write('\n');
        Console.Write("El perimetro del cuadrado es de:" + PerimetroCuadrado);
        Console.Write('\n');
        Console.Write("El area de su rectangulo es de:" + AreaRectangulo);
        Console.Write("\n");
        Console.Write("El perimetro de su rectangulo es de:" + PerimetroRectangulo);
        Console.Write("\n");
        Console.Write("El area de su triangulo es de:" + AreaTriangulo);
        Console.Write("\n");
        Console.Write("El perimetro de su triangulo es de:" + PerimetroTriangulo);
        Console.Write("\n");
        Console.Write("El area de su circulo es de:" + AreaCirculo);
        Console.Write("\n");
        Console.Write("El perimetro de su circulo es de:" + PerimetroCirculo);
        
        


        

 
    }
    










}
