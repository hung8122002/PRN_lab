   M S B A M L   `   `   `  ����F  BSalesWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SalesWpfApp.ComponentSalesWpfApp.Component  5   	   =#clr-namespace:SalesWpfApp.ViewModelSalesWpfApp.ViewModel  6;   %    SalesWpfApp.Component.BuyDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SalesWpfApp.Component     5   	   9	viewmodel#clr-namespace:SalesWpfApp.ViewModel     6;     � SizeToContent$  WidthAndHeight=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	    � Title$ 	BuyDialog��5   	   .��5      �� -   5         ��Name$ stpStudents��5   )   $	��300��6   $��20q�6   .+�5   
   �� $��0 0 0 5q�6   $��Center=�6%   $
��Bold"�6B   
Buy Detail6`   � 5   
   $��0 10 0 0q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��3* �6#   .+�5      �� $��0��6   $
��Bold"�6$   .��66   Name5      �� 5       �� 
IsReadOnly$
 True��63   $��1��6E   $	��4 2q�6U   ��6   �� *ProductName+6U   5      � 5   
   $��0 10 0 0q�6    5      �� 5      $��* �6#   �� 5      $��3* �6#   .+�5!      �� $��0��6   $
��Bold"�6$   .��66   
Unit Price5#      �� 5%      $
 True��6   $��1��6C   $	��4 2q�6S   ��6(   �� *	UnitPrice+6S   5&      � 5(   
   $��0 10 0 0q�6    5)      �� 5*      $��* �6#   �� 5+      $��3* �6#   .+�5.      �� $��0��6   $
��Bold"�6$   .��66   
Quantity50      �� 52      $��1��6b   $	��4 2q�6r   ��6   �� *
Quantity+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6r   53      � 55   
   $��0 10 0 0q�6    56      �� 57      $��* �6#   �� 58      $��3* �6#   .+�5;      �� $��0��6   $
��Bold"�6$   .��66   
Discount5=      �� 5?      $��1��6b   $	��4 2q�6r   ��6   �� *
Discount+$ TwoWay=�$ PropertyChanged=�6r   5@      �� 5C   
   $��0 10 0 0q�6   $��Center=�6'   	 �� Orientation$	 
Horizontal=�6D   .+�5D      �� $��0 5 5 5q�6   $��50��6&   ��5E      �� *CloseDialog+.��6:   Cancel6B   �� 5F      $��5 5 0 5q�6   $��50��6&   {�61   �� *CanBuy+��5G      �� *BuyProductCommand+.��6?   Buy6D   5H      5I      5J      