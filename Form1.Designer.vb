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
        Label1 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        TextBox3 = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(117, 25)
        Label1.TabIndex = 0
        Label1.Text = "First number "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(33, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(138, 25)
        Label2.TabIndex = 0
        Label2.Text = "Second number"
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.ControlLight
        TextBox1.Location = New Point(179, 65)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.ControlLight
        TextBox2.Location = New Point(179, 127)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ControlDark
        Button1.Location = New Point(37, 184)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 3
        Button1.Text = "Maximum"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.ControlLight
        TextBox3.Location = New Point(179, 188)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(150, 31)
        TextBox3.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox3)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox3 As TextBox

End Class
