Imports System

Module Program
    Class calcetin
        'Declaración de atributos de calcetin 
        Private hilo, tela As String
        Private costominuto, costohilo As Double
        Private tCost(5) As Integer
        Private dCost(5) As Integer
        Private SAM As Integer
        Private dtotalCostura, cantHilo As Integer
        Private costototal As Integer

        Public Sub New()
            'Método de la clase calcetin que avisa cuando el calcetin se hace
            Console.WriteLine("calcetin creado")
            Console.WriteLine()


        End Sub
        Public Sub IngresarDatos()
            ' Método de la clase calcetin para ingresar atributos de la clase calcetin 
            Console.WriteLine("Datos calcetin")
            Console.WriteLine("¿Cuál es el Costo por minuto?")
            costominuto = Console.ReadLine
            Console.WriteLine("¿Cuál es costo del hilo por metro?")
            costohilo = Console.ReadLine
            For f = 0 To 5
                Console.WriteLine("¿Cuál es el Tiempo de la costura " & f)
                tCost(f) = Console.ReadLine

            Next

        End Sub

        Public Sub MostrarDatos()
            ' Método de la clase calcetin para que se vean los datos de la clase calcetin
            Console.WriteLine("Para hilo usaremos:")
            hilo = Console.ReadLine
            Console.WriteLine("Para tela usaremos:")
            tela = Console.ReadLine
        End Sub
        Public Function Tiempototalc()
            ' Método de la clase calcetím para calcular el timpo total y SAM
            SAM = tCost(0) + tCost(1) + tCost(2) + tCost(3) + tCost(4) + tCost(5)
            Return SAM
        End Function
        Public Function dtCosturac()
            'Método de la clase calcetín para calcular cuanto se tardan las costuras
            For f = 0 To 5
                dtotalCostura = dtotalCostura + dCost(f)
            Next
            Return dtotalCostura
        End Function
        Public Function cantidadHiloc()
            'Método de la clase calcetín para calcular cuanto hilo usaremos
            For f = 0 To 5
                cantHilo = (dCost(f)) * 2 + (dCost(f)) * 2 * 0.05
            Next
            Return cantHilo
        End Function
        Public Function CostoTotalCalcetin()
            'Método de la clase para calcular el costo total de un calcetín
            For f = 0 To 5
                costototal = (dCost(f) * 2) + (dCost(f) * 2 * 0.05) + (tCost(f) * costominuto)
            Next

            Return costototal

        End Function
        Public Class matriz
            'Método de la clase playera donde la matriz imprimer el número de costuras en orden
            Private mat(1, 4) As Integer
            Public Sub Cargar()
            'Método de la clase calcetin para cargar datos a la matriz
            Console.WriteLine("Ingresa en orden el número de costuras para que se vea en la matriz")
            Dim c, f As Integer
            For c = 0 To 4
                For f = 0 To 1
                    Console.Write("Ingrese componente  de la fila " & f & " y la columna " & c & " :")
                    mat(f, c) = Console.ReadLine()
                Next
            Next
        End Sub

        Public Sub Imprimir()
            'Método de la clase calcetin para demostrar los datos que usamos
            Dim f, c As Integer
            For f = 0 To 1
                For c = 0 To 4
                    Console.Write(mat(f, c) & " ")
                Next
                Console.WriteLine()
            Next
            Console.ReadKey()
        End Sub
    End Class
    End Class

    Class playera
        'Declaración de atributos de playera
        Private SAM As Integer
        Private talla As String
        Private tCost(5) As Integer
        Private dCost(5) As Integer
        Private dtotalCostura, cantHilo As Integer
        Private costototal As Integer
        Private costominuto, costohilo As Integer
        Private botones, bordados As Integer
        Private cuello As String

        Public Sub New()
            'Método de la clase playera que avisa cuando la playera se hace
            Console.WriteLine("playera creada")
            Console.WriteLine()
            botones = 2
            bordados = 1
            cuello = "Polo"


        End Sub
        Public Sub IngresarDatos()
            'Método de la clase playera para el ingreso de los datos
            Console.WriteLine("¿Cuál es la talla?")
            talla = Console.ReadLine
            Console.WriteLine("¿Cuál es el Costo por minuto?")
            costominuto = Console.ReadLine
            Console.WriteLine("¿Cuál es costo del hilo por metro?")
            costohilo = Console.ReadLine
            For f = 0 To 5
                Console.WriteLine("¿Cuál es el Tiempo de la costura " & f)
                tCost(f) = Console.ReadLine

            Next
        End Sub

        Public Sub MostrarDatos()
            'Método de la clase playera para que demuestre los datos hechos
            Console.WriteLine("Talla: " & talla)
            Console.WriteLine("Costo por minuto: " & costominuto)
            Console.WriteLine("Costo del hilo: " & costohilo)
            For f = 0 To 5
                Console.WriteLine("Tiempo de la costura  " & tCost(f))
            Next
            For f = 0 To 5
                Console.WriteLine("Distancia de la costura  " & dCost(f))
            Next
        End Sub

        Public Function Tiempototal()
            'Método de la clase playera para calcular el tiempo de elaboración
            SAM = tCost(0) + tCost(1) + tCost(2) + tCost(3) + tCost(4) + tCost(5)
            Return SAM
        End Function
        Public Function dtCostura()
            ' Método de la clase playera para calcular el tiempo que tardarems con la costura
            For f = 0 To 5
                dtotalCostura = dtotalCostura + dCost(f)
            Next
            Return dtotalCostura
        End Function
        Public Function cantidadHilo()
            'Método de la clase playera para calcular cuanto hilo vamos a usar
            For f = 0 To 5
                cantHilo = (dCost(f)) * 2 + (dCost(f)) * 2 * 0.05
            Next
            Return cantHilo
        End Function
        Public Function CostoTotalPlayera()
            'Método de la clase playera para calcular el costo de una playera
            For f = 0 To 5
                costototal = (dCost(f) * 2) + (dCost(f) * 2 * 0.05) + (tCost(f) * costominuto)
            Next

            Return costototal
        End Function

    End Class

    Public Class matriz
        'Método de la clase playera donde la matriz imprimer el número de costuras en orden
        Private mat(1, 4) As Integer

        Public Sub Cargar()
            'Método de la clase playera para cargar datos a la matriz
            Console.WriteLine("Ingresa en orden el número de costuras para que se vea en la matriz")
            Dim c, f As Integer
            For c = 0 To 4
                For f = 0 To 1
                    Console.Write("Ingrese componente  de la fila " & f & " y la columna " & c & " :")
                    mat(f, c) = Console.ReadLine()
                Next
            Next
        End Sub

        Public Sub Imprimir()
            'Método de la clase playera para demostrar los datos que usamos
            Dim f, c As Integer
            For f = 0 To 1
                For c = 0 To 4
                    Console.Write(mat(f, c) & " ")
                Next
                Console.WriteLine()
            Next
            Console.ReadKey()
        End Sub
    End Class


    Sub Main(args As String())
        'Declaracion de los datos que usamos 

        Dim tfabricacion As Integer
        Dim Costofabricacion As Integer
        Dim mhilonecesarios As Integer

        Dim playera1 As New playera()
        Dim playera2 As New playera()
        Dim playera3 As New playera()
        Dim playera4 As New playera()
        playera1.IngresarDatos()
        playera2.IngresarDatos()
        playera3.IngresarDatos()
        playera4.IngresarDatos()

        mhilonecesarios = playera1.cantidadHilo()
        tfabricacion = playera1.Tiempototal()
        Costofabricacion = playera1.CostoTotalPlayera()

        Dim ma As New matriz()
        ma.Cargar()
        ma.Imprimir()

        Console.WriteLine("Para este lote de playeras se obtienen los siguientes datos: ")
        Console.WriteLine("los metros de hilo necesarios son : " & mhilonecesarios)
        Console.WriteLine("El tiempo de fabricación es : " & tfabricacion)
        Console.WriteLine("El costo de fabricación es: " & Costofabricacion)

        Dim calcetin As New calcetin()
        Dim calcetin2 As New calcetin()
        Dim calcetin3 As New calcetin()
        Dim calcetin4 As New calcetin()
        calcetin.IngresarDatos()
        calcetin.MostrarDatos()
        calcetin2.IngresarDatos()
        calcetin2.MostrarDatos()
        calcetin3.IngresarDatos()
        calcetin3.MostrarDatos()
        calcetin4.IngresarDatos()
        calcetin4.MostrarDatos()

        mhilonecesarios = calcetin.cantidadHiloc()
        tfabricacion = calcetin.Tiempototalc()
        Costofabricacion = calcetin.CostoTotalCalcetin()

        Console.WriteLine("Para este lote de calcetines se obtienen los siguientes datos: ")
        Console.WriteLine("los metros de hilo necesarios son : " & mhilonecesarios)
        Console.WriteLine("El tiempo de fabricación es : " & tfabricacion)
        Console.WriteLine("El costo de fabricación es: " & Costofabricacion)


    End Sub
End Module
