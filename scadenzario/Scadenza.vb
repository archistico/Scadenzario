Imports System.Xml.Serialization

Public Class Scadenza
    <XmlElement("ID")>
    Public Property ID As String

    <XmlElement("ATTIVITA")>
    Public Property Attivita As String

    <XmlElement("DATASCADENZA")>
    Public Property DataScadenza As DateTime
End Class