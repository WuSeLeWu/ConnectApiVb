﻿#ExternalChecksum("..\..\..\..\Views\RoleView.xaml","{ff1816ec-aa5e-4d10-87f7-6f4963833460}","7EDC1E5515175207C65B9915935530893D284A86")
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
'''RoleView
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class RoleView
    Inherits System.Windows.Controls.UserControl
    Implements System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector
    
    
    #ExternalSource("..\..\..\..\Views\RoleView.xaml",35)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtId As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\RoleView.xaml",50)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents txtName As System.Windows.Controls.TextBox
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\RoleView.xaml",73)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnSave As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\RoleView.xaml",96)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents btnLoad As System.Windows.Controls.Button
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Views\RoleView.xaml",114)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents dg As System.Windows.Controls.DataGrid
    
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
        Dim resourceLocater As System.Uri = New System.Uri("/deneme;V1.0.0.0;component/views/roleview.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\Views\RoleView.xaml",1)
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
            Me.txtId = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 2) Then
            Me.txtName = CType(target,System.Windows.Controls.TextBox)
            Return
        End If
        If (connectionId = 3) Then
            Me.btnSave = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\..\Views\RoleView.xaml",79)
            AddHandler Me.btnSave.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnSave_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 4) Then
            Me.btnLoad = CType(target,System.Windows.Controls.Button)
            
            #ExternalSource("..\..\..\..\Views\RoleView.xaml",102)
            AddHandler Me.btnLoad.Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnLoad_Click)
            
            #End ExternalSource
            Return
        End If
        If (connectionId = 5) Then
            Me.dg = CType(target,System.Windows.Controls.DataGrid)
            Return
        End If
        Me._contentLoaded = true
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")>  _
    Sub System_Windows_Markup_IStyleConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IStyleConnector.Connect
        If (connectionId = 6) Then
            
            #ExternalSource("..\..\..\..\Views\RoleView.xaml",162)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnDelete_Click)
            
            #End ExternalSource
        End If
        If (connectionId = 7) Then
            
            #ExternalSource("..\..\..\..\Views\RoleView.xaml",175)
            AddHandler CType(target,System.Windows.Controls.Button).Click, New System.Windows.RoutedEventHandler(AddressOf Me.btnEdit_Click)
            
            #End ExternalSource
        End If
    End Sub
End Class

