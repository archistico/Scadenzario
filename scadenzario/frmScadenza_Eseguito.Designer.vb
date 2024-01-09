<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScadenza_Eseguito
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRegistra = New System.Windows.Forms.Button()
        Me.tbxAttivita = New System.Windows.Forms.TextBox()
        Me.dtpScadenza = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnFatto = New System.Windows.Forms.Button()
        Me.dtpEseguito = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnElimina = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRegistra)
        Me.GroupBox1.Controls.Add(Me.tbxAttivita)
        Me.GroupBox1.Controls.Add(Me.dtpScadenza)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(335, 117)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modifica scadenza"
        '
        'btnRegistra
        '
        Me.btnRegistra.Location = New System.Drawing.Point(247, 70)
        Me.btnRegistra.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btnRegistra.Name = "btnRegistra"
        Me.btnRegistra.Size = New System.Drawing.Size(69, 35)
        Me.btnRegistra.TabIndex = 5
        Me.btnRegistra.Text = "Modifica"
        Me.btnRegistra.UseVisualStyleBackColor = True
        '
        'tbxAttivita
        '
        Me.tbxAttivita.Location = New System.Drawing.Point(21, 37)
        Me.tbxAttivita.Name = "tbxAttivita"
        Me.tbxAttivita.Size = New System.Drawing.Size(295, 20)
        Me.tbxAttivita.TabIndex = 4
        '
        'dtpScadenza
        '
        Me.dtpScadenza.Location = New System.Drawing.Point(21, 81)
        Me.dtpScadenza.Name = "dtpScadenza"
        Me.dtpScadenza.Size = New System.Drawing.Size(199, 20)
        Me.dtpScadenza.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Scadenza"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Attività"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFatto)
        Me.GroupBox2.Controls.Add(Me.dtpEseguito)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 211)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 75)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fatto"
        '
        'btnFatto
        '
        Me.btnFatto.Location = New System.Drawing.Point(247, 26)
        Me.btnFatto.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btnFatto.Name = "btnFatto"
        Me.btnFatto.Size = New System.Drawing.Size(69, 35)
        Me.btnFatto.TabIndex = 5
        Me.btnFatto.Text = "Segna Fatto"
        Me.btnFatto.UseVisualStyleBackColor = True
        '
        'dtpEseguito
        '
        Me.dtpEseguito.Location = New System.Drawing.Point(21, 37)
        Me.dtpEseguito.Name = "dtpEseguito"
        Me.dtpEseguito.Size = New System.Drawing.Size(199, 20)
        Me.dtpEseguito.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Data eseguito"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnElimina)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(335, 70)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Elimina"
        '
        'btnElimina
        '
        Me.btnElimina.Location = New System.Drawing.Point(247, 21)
        Me.btnElimina.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(69, 35)
        Me.btnElimina.TabIndex = 6
        Me.btnElimina.Text = "Elimina scadenza"
        Me.btnElimina.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(18, 21)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 35)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cancella la scadenza ma non le date passate degli eseguiti"
        '
        'frmScadenza_Eseguito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 298)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmScadenza_Eseguito"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scadenza"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRegistra As Button
    Friend WithEvents tbxAttivita As TextBox
    Friend WithEvents dtpScadenza As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnFatto As Button
    Friend WithEvents dtpEseguito As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnElimina As Button
End Class
