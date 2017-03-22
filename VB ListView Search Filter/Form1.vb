Public Class Form1
    'DECLARE LIST
    Dim spacecrafts As List(Of Spacecraft)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
    End Sub

    'SETUP LISTVIEW COLUMNS AND PRPERTIES
    Private Sub SetupListView()

        mListView.View = View.Details
        mListView.FullRowSelect = True
        mListView.Columns.Add("Name", 150)
        mListView.Columns.Add("Destination", 230)

        spacecrafts = New List(Of Spacecraft)
        Dim s = New Spacecraft
        With s
            .NameProperty = "Casini"
            .DestinationProperty = "Saturn"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Enterprise"
            .DestinationProperty = "Andromeda"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Challenger"
            .DestinationProperty = "Pluto"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "New Horizon"
            .DestinationProperty = "Asteroid Belt"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Opportunity"
            .DestinationProperty = "Mars"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Curiosity"
            .DestinationProperty = "Mars"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Juno"
            .DestinationProperty = "Jupiter"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Apollo 15"
            .DestinationProperty = "Moon"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Apollo 17"
            .DestinationProperty = "Moon"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Voyager A"
            .DestinationProperty = "Alpha Centauri"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Voyager B"
            .DestinationProperty = "Proxima Centauri"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Rosetter"
            .DestinationProperty = "Alpha Centauri"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Venus"
            .DestinationProperty = "Proxima Centauri"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Spitzer"
            .DestinationProperty = "Uranus"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Chandra"
            .DestinationProperty = "Mercury"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Pioneer"
            .DestinationProperty = "Mars"
            spacecrafts.Add(s)
        End With
        s = New Spacecraft
        With s
            .NameProperty = "Atlantis"
            .DestinationProperty = "Jupiter"
            spacecrafts.Add(s)
        End With

        'POPULATE SPACECRAFTS
        For Each s In spacecrafts
            mListView.Items.Add(New ListViewItem(New String() {s.NameProperty, s.DestinationProperty}))
        Next s

    End Sub

    ' SEARCH DATA
    Private Sub searchData(searchTerm As String)
        mListView.Items.Clear()
        For Each s In spacecrafts

            If s.NameProperty.ToLower().Contains(searchTerm.ToLower()) Or s.DestinationProperty.ToLower().Contains(searchTerm.ToLower()) Then
                mListView.Items.Add(New ListViewItem(New String() {s.NameProperty, s.DestinationProperty}))
            End If
        Next s
    End Sub


    '  SEARCH VALUE CHANGED
    Private Sub searchTxt_TextChanged(sender As Object, e As EventArgs) Handles searchTxt.TextChanged
        searchData(searchTxt.Text)
    End Sub

    Class Spacecraft
        Dim name, destination As String

        Public Property NameProperty() As String
            Get
                Return name
            End Get
            Set(ByVal value As String)
                name = value
            End Set
        End Property

        Public Property DestinationProperty() As String
            Get
                Return destination
            End Get
            Set(ByVal value As String)
                destination = value
            End Set
        End Property
    End Class

End Class
