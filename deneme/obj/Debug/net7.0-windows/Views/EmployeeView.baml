   M S B A M L   `   `   `  ����A  =deneme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:denemedeneme  5
          deneme.EmployeeView   5      a ]DevExpress.Xpf.Core.v23.1, Version=23.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5      a ]DevExpress.Xpf.Grid.v23.1, Version=23.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49af	 bDevExpress.Xpf.Grid.v23.1.Core, Version=23.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49al
 hDevExpress.Xpf.Grid.v23.1.Extensions, Version=23.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a@dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid  	 
 5      j fDevExpress.Xpf.LayoutControl.v23.1, Version=23.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aFdxlc;http://schemas.devexpress.com/winfx/2008/xaml/layoutcontrol  5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5	       localclr-namespace:deneme  5
      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      .��5      �   � ColumnDefinitions  5   
   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��1��5       �� Padding$ 10q�5      
������� �� CornerRadius$ 	0 15 15 0��5      ._�5*      %  DevExpress.Xpf.Grid.GridControl  -   5        $
��grid��5+         
Background
 �����) 	 #DevExpress.Xpf.Grid.DataControlBase   
ShowBorder$
 True��5.         ItemsSource 5-      �� *RequestsByEmployee+   Columns 50      $  DevExpress.Xpf.Grid.GridColumn  51      $ 	 DevExpress.Xpf.Grid.ColumnBase   	FieldName$ ApprovingEmployeeName��52      $ 	 DevExpress.Xpf.Grid.BaseColumn   Header)  #DevExpress.Xpf.Core.ObjectConverter$ Approved Employee 53      	   ReadOnly$
	 True��54        55      $ ApprovingEmployeeSurname��56      $ Approved Employee 57      $
	 True��58        59      $ MeasuringUnitName��5:      $ Measuring Unit 5;      $
	 True��5<        5=      $ CreatedDate��5>      $ Create Date 5?      $
	 True��5@        5A      $ Quantity��5B      $ Quantity 5C      $
	 True��5D        5E      $ Details��5F      $ Details 5G      $
	 True��5H        5I      $ State��5J      $ State 5K      $
	 True��5L      
   View
 5O      "  DevExpress.Xpf.Grid.CardView  5P         CardHeaderBinding 6#   ��  �� Path$ ProductName�5R      5S      �� 5V   
   $
��Auto=�6   .��5W      �� $��0��5X      $ 25,20,25,20q�5Y      ���#ffffff$��0,0,2,0q�5[      $ 	15 0 0 15��5\      ._�5^      �  � RowDefinitions 5_      �� 5`      $
��auto �6(   �� 5a      $��* �6(   .+�5c      � $��0��6     5d      �� 5e      $��* �6/   �� 5f      $
��auto �6/   .+�5h      %  DevExpress.Xpf.Editors.TextEdit  -   5          Name$ txtInformation��5i      $��0��5j      $
��auto��5k      %	  DevExpress.Xpf.Editors.BaseEdit 	  NullText$  Enter your Identity Number��5l      �� 5m      -   5        $��1��5n      $��Right=�5o      ���#394867$��0q�5q      $��Get Information��5s      
�������5t      5u      � 5x      -   5         �Name$ gridForm��5y      $��1��5z      $��Center=�5{      $��Center=�5|        5}      �� 5~      $	��150 �6/   �� 5      $��* �6/    5�      �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   �� 5�      $
��auto �6,   .+�5�      �� $��0��5�         text#��[  5�      $��Company Name��5�      �� 5�      $��1��5�      #��[  5�      $��Department Name��5�      �� 5�      $��2��5�      #��[  5�      $
��Name��5�      �� 5�      $��3��5�      #��[  5�      $��Surname��5�      �� 5�      $��4��5�      #��[  5�      $��Phone Number��5�      �� 5�      $��5��5�      #��[  5�      $��Identity Number��5�      �� 5�      $��6��5�      #��[  5�      $��Birth Of Year��5�      �� 5�      $��8��5�      #��[  5�      $��Username��5�      �� 5�      $��9��5�      #��[  5�      $��Email��5�      �� 5�      $��10��5�      #��[  5�      $��Address��5�      �� 5�      -   5         ��Name$ 
companyBox��5�      $��0��5�      $��1��5�       �� DisplayMemberPath$
 Name��5�        CustomComboBoxItemStyle#��[ 5�      ��5�      �� *	Companies+�� 5�      -   5        $ departmentBox��5�      $��1��5�      $��1��5�      $
 Name��5�      #��[ 5�      ��5�      �� *Departments+  5�      -   5        $ txtName��5�      $��2��5�      $��1��5�      $
 Name��5�        5�      -   5        $ 
txtSurname��5�      $��3��5�      $��1��5�      $ Surname��5�        5�      -	   5        $ txtPhone��5�      $��4��5�      $��1��5�      $ (555) 555 55 55��5�        5�      -
   5        $ txtIdentity��5�      $��5��5�      $��1��5�      $ Identity Number��5�        5�      -   5        $ txtBirthYear��5�      $��6��5�      $��1��5�      $
 1999��5�      �� 5�      $��7��5�      $��1��5�      $
��0,10q�5�      $��Center=�5�       �� Orientation$ 
Horizontal=�5�      .+�5�      	� -   5         	�Name$
 male��5�   *   $��0,0,5,0q�68   .��5�   "   "
  FontAwesome.WPF.ImageAwesome
  $��19��62    
  Icon$
 Male=�6=   5�      	� 5�      -   5        $ female��5�   *   $��5,0,0,0q�6:   .��5�   "   
  $��23��62   $ Female=�6=   5�      5�        5�      -   5        $ txtUsername��5�      $��8��5�      $��1��5�      $ Username��5�        5�      -   5        $ txtMail��5�      $��9��5�      $��1��5�      $ 	ws@ws.com��5�        5�      -   5        $ 
txtAddress��5�      $��10��5�      $��1��5�      $	��100��5      $	��Top=�5     )  #DevExpress.Xpf.Editors.TextEditBase   AcceptsReturn$
 True��5     $ Address��5        TextWrapping$
 Wrap=�5     � 5     $��12��5     $��1��5     $��0,20,0,0q�5       5	     �� 5
  "   $��* �63   �� 5  "   $��* �63   .+�5     �� -   5        $��0,0,10,0q�5  !   ���#394867$��Clear��5  !   
�������5  !   �� 5     -   5        $��1��5  !   $��10,0,0,0q�5  !   ���#557571$
��Save��5  !   
�������5  !   5     �� 5     -   5         ��Name$ 	txtActive��5     $��11��5      #��[  5!     $��
Is Active?��5"     $y�	Collapsed=�5#     �� 5%     -   5        $ 	activeBox��5&     $��11��5'     $��1��5(     #��[ 5)     $y�	Collapsed=�5*     .@�5+     �� $��Active��6+   �� 5,     $��Passive��6+   5-       50     -   5        $ txtId��51        Text$ 0��52     $y�Hidden=�53     55     56     57     58     59     5;     