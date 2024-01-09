Imports System.IO
Imports System.Xml.Serialization
Imports System.Reflection
Imports System.Diagnostics

Public Class Form1

    Public Shared fileXMLscadenze As String = "dati-scadenze.xml"
    Public Shared fileXMLeseguiti As String = "dati-eseguiti.xml"

    Private Sub btnRegistra_Click(sender As Object, e As EventArgs) Handles btnRegistra.Click
        If AggiungiScadenza(tbxAttivita.Text, dtpScadenza.Value.Date) Then
            MessageBox.Show("Scadenza aggiunta", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information)
            CaricaScadenze()
        End If
    End Sub

    Private Sub btnAggiorna_Click(sender As Object, e As EventArgs) Handles btnAggiorna.Click
        CaricaScadenze()
    End Sub

    Private Function AggiungiScadenza(attivita As String, datascadenza As Date) As Boolean

        If Not ValidaScadenza() Then
            Return False
        End If

        Dim scadenze = New Scadenze
        Dim rec = New Scadenze
        Dim serializerR As New XmlSerializer(GetType(Scadenze), New XmlRootAttribute("SCADENZE"))

        If File.Exists(fileXMLscadenze) Then
            Using reader As New FileStream(fileXMLscadenze, FileMode.Open)
                rec = CType(serializerR.Deserialize(reader), Scadenze)
            End Using

            For Each el In rec.List
                scadenze.List.Add(New Scadenza With {.ID = el.ID, .Attivita = el.Attivita, .DataScadenza = el.DataScadenza})
            Next
        End If

        Dim myuuid As Guid = Guid.NewGuid()
        Dim myuuidAsString As String = myuuid.ToString()
        Dim scadenzaNuova = New Scadenza With {.ID = myuuidAsString, .Attivita = attivita, .DataScadenza = datascadenza}
        scadenze.List.Add(scadenzaNuova)

        Dim serializerW = New XmlSerializer(GetType(Scadenze))
        Using writer As New StreamWriter(fileXMLscadenze)
            serializerW.Serialize(writer, scadenze)
        End Using

        Return True
    End Function

    Private Function ValidaScadenza() As Boolean
        If String.IsNullOrEmpty(tbxAttivita.Text) Then
            MessageBox.Show("Immettere un testo come nome dell'attività", "Validazione", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbxAttivita.Select()
            Return False
        End If

        Return True
    End Function

    Private Sub CaricaScadenze()
        dgvScadenze.DataSource = Nothing
        If Not File.Exists(fileXMLscadenze) Then
            Return
        End If

        Dim rec = New Scadenze
        Dim serializer As New XmlSerializer(GetType(Scadenze), New XmlRootAttribute("SCADENZE"))

        Using reader As New FileStream(fileXMLscadenze, FileMode.Open)
            rec = CType(serializer.Deserialize(reader), Scadenze)
        End Using

        rec.List.Sort(Function(x, y) x.DataScadenza.CompareTo(y.DataScadenza))

        Dim table As DataTable = New DataTable()

        If Not rec.List.Any Then
            Return
        End If

        Dim fields() = rec.List.First.GetType.GetProperties
        For Each field In fields
            table.Columns.Add(field.Name, field.PropertyType)
        Next

        table.Columns.Add("Mancano", Type.GetType("System.String"))

        For Each item In rec.List
            Dim row As DataRow = table.NewRow()
            For Each field In fields
                Dim p = item.GetType.GetProperty(field.Name)
                row(field.Name) = p.GetValue(item, Nothing)

                If field.Name = "DataScadenza" Then
                    Dim span As TimeSpan = CType(p.GetValue(item, Nothing), DateTime) - Now()
                    Dim giorni As String = Math.Floor(span.Days).ToString
                    Dim ore As String = Math.Floor(span.Hours).ToString
                    row("Mancano") = giorni + " giorni e " + ore + " ore"
                End If
            Next
            table.Rows.Add(row)
        Next

        dgvScadenze.DataSource = table
        dgvScadenze.Columns("ID").Visible = False
        dgvScadenze.Columns("Attivita").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvScadenze.Columns("DataScadenza").HeaderText = "Scadenza"
    End Sub

    Private Sub dgvScadenze_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvScadenze.CellDoubleClick
        Dim rigaSelezionata As Integer = dgvScadenze.SelectedCells.Item(0).RowIndex

        Dim id As String = dgvScadenze.Rows(rigaSelezionata).Cells("ID").Value.ToString
        Dim attivita As String = dgvScadenze.Rows(rigaSelezionata).Cells("Attivita").Value.ToString
        Dim dataScadenza As DateTime = dgvScadenze.Rows(rigaSelezionata).Cells("DataScadenza").Value

        Dim scadenza As Scadenza = New Scadenza With {.ID = id, .Attivita = attivita, .DataScadenza = dataScadenza}

        Using frm As frmScadenza_Eseguito = New frmScadenza_Eseguito(scadenza)
            If DialogResult.OK = frm.ShowDialog() Then
                CaricaScadenze()
                CaricaEseguiti()
            End If
        End Using

    End Sub

    Private Sub btnAggiorna_Eseguiti_Click(sender As Object, e As EventArgs) Handles btnAggiorna_Eseguiti.Click
        CaricaEseguiti()
    End Sub

    Private Sub CaricaEseguiti()
        dgvEseguiti.DataSource = Nothing
        If Not File.Exists(fileXMLeseguiti) Then
            Return
        End If

        Dim rec = New Eseguiti
        Dim serializer As New XmlSerializer(GetType(Eseguiti), New XmlRootAttribute("ESEGUITI"))

        Using reader As New FileStream(fileXMLeseguiti, FileMode.Open)
            rec = CType(serializer.Deserialize(reader), Eseguiti)
        End Using

        rec.List.Sort(Function(x, y) x.DataScadenza.CompareTo(y.DataScadenza))

        Dim table As DataTable = New DataTable()

        If Not rec.List.Any Then
            Return
        End If

        Dim fields() = rec.List.First.GetType.GetProperties
        For Each field In fields
            table.Columns.Add(field.Name, field.PropertyType)
        Next

        table.Columns.Add("Anticipo", Type.GetType("System.String"))

        For Each item In rec.List
            Dim row As DataRow = table.NewRow()
            For Each field In fields
                Dim p = item.GetType.GetProperty(field.Name)
                row(field.Name) = p.GetValue(item, Nothing)
            Next

            Dim span As TimeSpan = row("DataScadenza") - row("DataEseguito")
            Dim giorni As String = Math.Floor(span.Days).ToString
            Dim ore As String = Math.Floor(span.Hours).ToString

            row("Anticipo") = giorni + " giorni e " + ore + " ore"

            table.Rows.Add(row)
        Next

        dgvEseguiti.DataSource = table
        dgvEseguiti.Columns("ID").Visible = False
        dgvEseguiti.Columns("Attivita").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        dgvEseguiti.Columns("DataScadenza").HeaderText = "Scadenza"
        dgvEseguiti.Columns("DataEseguito").HeaderText = "Eseguito"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaScadenze()
        CaricaEseguiti()
    End Sub
End Class
