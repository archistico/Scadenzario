Imports System.Xml.Serialization

<XmlRoot("ESEGUITI")>
Public Class Eseguiti
    <XmlElement("ESEGUITO")>
    Public Property List As List(Of Eseguito) = New List(Of Eseguito)
End Class