   M S B A M L   `   `   `  ����F  BSalesWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWpfAppSalesWpfApp  5   	   =#clr-namespace:SalesWpfApp.ViewModelSalesWpfApp.ViewModel  5   	   =#clr-namespace:SalesWpfApp.ComponentSalesWpfApp.Component  5   	       SalesWpfApp.WindowLogin   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SalesWpfApp     5   	   9	viewmodel#clr-namespace:SalesWpfApp.ViewModel     5   	   :
components#clr-namespace:SalesWpfApp.Component     5   	     � SizeToContent$  WidthAndHeight=�5
   	    � WindowStartupLocation$ CenterScreen=�6(    � Title$ WindowLogin��5   	   .��5      �� 
�������$	��300��6$   $��Center=�60   $��Center=�6M   .+�5   
   �� $��0 10 0 0q�6   $��30(�6&   $��Center=�64   $
��Bold"�6Q   FStore6k   �� 5   
   $	��200��6   $
��Bold"�6   .��6.   Email65   �� 5   
   -   5         ��Name$ tbEmail��5      $	��4 2q�6_   $	��200��6m   ��6#   �� *Email+ �� UpdateSourceTrigger$ PropertyChanged=�6{   �� 5   
   $	��200��6   $
��Bold"�6   .��6.   
Password68   3   -SalesWpfApp.Component.BindablePasswordBoxxaml  5   
   $	��200��6}      Password 6-   �� *
Password+$ PropertyChanged=� �� Mode$ TwoWay=�6�   �� 5   
   $��	0 20 0 10q�6Q   $��50��6d   ��6   �� *LoginCommand+{�62   �� *
CanLogin+.��6p   Login6w   5      5      