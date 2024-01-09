<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgvScadenze = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAggiorna = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnAggiorna_Eseguiti = New System.Windows.Forms.Button()
        Me.dgvEseguiti = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvScadenze, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvEseguiti, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuova scadenza"
        '
        'btnRegistra
        '
        Me.btnRegistra.Location = New System.Drawing.Point(247, 70)
        Me.btnRegistra.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btnRegistra.Name = "btnRegistra"
        Me.btnRegistra.Size = New System.Drawing.Size(69, 35)
        Me.btnRegistra.TabIndex = 5
        Me.btnRegistra.Text = "Registra"
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
        'dgvScadenze
        '
        Me.dgvScadenze.AllowUserToAddRows = False
        Me.dgvScadenze.AllowUserToDeleteRows = False
        Me.dgvScadenze.AllowUserToOrderColumns = True
        Me.dgvScadenze.AllowUserToResizeRows = False
        Me.dgvScadenze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScadenze.Location = New System.Drawing.Point(21, 51)
        Me.dgvScadenze.MultiSelect = False
        Me.dgvScadenze.Name = "dgvScadenze"
        Me.dgvScadenze.ReadOnly = True
        Me.dgvScadenze.RowHeadersVisible = False
        Me.dgvScadenze.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvScadenze.Size = New System.Drawing.Size(416, 335)
        Me.dgvScadenze.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnAggiorna)
        Me.GroupBox2.Controls.Add(Me.dgvScadenze)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(459, 409)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista scadenze"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Doppio click per modifica"
        '
        'btnAggiorna
        '
        Me.btnAggiorna.Location = New System.Drawing.Point(368, 22)
        Me.btnAggiorna.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btnAggiorna.Name = "btnAggiorna"
        Me.btnAggiorna.Size = New System.Drawing.Size(69, 23)
        Me.btnAggiorna.TabIndex = 6
        Me.btnAggiorna.Text = "Aggiorna"
        Me.btnAggiorna.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAggiorna_Eseguiti)
        Me.GroupBox3.Controls.Add(Me.dgvEseguiti)
        Me.GroupBox3.Location = New System.Drawing.Point(477, 135)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(555, 409)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lista fatti"
        '
        'btnAggiorna_Eseguiti
        '
        Me.btnAggiorna_Eseguiti.Location = New System.Drawing.Point(465, 22)
        Me.btnAggiorna_Eseguiti.Margin = New System.Windows.Forms.Padding(3, 10, 3, 3)
        Me.btnAggiorna_Eseguiti.Name = "btnAggiorna_Eseguiti"
        Me.btnAggiorna_Eseguiti.Size = New System.Drawing.Size(69, 23)
        Me.btnAggiorna_Eseguiti.TabIndex = 6
        Me.btnAggiorna_Eseguiti.Text = "Aggiorna"
        Me.btnAggiorna_Eseguiti.UseVisualStyleBackColor = True
        '
        'dgvEseguiti
        '
        Me.dgvEseguiti.AllowUserToAddRows = False
        Me.dgvEseguiti.AllowUserToDeleteRows = False
        Me.dgvEseguiti.AllowUserToOrderColumns = True
        Me.dgvEseguiti.AllowUserToResizeRows = False
        Me.dgvEseguiti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEseguiti.Location = New System.Drawing.Point(21, 51)
        Me.dgvEseguiti.MultiSelect = False
        Me.dgvEseguiti.Name = "dgvEseguiti"
        Me.dgvEseguiti.ReadOnly = True
        Me.dgvEseguiti.RowHeadersVisible = False
        Me.dgvEseguiti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEseguiti.Size = New System.Drawing.Size(513, 335)
        Me.dgvEseguiti.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(474, 33)
        Me.Label4.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TODO:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(474, 51)
        Me.Label5.Margin = New System.Windows.Forms.Padding(3, 5, 3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(462, 66)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "- " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Cancella eseguito" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Modifica eseguito" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- GUI"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1044, 556)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Scadenzario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvScadenze, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvEseguiti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRegistra As Button
    Friend WithEvents tbxAttivita As TextBox
    Friend WithEvents dtpScadenza As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvScadenze As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnAggiorna As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnAggiorna_Eseguiti As Button
    Friend WithEvents dgvEseguiti As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
