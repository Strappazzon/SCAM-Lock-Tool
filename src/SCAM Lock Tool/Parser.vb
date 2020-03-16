Imports IniParser
Imports IniParser.Model

Public Class Parser
    Public Shared Function GetBehavior() As Short
        Try
            'Read INI file
            Dim IniParser = New FileIniDataParser()
            Dim Data As IniData = IniParser.ReadFile("syskey.ini")
            Dim Behavior As String = Data("syskey")("behavior")

            'Return parsed SCAM Lock Tool behavior
            Return Short.Parse(Behavior)
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function GetCustomMessage() As String
        Try
            'Read INI file
            Dim IniParser = New FileIniDataParser()
            Dim Data As IniData = IniParser.ReadFile("syskey.ini")
            Dim Message As String = Data("syskey")("message")

            'Return parsed custom message
            If Message <> Nothing Then
                Return Message
            Else
                Return "An error occurred while attempting to scam this user."
            End If
        Catch
            Return "An error occurred while attempting to scam this user."
        End Try
    End Function
End Class
