   M S B A M L   `   `   `  ����F  BSalesWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWpfAppSalesWpfApp  5      =#clr-namespace:SalesWpfApp.ViewModelSalesWpfApp.ViewModel  6/       SalesWpfApp.WindowOrders   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SalesWpfApp     5      9	viewmodel#clr-namespace:SalesWpfApp.ViewModel     6/     � WindowStartupLocation$  CenterScreen=�5	   	    � SizeToContent$ WidthAndHeight=�5
       � Title$ WindowOrders��5       J� IsHitTestVisible 5   	   �� *
CanClick+ �� Mode$ TwoWay=�.��5      �� 
�������.+�5   
   �� $��5q�60   $	��100��6;   $
��Left=�6G   ��6   �� *
BackToMenu+.��6b   Back to menu6p   �� 5   
   $��	0 10 0 10q�6   $��30(�6'   $��Center=�65   $
��Bold"�6R   Order6k   �� 5   
   -   5         ��Name$ lvShow��5   q   $	��200��5   M   $
��Auto=�6]   $��10q�5   d    �� SelectedItem 5      �� *OrderObject+$ OneWayToSource=���5      �� *OrderObjects+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� View 5      �� 5      .P�5      �� 	 �� Width$	 60��6%   $��OrderID��60   
 �� CellTemplate
 5      �� 5      .R�5   "   �� ��6,   �� *	OrderId+6G   5      5      �� 5      $	 70��6%   $��MemberId��60   
 5      �� 5      .R�5   "   �� ��6,   �� *
MemberId+6H   5       5"      �� 5$      $		 140��6%   $��	OrderDate��61   
 5%      �� 5&      .R�5'   "   �� ��6,   �� *	OrderDate+6I   5(      5*      �� 5,      $	 90��6%   $��Required Date��60   
 5-      �� 5.      .R�5/   "   �� ��6,   �� *RequireDare+6K   50      52      �� 54      $	 90��6%   $��Shipped Date��60   
 55      �� 56      .R�57   "   �� ��6,   �� *ShippingDate+6L   58      5:      �� 5<      $	 60��6%   $��Freight��60   
 5=      �� 5>      .R�5?   "   �� ��6,   �� *	Freight+6G   5@      5B      5C      5E      �� 5G   
   $��0 10 0 0q�6   $��Center=�6'    �� Orientation$ 
Horizontal=�6D   .+�5H      �� $��0 5 5 5q�6   $��50��6&   {�61   �� *	CanDelete+��5I      �� *UpdateCommand+��5J      �� *OrderObject+.��6B   Edit6H   �� 5K      $��5 5 0 5q�6   $��50��6&   {�61   �� *	CanDelete+��5L      �� *DeleteCommand+��5M      �� *OrderObject+.��6B   Delete6J   5N      5O      5P      