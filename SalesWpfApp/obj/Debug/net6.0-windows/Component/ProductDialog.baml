   M S B A M L   `   `   `  ����F  BSalesWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:SalesWpfApp.ComponentSalesWpfApp.Component  5   	   =#clr-namespace:SalesWpfApp.ViewModelSalesWpfApp.ViewModel  6;   )    #SalesWpfApp.Component.ProductDialog   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:SalesWpfApp.Component     5   	   9	viewmodel#clr-namespace:SalesWpfApp.ViewModel     6;     � Title$  ProductDialog��5   	    � SizeToContent$ WidthAndHeight=�6    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$
 None=�5
   	   .��5      �� -   5         ��Name$ stpStudents��5   )   $	��300��6   $��20q�6   .+�5   
   �� $��0 0 0 5q�6   $��Center=�6%   $
��Bold"�6B   Product Detail6d   � 5   
   $��0 10 0 0q�6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��3* �6#   .+�5      �� $��0��6   $
��Bold"�6$   .��66   
Category5      �� 5      $��1��6d   $	��4 2q�6t   ��6   �� *
CategoryId+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6t   5      � 5   
   $��0 10 0 0q�6    5      �� 5      $��* �6#   �� 5      $��3* �6#   .+�5       �� $��0��6   $
��Bold"�6$   .��66   Name5"      �� 5$      $��1��6e   $	��4 2q�6u   ��6   �� *ProductName+$ TwoWay=�$ PropertyChanged=�6u   5%      � 5'   
   $��0 10 0 0q�6    5(      �� 5)      $��* �6#   �� 5*      $��3* �6#   .+�5-      �� $��0��6   $
��Bold"�6$   .��66   Weight5/      �� 51      $��1��6`   $	��4 2q�6p   ��6   �� *Weight+$ TwoWay=�$ PropertyChanged=�6p   52      � 54   
   $��0 10 0 0q�6    55      �� 56      $��* �6#   �� 57      $��3* �6#   .+�5:      �� $��0��6   $
��Bold"�6$   .��66   Price5<      �� 5>      $��1��6c   $	��4 2q�6s   ��6   �� *	UnitPrice+$ TwoWay=�$ PropertyChanged=�6s   5?      � 5A   
   $��0 10 0 0q�6    5B      �� 5C      $��* �6#   �� 5D      $��3* �6#   .+�5G      �� $��0��6   $
��Bold"�6$   .��66   Stock5I      �� 5K      $��1��6c   $	��4 2q�6s   ��6   �� *	UnitStock+$ TwoWay=�$ PropertyChanged=�6s   5L      �� 5O   
   $��0 10 0 0q�6   $��Center=�6'    �� Orientation$ 
Horizontal=�6D   .+�5P      �� $��0 5 5 5q�65   $��50��6G   ��6   �� *CloseDialog+.��6R   Cancel6Z   �� 5Q      $��5 5 0 5q�6�   $��50��6�   ��6   �� *ActionDialog+��66   �� *ProductObject+{�6a   �� *	CanAction+��6�   �� *Action+$ TwoWay=�$ PropertyChanged=�6�   5R      5S      5T      