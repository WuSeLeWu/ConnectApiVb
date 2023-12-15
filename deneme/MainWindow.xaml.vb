Imports System.Text
Imports System.Windows.Controls

''' <summary>
''' Interaction logic for MainWindow.xaml
''' </summary>
Public Class MainWindow
    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As RoutedEventArgs)
        ' HomeView'i yükleyecek butonun tıklanma olayı
        MainFrame.Content = New HomeView()

    End Sub

    Private Sub ButtonRole_Click(sender As Object, e As RoutedEventArgs)
        ' RoleView'i yükleyecek butonun tıklanma olayı
        MainFrame.Content = New RoleView()

    End Sub

    Private Sub ButtonEmployee_Click(sender As Object, e As RoutedEventArgs)
        MainFrame.Content = New EmployeeView()

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
End Class