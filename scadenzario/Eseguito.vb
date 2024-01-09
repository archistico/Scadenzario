Imports System.Xml.Serialization

Public Class Eseguito
    <XmlElement("ID")>
    Public Property ID As String

    <XmlElement("ATTIVITA")>
    Public Property Attivita As String

    <XmlElement("DATASCADENZA")>
    Public Property DataScadenza As DateTime

    <XmlElement("DATAESEGUITO")>
    Public Property DataEseguito As DateTime
End Class
