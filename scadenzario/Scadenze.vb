Imports System.Xml.Serialization

<XmlRoot("SCADENZE")>
Public Class Scadenze

    <XmlElement("SCADENZA")>
    Public Property List As List(Of Scadenza) = New List(Of Scadenza)

End Class
