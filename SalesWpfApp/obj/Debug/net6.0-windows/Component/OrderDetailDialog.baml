   M S B A M L   `   `   `  ����F  BSalesWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SalesWpfApp.ComponentSalesWpfApp.Component  5   	   =#clr-namespace:SalesWpfApp.ViewModelSalesWpfApp.ViewModel  6;   -    'SalesWpfApp.Component.OrderDetailDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SalesWpfApp.Component     5   	   9	viewmodel#clr-namespace:SalesWpfApp.ViewModel     6;     � Title$  OrderDetail��5   	    � SizeToContent$ WidthAndHeight=�6    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	   .��5      �� -   5         ��Name$ stpStudents��5   )   $	��300��6   $��20q�6   .+�5   
   �� $��0 0 0 5q�6   $��Center=�6%   $
��Bold"�6B   Order Detail6b   � 5   
   $��0 10 0 0q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5      �� $��0��6   $
��Bold"�6$   .��66   	Member Id5      �� 5       �� 
IsReadOnly$
 True��6   $��1��6B   $	��4 2q�6R   ��6(   �� *
MemberId+6R   5      � 5   
   $��0 10 0 0q�6    5      �� 5      $��* �6#   �� 5      $��2* �6#   .+�5!      �� $��0��6   $
��Bold"�6$   .��66   
Order Date5#      �� 5%      $
 True��6   $��1��6C   $	��4 2q�6S   ��6(   �� *	OrderDate+6S   5&      � 5(   
   $��0 10 0 0q�6    5)      �� 5*      $��* �6#   �� 5+      $��2* �6#   .+�5.      �� $��0��6   $
��Bold"�6$   .��66   Required Date50      �� 52      $��1��64   $	��4 2q�6D   ��6   �� *RequiredDate+6D   53      � 55   
   $��0 10 0 0q�6    56      �� 57      $��* �6#   �� 58      $��2* �6#   .+�5;      �� $��0��6   $
��Bold"�6$   .��66   Shipped Date5=      �� 5?      $��1��63   $	��4 2q�6C   ��6   �� *ShippedDate+6C   5@      � 5B   
   $��0 10 0 0q�6    5C      �� 5D      $��* �6#   �� 5E      $��2* �6#   .+�5H      �� $��0��6   $
��Bold"�6$   .��66   	Freight5J      �� 5L      $��1��6/   $	��4 2q�6?   ��6   �� *	Freight+6?   5M      � 5O   
   $��0 10 0 0q�6    5P      �� 5Q      $��* �6#   �� 5R      $��2* �6#   .+�5U      �� $��0��6   $
��Bold"�6$   .��66   
Unit Price5W      �� 5Y      $��1��61   $	��4 2q�6A   ��6   �� *	UnitPrice+6A   5Z      � 5\   
   $��0 10 0 0q�6    5]      �� 5^      $��* �6#   �� 5_      $��2* �6#   .+�5b      �� $��0��6   $
��Bold"�6$   .��66   
Quantity5d      �� 5f      $��1��60   $	��4 2q�6@   ��6   �� *
Quantity+6@   5g      � 5i   
   $��0 10 0 0q�6    5j      �� 5k      $��* �6#   �� 5l      $��2* �6#   .+�5o      �� $��0��6   $
��Bold"�6$   .��66   
Discount5q      �� 5s      $��1��60   $	��4 2q�6@   ��6   �� *
Discount+6@   5t      �� 5w   
   $��0 10 0 0q�6   $��Center=�6'    �� Orientation$ 
Horizontal=�6D   .+�5x      �� $��0 5 5 5q�65   $��50��6G   ��6   �� *CloseDialog+.��6R   Cancel6Z   �� 5y      $��5 5 0 5q�6e   $��50��6v   ��6   �� *UpdateOrderCommand+��6<   �� *OrderObject+.��6�   Edit6�   5z      5{      5|      