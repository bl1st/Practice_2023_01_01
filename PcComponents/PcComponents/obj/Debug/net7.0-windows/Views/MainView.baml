   M S B A M L   `   `   `  ����G  CPcComponents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PcComponents.ViewsPcComponents.Views  5   	   !    PcComponents.Views.MainView   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:PcComponents.Views     5   	     � Title$+  %OOO 'Компьютерный мир'��5   	   $	��600��6(   $
��1300��65    � Icon$2 ,pack://application:,,,/Resources/appicon.ico��5	   	   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��0.2* �6   �� 5      $
��0.8* �6   .+�5   
   �� $��0��6   ���#D8BFD8$��1��66   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ #7B68EE��6#    � Offset$ 2Q�63   � 5      $ White��6#   $ 10Q�61   5      5      �� 5   
   $��1��6   ��5      �� 5      $ 0.5,1&�6&   $ 0.5,0&�67   .��5      � $ #E6E6FA��6#   $ 1Q�63   5      5!      �� 5$   
   $��0��6    �� Orientation$ Vertical=�6%   $
��Auto��6<   .+�5&      �� ���#9370DB$��1q�6+   $
��Auto��6?   ._�5'      �� $ 
Horizontal=�6   $
��Auto��62   $
��Auto��6?   $
��Left=�6M   .+�5(      �� $��5 5 0 0q�6   $/��)pack://application:,,,/Resources/logo.png��5)      $��40��5*       �� 5+      $��5 0 0 0q�6    $
��left=�61   $��Center=�6M   $��25(�5,      $��SemiBold"�6,   $��PcComponents��6B   5.      50      51      �� 53      -   5           Flat#��[  53      $	��230��63   $
��Left=�6]   $��5 5 0 0q�6x   .��54      �� $ 
Horizontal=�6   $
��Auto��66   $	��230��6D   .+�55      �� $��0 5 10 0q�6   $��30��56       J� Opacity$	 0.7Q�6(   $4��.pack://application:,,,/Resources/catalogue.png��57      �� 59      $��Center=�6!   $��0 5 0 0q�6<   $
��Auto��6M   $��18(�5:      $��Каталог��6'   5<      5=      �� 5?      -   5        	 ��Name$	 btnCart��5?   �   #��[  6   $	��230��63   $
��Left=�6X   $��5 5 0 0q�6s   .��5@      �� $ 
Horizontal=�6   $	��230��66   $
��Auto��6B   $
��Left=�6P   .+�5A      �� $��0 5 10 0q�6   $��30��5B      $	 0.7Q�6(   $/��)pack://application:,,,/Resources/cart.png��5C      �� 5E      -   5        
 ��Name$
 textBlockCart��5F   7   $��0 5 0 0q�5E       $��Center=�61   $��18(�5F      $��Корзина��6'   67   5G      5H      �� 5I      -   5        $	 btnCreateProduct��5J      #��[  5I      $
��Auto��63   $��0 0 0 0q�6A   .��5K      �� $ 
Horizontal=�6   $	��230��66   $
��Auto��6B   $
��Left=�6P   .+�5L      �� $��0 5 10 0q�6   $��30��5M      $	 0.7Q�6(   $8��2pack://application:,,,/Resources/createProduct.png��5N      �� 5P      $��5 5 0 0q�6    $��Center=�61   $��18(�5Q      $!��Добавить товар��6(   5S      5T      �� 5U      -   5        $	 btnOrdersPage��5V      #��[  5U      $
��Auto��63   $��0 0 0 50q�6@   .��5W      �� $ 
Horizontal=�6   $	��230��66   $
��Auto��6B   $
��Left=�6P   .+�5X      �� $��0 5 10 0q�6   $��25��5Y      $	 0.7Q�6(   $0��*pack://application:,,,/Resources/order.png��5Z      �� 5[      $��2 5 0 0q�6    $��Center=�61   $��18(�5\      $%��Просмотр заказов��6(   5^      5_      5`      �� 5a   
   $��0��6   $��Bottom=�6%   $ Vertical=�6@   .+�5b      �� -   5        $	 btnExit��5b   s   #��[  6   $
��Auto��63   $��Bottom=�6@   $��Bottom=�6X   $
��Left=�6�   .��5c      �� $ 
Horizontal=�6   $	��230��66   $
��Auto��6B   $
��Left=�6P   .+�5d      �� $��0 5 0 5q�6   $��25��5e      $	 0.7Q�6(   $1��+pack://application:,,,/Resources/logout.png��5f      �� 5h      $��10 5 0 0q�6    $��Center=�62   $��18(�5i      $��
Выход��6(   5l      5m      5n       � 5p   
   -   5          �Name$ _NavigationFrame��5p       $��1��6     � NavigationUIVisibility$ Hidden=�6:   6\   5q      5r      