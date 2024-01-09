Imports System.IO
Imports System.Xml.Serialization
Imports System.Reflection
Imports System.Diagnostics
Imports scadenzario

Public Class frmScadenza_Eseguito

    Private _scadenza As Scadenza

    Public Sub New(scadenza As Scadenza)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        _scadenza = scadenza
    End Sub

    Private Sub frmScadenza_Eseguito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbxAttivita.Text = _scadenza.Attivita
        dtpScadenza.Value = _scadenza.DataScadenza

        dtpEseguito.Value = Today
    End Sub

    Private Sub btnRegistra_Click(sender As Object, e As EventArgs) Handles btnRegistra.Click
        If ModificaScadenza(tbxAttivita.Text, dtpScadenza.Value) Then
            MessageBox.Show("Scadenza modificata", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Function ValidaScadenza() As Boolean
        If String.IsNullOrEmpty(tbxAttivita.Text) Then
            MessageBox.Show("Immettere un testo come nome dell'attività", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbxAttivita.Select()
            Return False
        End If

        Return True
    End Function

    Private Function ModificaScadenza(attivita As String, datascadenza As Date) As Boolean

        If Not ValidaScadenza() Then
            Return False
        End If

        Dim scadenze = New Scadenze
        Dim rec = New Scadenze
        Dim serializerR As New XmlSerializer(GetType(Scadenze), New XmlRootAttribute("SCADENZE"))

        If File.Exists(Form1.fileXMLscadenze) Then
            Using reader As New FileStream(Form1.fileXMLscadenze, FileMode.Open)
                rec = CType(serializerR.Deserialize(reader), Scadenze)
            End Using

            For Each el In rec.List
                If el.ID = _scadenza.ID Then
                    scadenze.List.Add(New Scadenza With {.ID = el.ID, .Attivita = attivita, .DataScadenza = datascadenza})
                Else
                    scadenze.List.Add(New Scadenza With {.ID = el.ID, .Attivita = el.Attivita, .DataScadenza = el.DataScadenza})
                End If
            Next
        End If

        Dim serializerW = New XmlSerializer(GetType(Scadenze))
        Using writer As New StreamWriter(Form1.fileXMLscadenze)
            serializerW.Serialize(writer, scadenze)
        End Using

        Return True
    End Function

    Private Sub btnFatto_Click(sender As Object, e As EventArgs) Handles btnFatto.Click
        AggiungiEseguito(dtpEseguito.Value)

        'Modifica dataScadenza
        _scadenza.DataScadenza = _scadenza.DataScadenza.AddDays(365)
        dtpScadenza.Value = _scadenza.DataScadenza

        Dim scadenze = New Scadenze
        Dim rec = New Scadenze
        Dim serializerR As New XmlSerializer(GetType(Scadenze), New XmlRootAttribute("SCADENZE"))

        If File.Exists(Form1.fileXMLscadenze) Then
            Using reader As New FileStream(Form1.fileXMLscadenze, FileMode.Open)
                rec = CType(serializerR.Deserialize(reader), Scadenze)
            End Using

            For Each el In rec.List
                If el.ID = _scadenza.ID Then
                    scadenze.List.Add(New Scadenza With {.ID = el.ID, .Attivita = _scadenza.Attivita, .DataScadenza = _scadenza.DataScadenza})
                Else
                    scadenze.List.Add(New Scadenza With {.ID = el.ID, .Attivita = el.Attivita, .DataScadenza = el.DataScadenza})
                End If
            Next
        End If

        Dim serializerW = New XmlSerializer(GetType(Scadenze))
        Using writer As New StreamWriter(Form1.fileXMLscadenze)
            serializerW.Serialize(writer, scadenze)
        End Using


        MessageBox.Show("Aggiunto eseguito", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Function AggiungiEseguito(dataEseguito As Date) As Boolean

        Dim eseguiti = New Eseguiti
        Dim rec = New Eseguiti
        Dim serializerR As New XmlSerializer(GetType(Eseguiti), New XmlRootAttribute("ESEGUITI"))

        If File.Exists(Form1.fileXMLeseguiti) Then
            Using reader As New FileStream(Form1.fileXMLeseguiti, FileMode.Open)
                rec = CType(serializerR.Deserialize(reader), Eseguiti)
            End Using

            For Each el In rec.List
                eseguiti.List.Add(New Eseguito With {.ID = el.ID, .Attivita = el.Attivita, .DataScadenza = el.DataScadenza, .DataEseguito = el.DataEseguito})
            Next
        End If

        Dim myuuid As Guid = Guid.NewGuid()
        Dim myuuidAsString As String = myuuid.ToString()
        Dim eseguitoNuovo = New Eseguito With {.ID = myuuidAsString, .Attivita = _scadenza.Attivita, .DataScadenza = _scadenza.DataScadenza, .DataEseguito = dataEseguito}
        eseguiti.List.Add(eseguitoNuovo)

        Dim serializerW = New XmlSerializer(GetType(Eseguiti))
        Using writer As New StreamWriter(Form1.fileXMLeseguiti)
            serializerW.Serialize(writer, eseguiti)
        End Using

        Return True
    End Function

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        If DialogResult.Yes = MessageBox.Show($"Confermi di voler eliminare la scadenza?", "Informazione", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) Then
            If EliminaScadenza() Then
                MessageBox.Show("Scadenza eliminata", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Close()
            End If
        End If
    End Sub

    Private Function EliminaScadenza() As Boolean
        Dim scadenze = New Scadenze
        Dim rec = New Scadenze
        Dim serializerR As New XmlSerializer(GetType(Scadenze), New XmlRootAttribute("SCADENZE"))

        If File.Exists(Form1.fileXMLscadenze) Then
            Using reader As New FileStream(Form1.fileXMLscadenze, FileMode.Open)
                rec = CType(serializerR.Deserialize(reader), Scadenze)
            End Using

            For Each el In rec.List
                If Not (el.ID = _scadenza.ID) Then
                    scadenze.List.Add(New Scadenza With {.ID = el.ID, .Attivita = el.Attivita, .DataScadenza = el.DataScadenza})
                End If
            Next
        End If

        Dim serializerW = New XmlSerializer(GetType(Scadenze))
        Using writer As New StreamWriter(Form1.fileXMLscadenze)
            serializerW.Serialize(writer, scadenze)
        End Using

        Return True
    End Function
End Class