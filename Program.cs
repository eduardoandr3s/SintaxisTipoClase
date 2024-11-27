class HolaMundo
{

    struct Punto
    {
        int X;
        int Y;

        public Punto(int x, int y)
        {
            X = x;
            Y = y;

        }


        public override string ToString()
        {
            return $"({X},{Y})";
        }
        public int WriteX()
        {
            return X;
        }

    }

    enum DiaSemana
    {

        Lunes,  //1
        Martes, //2 
        Miercoles,//3
        Jueves, //4
        Viernes, //5
        Sabado, //6
        Domingo  //7
    }

    enum ErrorCode : short
    {
        None = 0,
        Unknow = 1,
        ConnectionLost = 100
    }
    static void Main(String[] args)
    {

        Punto p = new Punto(10, 20);
        // Console.WriteLine(p.WriteX());

        DiaSemana ds = DiaSemana.Lunes;
        //  Console.WriteLine(ds);

        ErrorCode errorCode = ErrorCode.ConnectionLost;

        Console.WriteLine(errorCode);
        Console.WriteLine((int)errorCode);


        (string nombre, int edad) persona = ("Eduardo", 32);

        Console.WriteLine(persona);
        Console.WriteLine(persona.nombre);

        (string nombre, int edad) ObtenerPersona()
        {
            return ("Andrés", 1);
        }
        Console.WriteLine(ObtenerPersona());

        var t = (1, 2, 3, 4, 5, 6, 7, 8, 9, "nombre");

        Console.WriteLine(t.Item10);

        var s = "hola hola hola";

        var i = 30;




        // Comentario en una sola línea
        // Console.WriteLine("Hola mundo");// línea de comentario luego de código

        /*comentario de más de una 
         línea
        */
        //Numericos
        byte miByte = 1;  // 0 a 255
        sbyte miSbyte = -1;  //-128 a 127
        short miShort = 31000; // 32000 aprox
        ushort miUShort = 60000; // 62000 aprox
        int miInt = 1231546;
        long miLong = 156151561561156;
        float miFloat = 0.1234f; //6 a 9 decimales con una f al final
        double miDouble = 0.156156156161651; // muchos decimales
        decimal miDecimal = 0.123456715616516161561651m;  //muchas precisión con una m al final

        //lógicos

        bool miBoolean = false;

        //caracter

        char miChar = 'r';  //comillas simple

        // texto, cadenas

        string miString = "Hola soy un string"; //entre comillas dobles

        object miObject = 20;
        object miObject1 = "cadena";

        //DAtos estructurados

        //ARRAY 

        int[] miArray = new int[5];
        miArray[0] = 2;
        miArray[1] = 4;
        miArray[2] = 6;
        miArray[3] = 8;
        miArray[4] = 10;

        //Console.WriteLine(miArray[2]);

        int[,] matriz = new int[3, 2];
        matriz[0, 0] = 1;
        matriz[0, 1] = 2;
        matriz[1, 0] = 3;
        matriz[1, 1] = 3;
        matriz[2, 0] = 4;

        //Console.WriteLine(matriz[0,1]);


        //STRUC

        //ENUM

        //TUPLAS


    }
}