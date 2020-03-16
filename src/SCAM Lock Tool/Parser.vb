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
End Class
