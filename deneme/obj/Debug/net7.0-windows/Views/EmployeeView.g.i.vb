﻿#ExternalChecksum("..\..\..\..\Views\EmployeeView.xaml","{ff1816ec-aa5e-4d10-87f7-6f4963833460}","2582CEC947B692716A2DD2D9E585BEC9E1E89F5E")
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports deneme
Imports DevExpress.Xpf.DXBinding
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.Editors.DataPager
Imports DevExpress.Xpf.Editors.DateNavigator
Imports DevExpress.Xpf.Editors.ExpressionEditor
Imports DevExpress.Xpf.Editors.Filtering
Imports DevExpress.Xpf.Editors.Flyout
Imports DevExpress.Xpf.Editors.Popups
Imports DevExpress.Xpf.Editors.Popups.Calendar
Imports DevExpress.Xpf.Editors.RangeControl
Imports DevExpress.Xpf.Editors.Settings
Imports DevExpress.Xpf.Editors.Settings.Extension
Imports DevExpress.Xpf.Editors.Validation
Imports DevExpress.Xpf.Grid
Imports DevExpress.Xpf.Grid.ConditionalFormatting
Imports DevExpress.Xpf.Grid.LookUp
Imports DevExpress.Xpf.Grid.TreeList
Imports DevExpress.Xpf.LayoutControl
Imports FontAwesome.WPF
Imports FontAwesome.WPF.Converters
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Controls.Ribbon
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Forms.Integration
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''EmployeeView
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class EmployeeView
    Inherits System.Windows.Controls.UserControl
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",43)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents grid As DevExpress.Xpf.Grid.GridControl
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",105)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtInformation As DevExpress.Xpf.Editors.TextEdit
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",121)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents gridForm As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",188)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents companyBox As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",195)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents departmentBox As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",203)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtName As DevExpress.Xpf.Editors.TextEdit
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",208)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtSurname As DevExpress.Xpf.Editors.TextEdit
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",213)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtPhone As DevExpress.Xpf.Editors.TextEdit
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",218)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtIdentity As DevExpress.Xpf.Editors.TextEdit
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",223)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtBirthYear As DevExpress.Xpf.Editors.TextEdit
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",234)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents male As System.Windows.Controls.RadioButton
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",237)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents female As System.Windows.Controls.RadioButton
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",243)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtUsername As DevExpress.Xpf.Editors.TextEdit
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",248)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtMail As DevExpress.Xpf.Editors.TextEdit
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",253)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtAddress As DevExpress.Xpf.Editors.TextEdit
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",287)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtActive As System.Windows.Controls.TextBlock
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",294)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents activeBox As System.Windows.Controls.ComboBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",305)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtId As DevExpress.Xpf.Editors.TextEdit
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/deneme;component/views/employeeview.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.grid = CType(target,DevExpress.Xpf.Grid.GridControl)
            Return
        End If
        If (connectionId = 2) Then
            Me.txtInformation = CType(target,DevExpress.Xpf.Editors.TextEdit)
            Return
        End If
        If (connectionId = 3) Then
            
            #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",114)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.Information_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 4) Then
            Me.gridForm = CType(target,System.Windows.Controls.Grid)
            Return
        End If
        If (connectionId = 5) Then
            Me.companyBox = CType(target,System.Windows.Controls.ComboBox)
            Return
        End If
        If (connectionId = 6) Then
            Me.departmentBox = CType(target,System.Windows.Controls.ComboBox)
            Return
        End If
        If (connectionId = 7) Then
            Me.txtName = CType(target,DevExpress.Xpf.Editors.TextEdit)
            Return
        End If
        If (connectionId = 8) Then
            Me.txtSurname = CType(target,DevExpress.Xpf.Editors.TextEdit)
            Return
        End If
        If (connectionId = 9) Then
            Me.txtPhone = CType(target,DevExpress.Xpf.Editors.TextEdit)
            Return
        End If
        If (connectionId = 10) Then
            Me.txtIdentity = CType(target,DevExpress.Xpf.Editors.TextEdit)
            Return
        End If
        If (connectionId = 11) Then
            Me.txtBirthYear = CType(target,DevExpress.Xpf.Editors.TextEdit)
            Return
        End If
        If (connectionId = 12) Then
            Me.male = CType(target,System.Windows.Controls.RadioButton)
            Return
        End If
        If (connectionId = 13) Then
            Me.female = CType(target,System.Windows.Controls.RadioButton)
            Return
        End If
        If (connectionId = 14) Then
            Me.txtUsername = CType(target,DevExpress.Xpf.Editors.TextEdit)
            Return
        End If
        If (connectionId = 15) Then
            Me.txtMail = CType(target,DevExpress.Xpf.Editors.TextEdit)
            Return
        End If
        If (connectionId = 16) Then
            Me.txtAddress = CType(target,DevExpress.Xpf.Editors.TextEdit)
            Return
        End If
        If (connectionId = 17) Then
            
            #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",273)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.BtnClear_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 18) Then
            
            #ExternalSource("..\..\..\..\Views\EmployeeView.xaml",281)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnSave_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 19) Then
            Me.txtActive = CType(target,System.Windows.Controls.TextBlock)
            Return
        End If
        If (connectionId = 20) Then
            Me.activeBox = CType(target,System.Windows.Controls.ComboBox)
            Return
        End If
        If (connectionId = 21) Then
            Me.txtId = CType(target,DevExpress.Xpf.Editors.TextEdit)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class

