Imports System.IO
Imports System.Runtime.CompilerServices

Module MainModule
    ''' <summary>
    ''' Randomizes the contents of the list using Fisher–Yates shuffle (a.k.a. Knuth shuffle).
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <returns>Randomized result</returns>
    ''' <remarks></remarks>
    <Extension()>
    Function Randomize(Of T)(ByVal list As List(Of T)) As List(Of T)
        Dim rand As New Random()
        Dim temp As T
        Dim indexRand As Integer
        Dim indexLast As Integer = list.Count - 1
        For index As Integer = 0 To indexLast
            indexRand = rand.Next(index, indexLast)
            temp = list(indexRand)
            list(indexRand) = list(index)
            list(index) = temp
        Next index
        Return list
    End Function
End Module
