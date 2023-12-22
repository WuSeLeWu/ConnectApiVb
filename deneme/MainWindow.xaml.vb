Imports System.Text
Imports System.Windows.Controls

''' <summary>
''' Interaction logic for MainWindow.xaml
''' </summary>
Public Class MainWindow

    Private ReadOnly mainViewModel As MainViewModel
    Public Sub New()
        InitializeComponent()
        mainViewModel = New MainViewModel()
        mainViewModel.LoadPagesFromAPI()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As RoutedEventArgs)
        WindowState = WindowState.Minimized
    End Sub

    Private Sub btnClose_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub Window_MouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs)
        If e.ChangedButton = MouseButton.Left Then
            Me.DragMove()
        End If
    End Sub

    Private Sub btnMaxi_Nomi_Click(sender As Object, e As RoutedEventArgs)
        If WindowState = WindowState.Maximized Then
            WindowState = WindowState.Normal
        Else
            WindowState = WindowState.Maximized
        End If
    End Sub

    Private Sub PageNavigation_Click(sender As Object, e As RoutedEventArgs)
        Dim clickedButton As Button = CType(sender, Button)
        Dim clickedPage As PageModel = CType(clickedButton.DataContext, PageModel)

        Dim userControlName As String = clickedPage.Url ' UserControl adını aldık

        ' UserControl'ün türünü almak için Reflection kullanma
        Dim userControlType As Type = Type.GetType("deneme." & userControlName) ' Namespace, UserControl'lerin bulunduğu yerdir

        If userControlType IsNot Nothing Then
            ' UserControl'ün örneğini oluşturup MainFrame.Content'e atama
            Dim userControlInstance As Object = Activator.CreateInstance(userControlType)
            MainFrame.Content = userControlInstance
        Else

        End If
    End Sub




End Class