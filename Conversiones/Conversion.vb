Imports System.Math

Public Class Conversion

    ''' <summary>
    ''' Convertir �Cantidad Num�rica en Cantidad en Letra
    ''' </summary>
    ''' <param name="Numero">Cantidad Num�rica</param>
    ''' <param name="CentimosEnLetra">True convierte Centavos, False escribe n�meros.</param>
    ''' <returns></returns>
    Public Shared Function CONVERTIRNUM(Numero As Double, Optional ByVal CentimosEnLetra As Boolean = False) As String

        'CODIGO compartido en http://exceltotal.com/

        Dim Moneda As String
        Dim Monedas As String
        Dim Centimo As String
        Dim Centimos As String
        Dim Preposicion As String
        Dim NumCentimos As Double
        Dim Letra As String
        Const Maximo = 1999999999.99

        '************************************************************
        ' Par�metros
        '************************************************************
        Moneda = "Peso"         'Nombre de Moneda (Singular)
        Monedas = "Pesos"       'Nombre de Moneda (Plural)
        Centimo = "Centavo"     'Nombre de C�ntimos (Singular)
        Centimos = "Centavos"   'Nombre de C�ntimos (Plural)
        Preposicion = "Con"     'Preposici�n entre Moneda y C�ntimos
        '************************************************************
        Try
            'Validar que el Numero est� dentro de los l�mites
            If (Numero >= 0) And (Numero <= Maximo) Then


                Letra = NUMERORECURSIVO((Fix(Numero)))              'Convertir el Numero en letras

                'Si Numero = 1 agregar leyenda Moneda (Singular)
                If (Numero = 1) Then
                    Letra = Letra & " " & Moneda
                    'De lo contrario agregar leyenda Monedas (Plural)
                Else
                    Letra = Letra & " " & Monedas
                End If


                NumCentimos = Round((Numero - Fix(Numero)) * 100)   'Obtener los centimos del Numero

                'Si NumCentimos es mayor a cero inicar la conversi�n
                If NumCentimos >= 0 Then
                    'Si el par�metro CentimosEnLetra es VERDADERO obtener letras para los c�ntimos
                    If CentimosEnLetra Then
                        Letra = Letra & " " & Preposicion & " " & NUMERORECURSIVO(Fix(NumCentimos)) 'Convertir los c�ntimos en letra

                        'Si NumCentimos = 1 agregar leyenda Centimos (Singular)
                        If (NumCentimos = 1) Then
                            Letra = Letra & " " & Centimo & " M. N. "
                            'De lo contrario agregar leyenda Centimos (Plural)
                        Else
                            Letra = Letra & " " & Centimos & " M. N. "
                        End If
                        'De lo contrario mostrar los c�ntimos como n�mero
                    Else
                        If NumCentimos < 10 Then
                            Letra = Letra & " 0" & NumCentimos & "/100 M. N."
                        Else
                            Letra = Letra & " " & NumCentimos & "/100 M. N."
                        End If
                    End If
                End If

                'Regresar el resultado final de la conversi�n
                CONVERTIRNUM = Letra

            Else
                'Si el Numero no est� dentro de los l�mites, entivar un mensaje de error
                CONVERTIRNUM = "ERROR: El n�mero excede los l�mites."
            End If
        Catch ex As Exception
            'Si el N�mero tiene un valor no v�lido
            CONVERTIRNUM = "Error en conversi�n." & Environment.NewLine & ex.Message
        End Try


    End Function

    ''' <summary>
    ''' Conversi�n de N�mero en su cadena correspondiente
    ''' </summary>
    ''' <param name="Numero">N�mero a convertir</param>
    ''' <returns></returns>
    Public Shared Function NUMERORECURSIVO(Numero As Long) As String

        'CODIGO compartido en http://exceltotal.com/

        Dim Resultado As String = String.Empty

        '**************************************************
        ' Nombre de los n�meros
        '**************************************************
        Dim Unidades = New String() {"", "Un", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorece", "Quince", "Diecis�is", "Diecisiete", "Dieciocho", "Diecinueve", "Veinte", "Veintiuno", "Veintidos", "Veintitres", "Veinticuatro", "Veinticinco", "Veintiseis", "Veintisiete", "Veintiocho", "Veintinueve"}
        Dim Decenas = New String() {"", "Diez", "Veinte", "Treinta", "Cuarenta", "Cincuenta", "Sesenta", "Setenta", "Ochenta", "Noventa", "Cien"}
        Dim Centenas = New String() {"", "Ciento", "Doscientos", "Trescientos", "Cuatrocientos", "Quinientos", "Seiscientos", "Setecientos", "Ochocientos", "Novecientos"}
        '**************************************************


        Select Case Numero
            Case 0
                Resultado = "Cero"
            Case 1 To 29
                Resultado = Unidades(Numero)
            Case 30 To 100
                Resultado = Decenas(Numero \ 10) + IIf(Numero Mod 10 <> 0, " y " + NUMERORECURSIVO(Numero Mod 10), "")
            Case 101 To 999
                Resultado = Centenas(Numero \ 100) + IIf(Numero Mod 100 <> 0, " " + NUMERORECURSIVO(Numero Mod 100), "")
            Case 1000 To 1999
                Resultado = "Mil" + IIf(Numero Mod 1000 <> 0, " " + NUMERORECURSIVO(Numero Mod 1000), "")
            Case 2000 To 999999
                Resultado = NUMERORECURSIVO(Numero \ 1000) + " Mil" + IIf(Numero Mod 1000 <> 0, " " + NUMERORECURSIVO(Numero Mod 1000), "")
            Case 1000000 To 1999999
                Resultado = "Un Mill�n" + IIf(Numero Mod 1000000 <> 0, " " + NUMERORECURSIVO(Numero Mod 1000000), "")
            Case 2000000 To 1999999999
                Resultado = NUMERORECURSIVO(Numero \ 1000000) + " Millones" + IIf(Numero Mod 1000000 <> 0, " " + NUMERORECURSIVO(Numero Mod 1000000), "")
        End Select

        NUMERORECURSIVO = Resultado

    End Function

End Class
