namespace TP01_Bis_Diccionarios_y_Listas;
class Program
{
    static void Main(string[] args)
    {
        
       
        SortedDictionary<string,int> PlataCurso=new SortedDictionary<string, int>();
        string clave,curMax="nadie";
        int cantAlumnos=0, num, cantcursos=0, regaloTotal=0,suma=0,max=0;
        double promedio=0;
        do{
        Menu();
        num= IngresarNumeroPositivo("Opcion elegida (numero):");
        switch (num)
        {
            
            case 1:
            clave=IngresarCadena("Curso:");
            cantAlumnos=IngresarNumeroPositivo("¿Cuantos alumnos tiene el curso?:");

            for(int i=0;i<cantAlumnos;i++)
            {
                int plata=IngresarNumeroPositivo("Cuanto abona:");
                suma=suma+plata;
                Console.Clear();
            }
            
            cantcursos++;
            if(suma>max)
            {
                max=suma;
                curMax=clave;
            }
            PlataCurso.Add(clave,suma);
            regaloTotal=regaloTotal+suma;
            break;

            case 2:
            Console.WriteLine("a) Cuál es el curso que más plata puso:"+curMax+",que pusieron $"+max);
            promedio=regaloTotal/cantcursos;
            Console.WriteLine("b) Cuál es el promedio de plata regalado por todos los cursos:"+promedio);
            Console.WriteLine("c) Recaudación total entre los todos cursos:"+regaloTotal);
            Console.WriteLine("d) Cantidad de cursos que participan del regalo:"+cantcursos);
            break;

            case 3:
            Console.WriteLine("Chau!");
            break;
            Console.Clear();
        }
        }while (num!=3);
        
    }
    static void Menu()
    {
    Console.WriteLine("1.Ingrese los importes de un curso \n2.Ver estadísticas \n3.Salir");
    }
    static int IngresarNumeroPositivo(string mensaje)
    {
        int num;
        Console.WriteLine(mensaje);
        num=int.Parse(Console.ReadLine());
        return num;
    }
    static string IngresarCadena(string mensaje)
    {
        string ingreso;
        Console.WriteLine(mensaje);
        ingreso=Console.ReadLine();
        return ingreso;
    }
    }

