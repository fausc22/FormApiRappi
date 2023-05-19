Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Text


Public Class Form1

    Private Async Sub cmdEnviar_Click(sender As Object, e As EventArgs) Handles cmdEnviar.Click
        ' Abrir dialogo para seleccionar JSON
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos JSON (*.json)|*.json"
        openFileDialog.Title = "Seleccionar archivo JSON"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                ' Leer el contenido del JSON
                Dim json As String = Await File.ReadAllTextAsync(openFileDialog.FileName)

                'Enviar el JSON a la api
                Dim respuesta As String = Await EnviarJSONAsync(json)

                'Mostrar la respuesta en label
                txtResultado.Text = respuesta

            Catch ex As Exception
                MessageBox.Show("Error al cargar y enviar el archivo JSON: " & ex.Message)
            End Try
        End If


    End Sub


    ' procedimiento para enviar JSON
    Private Async Function EnviarJSONAsync(json As String) As Task(Of String)
        'URL de la API
        Dim url As String = "http://localhost/POST.php"

        Try
            'Crear HTTP
            Using client As New HttpClient()
                client.Timeout = TimeSpan.FromMinutes(15)
                client.DefaultRequestHeaders.Accept.Clear()
                client.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("application/json"))

                'contenido de la solicitud
                Dim content As New StringContent(json, Encoding.UTF8, "application/json")


                'enviar solicitud POST a la API y obtener respuesta
                Dim response As HttpResponseMessage = Await client.PostAsync(url, content)

                ' Leer respuesta
                Dim respuesta As String = Await response.Content.ReadAsStringAsync()

                Return respuesta

            End Using
        Catch ex As Exception
            Throw New Exception("Error al enviar el JSON a la API: " & ex.Message)

        End Try
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
