   M S B A M L   `   `   `  ����F  BSalesWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SalesWpfApp.ComponentSalesWpfApp.Component  5   	   =#clr-namespace:SalesWpfApp.ViewModelSalesWpfApp.ViewModel  6;   (    "SalesWpfApp.Component.UpdateDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SalesWpfApp.Component     5   	   9	viewmodel#clr-namespace:SalesWpfApp.ViewModel     6;     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	    � Title$ UpdateDialog��5
   	    � SizeToContent$ WidthAndHeight=�6   .��5      �� -   5         ��Name$ stpStudents��5   )   $	��300��6   $��20q�6   .+�5   
   �� $��0 0 0 5q�6   $��Center=�6%   $
��Bold"�6B   Member Detail6c   � 5   
   $��0 10 0 0q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��3* �6#   .+�5      �� $��0��6   $
��Bold"�6$   .��66   Email5      �� 5      $��1��6   $	��4 2q�6o   ��6&   �� *Email+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ TwoWay=�6o   5      � 5   
   $��0 10 0 0q�6    5      �� 5      $��* �6#   �� 5      $��3* �6#   .+�5!      �� $��0��6   $
��Bold"�6$   .��66   	Company5#      �� 5%      $��1��6   $	��4 2q�6u   ��6&   �� *CompanyName+$ PropertyChanged=�$ TwoWay=�6u   5&      � 5(   
   $��0 10 0 0q�6    5)      �� 5*      $��* �6#   �� 5+      $��3* �6#   .+�5.      �� $��0��6   $
��Bold"�6$   .��66   City50      �� 52      $��1��6   $	��4 2q�6n   ��6&   �� *City+$ PropertyChanged=�$ TwoWay=�6n   53      � 55   
   $��0 10 0 0q�6    56      �� 57      $��* �6#   �� 58      $��3* �6#   .+�5;      �� $��0��6   $
��Bold"�6$   .��66   	Country5=      �� 5?      $��1��6   $	��4 2q�6q   ��6&   �� *	Country+$ PropertyChanged=�$ TwoWay=�6q   5@      � 5B   
   $��0 10 0 0q�6    5C      �� 5D      $��* �6#   �� 5E      $��3* �6#   .+�5H      �� $��0��6   $
��Bold"�6$   .��66   
Password5J      �� 5L      $��1��6   $	��4 2q�6r   ��6&   �� *
Password+$ PropertyChanged=�$ TwoWay=�6r   5M      �� 5P   
   $��0 10 0 0q�6   $��Center=�6'    �� Orientation$ 
Horizontal=�6D   .+�5Q      �� $��0 5 5 5q�65   $��50��6G   ��6   �� *CloseDialog+.��6R   Cancel6Z   �� 5R      $��5 5 0 5q�6�   $��50��6�   ��6   �� *ActionDialog+��66   �� *MemberObject+{�6`   �� *	CanAction+��6�   �� *Action+$ TwoWay=�$ PropertyChanged=�6�   5S      5T      5U      