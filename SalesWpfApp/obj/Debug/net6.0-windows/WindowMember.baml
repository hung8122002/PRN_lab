   M S B A M L   `   `   `  ����F  BSalesWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWpfAppSalesWpfApp  5      =#clr-namespace:SalesWpfApp.ViewModelSalesWpfApp.ViewModel  5   	       SalesWpfApp.WindowMember   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SalesWpfApp     5      9	viewmodel#clr-namespace:SalesWpfApp.ViewModel     5   	     � SizeToContent$  WidthAndHeight=�5	       � WindowStartupLocation$ CenterScreen=�69    � Title$ WindowMember��5
       J� IsHitTestVisible 5   	   �� *
CanClick+ �� Mode$ TwoWay=�.��5      �� 
�������$��Stretch=�6$   $��Stretch=�6B   .+�5   
   �� $��5q�60   $	��100��6;   $
��Left=�6G   ��6   �� *
BackToMenu+.��6b   Back to menu6p   �� 5   
   $��	0 10 0 10q�6   $��30(�6'   $��Center=�65   $
��Bold"�6R   Member6l   �� 5      -   5         ��Name$ lvShow��5   d   $	��200��6   $
��Auto=�6'   $��10q�6W   ��6t   �� *MemberObjects+$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *MemberObject+$ OneWayToSource=� �� View 5      �� 5      .P�5      �� 	 �� Width$	 40��6)   $��ID��64   
 �� CellTemplate
 5      �� 5   "   .R�5   &   �� ��60   �� *
MemberId+6L   5   #   5      �� 5      $		 150��6)   $��Email��65   
 5      �� 5   "   .R�5   &   �� ��60   �� *Email+6I   5   #   5      �� 5!      $		 100��6)   $��Company��65   
 5"      �� 5#   "   .R�5$   &   �� ��60   �� *CompanyName+6O   5%   #   5'      �� 5)      $		 100��6)   $
��City��65   
 5*      �� 5+   "   .R�5,   &   �� ��60   �� *City+6H   5-   #   5/      �� 51      $		 100��6)   $��County��65   
 52      �� 53   "   .R�54   &   �� ��60   �� *	Country+6K   55   #   57      58      5:      �� 5<      $��0 10 0 0q�6   $��Center=�6+    �� Orientation$ 
Horizontal=�6H   .+�5=      �� $��0 5 5 5q�6   $��50��6*   ��5>      �� *
AddCommand+.��68   Add6=   �� 5?      $��5q�6   $��50��6$   {�5@      �� *	CanAction+��5A      �� *UpdateCommand+.��6;   Edit6A   �� 5B      $��5 5 0 5q�6   $��50��6*   {�5C      �� *	CanDelete+��5D      �� *DeleteCommand+��5E      �� *MemberObject+.��6C   Delete6K   5F      5G      5H      