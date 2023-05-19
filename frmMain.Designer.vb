<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        cmdEnviar = New Button()
        lblResultado = New Label()
        txtResultado = New TextBox()
        SuspendLayout()
        ' 
        ' cmdEnviar
        ' 
        cmdEnviar.Location = New Point(128, 42)
        cmdEnviar.Name = "cmdEnviar"
        cmdEnviar.Size = New Size(75, 23)
        cmdEnviar.TabIndex = 0
        cmdEnviar.Text = "Enviar"
        cmdEnviar.UseVisualStyleBackColor = True
        ' 
        ' lblResultado
        ' 
        lblResultado.AutoSize = True
        lblResultado.Location = New Point(316, 175)
        lblResultado.Name = "lblResultado"
        lblResultado.Size = New Size(0, 15)
        lblResultado.TabIndex = 1
        ' 
        ' txtResultado
        ' 
        txtResultado.Location = New Point(67, 82)
        txtResultado.Name = "txtResultado"
        txtResultado.ReadOnly = True
        txtResultado.Size = New Size(209, 23)
        txtResultado.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(330, 145)
        Controls.Add(txtResultado)
        Controls.Add(lblResultado)
        Controls.Add(cmdEnviar)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents cmdEnviar As Button
    Friend WithEvents lblResultado As Label
    Friend WithEvents txtResultado As TextBox
End Class
