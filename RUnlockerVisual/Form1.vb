Imports System.IO

Public Class Form1
    Private fpsValue As Integer
    Private Sub SetFPS_Click(sender As Object, e As EventArgs) Handles SetFPS.Click
        Dim username As String = Environment.UserName
        Dim versionsPath As String = $"C:\Users\{username}\AppData\Local\Roblox\Versions"
        Dim latestVersionPath As String = GetLatestModifiedFolder(versionsPath)

        If latestVersionPath IsNot Nothing Then
            Dim clientSettingsPath As String = Path.Combine(latestVersionPath, "ClientSettings")
            Directory.CreateDirectory(clientSettingsPath)

            Dim fpsValue As Integer
            If Integer.TryParse(FPSValue1.Text, fpsValue) Then
                Dim jsonFilePath As String = Path.Combine(clientSettingsPath, "ClientAppSettings.json")
                Using sw As New StreamWriter(jsonFilePath)
                    sw.WriteLine($"{{""DFIntTaskSchedulerTargetFps"": {fpsValue}}}")
                End Using

                MessageBox.Show("Settings saved successfully.")
            Else
                MessageBox.Show("Invalid FPS value.")
            End If
        Else
            MessageBox.Show("No Roblox versions found.")
        End If
    End Sub

    Private Function GetLatestModifiedFolder(path As String) As String
        Dim latestModifiedDate As DateTime = DateTime.MinValue
        Dim latestModifiedFolder As String = Nothing

        If Directory.Exists(path) Then
            For Each folderPath As String In Directory.GetDirectories(path)
                Dim folderModifiedDate As DateTime = Directory.GetLastWriteTime(folderPath)
                If folderModifiedDate > latestModifiedDate Then
                    latestModifiedDate = folderModifiedDate
                    latestModifiedFolder = folderPath
                End If
            Next
        End If

        Return latestModifiedFolder
    End Function


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CloseInstances_Click(sender As Object, e As EventArgs) Handles CloseInstances.Click
        Dim processes() As Process = Process.GetProcessesByName("RobloxPlayerBeta")

        For Each p As Process In processes
            p.Kill()
            p.WaitForExit()
        Next

        MessageBox.Show($"Closed {processes.Length} ROBLOX instance(s).")
    End Sub


    Private Sub ExitProgram_Click(sender As Object, e As EventArgs) Handles ExitProgram.Click
        Application.Exit()
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles FPSValue1.TextChanged

    End Sub
End Class