   M S B A M L   `   `   `  ����A  =deneme, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:denemedeneme  5          deneme.LoginWindow   5      a ]DevExpress.Xpf.Core.v23.1, Version=23.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aW SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35J 9http://schemas.microsoft.com/winfx/2006/xaml/presentation       5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5       localclr-namespace:deneme  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5        � Title$  LoginWindow��5	      $	��800��5
      $	��550��5       � AllowsTransparency$
 True��5      
������  � Icon$ Images/pandap.ico��5       � 
ResizeMode$ CanMinimize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5�      ��  �� CornerRadius$ 12��6   ._�5�   
   �� $��2q�5�      $ 10��5�       J� Opacity$
 0.95Q�5�      ��5�      �� 5�       �� 
StartPoint$	 0,0&�6&   	 �� EndPoint$		 1,1&�67   .��5�      � 
 � Offset$
 0Q�6#    � Color$ #ffffff��6.   � 5�      $

 0.75Q�6#   $ #394867��61   � 5�      $
 1Q�6#   $ #ffffff��6.   5�      ��5�      �� 5�      $	 0,1&�6&   $		 1,0&�67   .��5�      � $
 0Q�6#   $ #394867��6.   � 5�      $
 1Q�6#   $ #1B1448��6.   5�      ._�5�      �  � RowDefinitions 5�      �� 5�      $��30 �6$   �� 5�      $��* �6$   .+�5�      � -   5        $��0��5�       � ColumnDefinitions 5�      �� 5�      �� 5�      $��25 �6+   �� 5�      $��25 �6+   �� 5�      $��5 �6+   .+�5�      �� $��0��5�      $��10,0,0,0q�5�      $��Center=�5�      $��
Montserrat)�5�      $��10(�5�      
�������$��LOG IN��5�      �� 5�      -   5         ��Name$ btnMinimize��5�      $��1��5�      $��0q�5�       � Cursor$
 Hand��5�      $��
Montserrat)�5�      $��16(�5�      
���������5�      �� 5�       �� 
TargetType" ��6$   .�5�   "   ��  �� Property � �� �� Value
 �����6?    �� Triggers 5�   "   P� 5�   &    P� Property �@J�IsMouseOver P� Value$
 True��6E   . �5�   *   ��  � ��
 �����6G   5�   '   5�      ��5�      �� 5�       �� 
TargetType" ��6.   .R�5�   "   �� $��18��5�   %   $��18��5�   %   #��z��5�   %   $ 9��5�   %   ._�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      .��5�      "  FontAwesome.WPF.ImageAwesome  $��14��5�      $��2q�5�         
Foreground �#394867   Icon$ WindowMinimize=�5�      5�      �� 5�      -   5        $ btnClose��5�      $��2��5�      $��0q�5�      $
 Hand��5�      $��
Montserrat)�5�      $��12(�5�      
���������5�      �� 5�      " ��6$   .�5�   "   ��  � ��
 �����6?    5�   "   P� 5�   &    �@J�IsMouseOver$
 True��6E   . �5�   *   ��  � ��
 �����6G   5�   '   5�      ��5�      �� 5�      " ��6.   .R�5�   "   �� $��18��5�   %   $��18��5�   %   #��z��5�   %   $ 9��5�   %   ._�5�   &   �� $��Center=�67   $��Center=�6T   5�   #   5�      .��5�        $��11��5�      $��2q�5�       �#394867$ Close=�5�      5�      5      �� 5     $��1��5     $	��250��5     $��Center=�5      �� Orientation$ Vertical=�5     .+�5     �� $	��100��5     $	��100��5	     $��/Images/pandap.png��5
     �� 5     $
��0,15q�5     $��Center=�5     $��
Montserrat)�5     $��30(�5     $
��bold"�5     
�������$��X Y Z��5     �� 5     -   5         ��Name$ errorMessage��5     $��0,5,0,0q�5     $��
Montserrat)�5     $��12(�5     $��Medium"�5     
������� �� TextAlignment$ Center=�5     $
��Wrap=�5     �� 5     
�������$��0,0,0,2q�64   ._�5     �� .+�5      �� $��0,15,0,0q�5!  !   $��
Montserrat)�5"  !   $��14(�5#  !   $��Medium"�5$  !   
�������$��Username��5&  !   ]� 5'     .+�5(  "     $��15��5)  %   $
��Left=�5*  %   $��Center=�5+  %   
 �����$
 User=�5-  %   �� 5.  "   -   5         ��Name$ txtUserName��5/  %   $��25��50  %   $��0,5,0,0q�51  %   $��12,0,0,0q�52  %   $��Center=�53  %   
������ $��0q�55  %    �� 
CaretBrush
 �����$��
Montserrat)�57  %   $��13(�58  %   $��Medium"�59  %   
�������$��mustafaylmn1��5;  %   5<     5=     5?     �� 5@     
�������$��0,0,0,2q�64   ._�5A     �� .+�5B     �� $��0,15,0,0q�5C  !   $��
Montserrat)�5D  !   $��14(�5E  !   $��Medium"�5F  !   
�������$��Password��5H  !   ]� 5I     .+�5J  "     $��14��5K  %   $
��Left=�5L  %   $��Center=�5M  %   
 �����$	 Key=�5O  %   G� 5P  "   -   5         G�Name$ txtPassword��5Q  %   $��28��5R  %   $��0,5,0,0q�5S  %   $��10,0,0,0q�5T  %   $��Center=�5U  %   
������ $��0q�5W  %    G� 
CaretBrush
 �����$��
Montserrat)�5Y  %   $��13(�5Z  %   $��Medium"�5[  %   
�������  G� Password$  
mustafa123��5]  %   5^     5_     5`     �� 5c     -   5        $ LoginBtn��5d     $��0,50,0,0q�5e     $��0q�5f     $��LOG IN��5h     $
 Hand��5i     $��
Montserrat)�5j     $��12(�5k     
���������5m     �� 5n     " ��6$   .�5o  "   ��  � �� �#3948676?    5p  "   P� 5q  &    �@J�IsMouseOver$
 True��6E   . �5r  *   ��  � �� �#5050676G   5s  '   5u     ��5w     �� 5x     " ��6.   .R�5y  "   �� $	��150��5z  %   $��40��5{  %   #��z��5|  %   $ 20��5}  %   ._�5~  &   �� $��Center=�67   $��Center=�6T   5  #   5�     5�     5�     5�     5�     5�     5�     