   M S B A M L   `   `   `  ����F  BSalesWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWpfAppSalesWpfApp  5      =#clr-namespace:SalesWpfApp.ViewModelSalesWpfApp.ViewModel  6/        SalesWpfApp.WindowProducts   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SalesWpfApp     5      9	viewmodel#clr-namespace:SalesWpfApp.ViewModel     6/     � SizeToContent$  WidthAndHeight=�5	       � WindowStartupLocation$ CenterScreen=�6&    � Title$ WindowProducts��5
       J� IsHitTestVisible 5      �� *
CanClick+ �� Mode$ TwoWay=�.��5      �� 
�������$��Stretch=�6$   $��Stretch=�6B   .+�5   
   �� $��5q�60   $	��100��6;   $
��Left=�6G   ��6   �� *
BackToMenu+.��6b   Back to menu6p   �� 5   
   $��	0 10 0 10q�6   $��30(�6'   $��Center=�65   $
��Bold"�6R   	Product6m   �� 5   
   $��5q�6    �� Orientation$ 
Horizontal=�6    .+�5      �� $��0 0 5 0q�6   $ 
Horizontal=�6*   .+�5      �� $
��Bold"�6   .��6*   Id6.   �� 5      $��50��6   6'   5      �� 5      $ 
Horizontal=�6   .+�5      �� $
��Bold"�6   .��6*   Name60   �� 5      $	��100��6   6(   5      �� 5      $��0 0 5 0q�6   $ 
Horizontal=�6*   .+�5      �� $
��Bold"�6   .��6*   Price61   �� 5      $��50��6   6'   5      �� 5      $��0 0 5 0q�6   $ 
Horizontal=�6*   .+�5      �� $
��Bold"�6   .��6*   Unit60   �� 5       $��50��6   6'   5!      �� 5#      .��6   Search6   5$      �� 5&   
   -   5         ��Name$ lvShow��5&   �   $	��200��6�   $
��Auto=�6�   $��10q�6�   ��6   �� *ProductObjects+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6l   �� *ProductObject+$ OneWayToSource=�	 �� View	 5'      �� 5(      .P�5)      �� 
 �� Width$
 40��6%   $��Id��60    �� CellTemplate 5*      �� 5+      .R�5,   "   �� ��6,   �� *	ProductId+6I   5-      5/      �� 51      $	
 100��6%   $��Category��61    52      �� 53      .R�54   "   �� ��6,   �� *
CategoryId+6J   55      57      �� 59      $	
 100��6%   $
��Name��61    5:      �� 5;      .R�5<   "   �� ��6,   �� *ProductName+6K   5=      5?      �� 5A      $
 80��6%   $��Weight��60    5B      �� 5C      .R�5D   "   �� ��6,   �� *Weight+6F   5E      5G      �� 5I      $
 60��6%   $��Price��60    5J      �� 5K      .R�5L   "   �� ��6,   �� *	UnitPrice+6I   5M      5O      �� 5Q      $
 60��6%   $��Stock��60    5R      �� 5S      .R�5T   "   �� ��6,   �� *	UnitStock+6I   5U      5W      5X      5Z      �� 5]   
   $��0 10 0 0q�6   $��Center=�6'   $ 
Horizontal=�6D   .+�5^      �� $��0 5 5 5q�6   $��50��6&   ��5_      �� *
AddCommand+.��69   Add6>   �� 5`      $��5q�6   $��50��6    {�5a      �� *	CanAction+��5b      �� *UpdateCommand+.��6;   Edit6A   �� 5c      $��5q�6   $��50��6    {�5d      �� *	CanDelete+��5e      �� *DeleteCommand+��5f      �� *ProductObject+.��6D   Delete6L   �� 5g      $��5 5 0 5q�6   $��50��6&   {�5h      �� *	CanDelete+��5i      �� *
BuyCommand+��5j      �� *ProductObject+.��6D   Buy6I   5k      5l      5m      