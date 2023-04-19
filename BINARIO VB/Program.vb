Imports System
Imports System.IO

Module Program
    Sub Main(args As String())
        Dim ARCHIVOLECTOR As FileStream
        Dim ARCHIVOESCRITOR As FileStream
        Dim LECTOR As BinaryReader
        Dim ESCRITOR As BinaryWriter
        ARCHIVOESCRITOR = New FileStream("DATOD.dat", FileMode.OpenOrCreate, FileAccess.Write)
        ESCRITOR = New BinaryWriter(ARCHIVOESCRITOR)
        ESCRITOR.Write("juan")
        ESCRITOR.Write(18)
        ESCRITOR.Write("8661548525")
        ESCRITOR.Write("DIANA")
        ESCRITOR.Write(28)
        ESCRITOR.Write("86617425")
        ESCRITOR.Close()
        ARCHIVOESCRITOR.Close()
        ARCHIVOLECTOR = New FileStream("DATOD.dat", FileMode.OpenOrCreate, FileAccess.Read)
        LECTOR = New BinaryReader(ARCHIVOLECTOR)

        While ARCHIVOLECTOR.Position <> ARCHIVOLECTOR.Length
            Console.WriteLine(LECTOR.ReadString())
            Console.WriteLine(LECTOR.ReadInt32())
            Console.WriteLine(LECTOR.ReadString())
        End While

        LECTOR.Close()
        ARCHIVOLECTOR.Close()
        Console.ReadKey()
    End Sub
End Module
