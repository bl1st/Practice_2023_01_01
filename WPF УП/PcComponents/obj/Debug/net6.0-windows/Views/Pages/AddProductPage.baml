   M S B A M L   `   `   `  ????G  CPcComponents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:PcComponents.Views.PagesPcComponents.Views.Pages  5      -    'PcComponents.Views.Pages.AddProductPage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:PcComponents.Views.Pages     5        N? Title$  AddProductPage??5	      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??0.8* ?6   6.   ?? 5      $
??0.2* ?6   6.   .+?5   
   ?? $??0??6   .??5      ?  ? RowDefinitions 5      ?? 5      $
??0.2* ?6$   64   ?? 5      $
??0.8* ?6$   64   .+?5      ?? -   5         ??Name$ ProductStackPanel??5   C    ?? Orientation$ 
Horizontal=?6   $??0??66   .+?5      ?? -   5         ??Name$ imageProduct??5   l   $??0??6   $	??150??6,   $	??150??68   $
??Left=?6E   $??20q?6`   ??6?   ?? *ProductPicture+6?   ?? 5      $ Vertical=?6!   .+?5      ?? -   5        $??Center=?5   C   $
??Left=?6^   $??	0 20 0 10q?6y   $	??160??6?   .??6?   #!Изменить картинку6?   ?? 5      $ 
Horizontal=?6%   .+?5      ?? $??16(?6(   $??Название:??66   $??Center=?6G   6d   ?? 5       ?? TextWrapping$
 Wrap=?6D   $	??200??6X   $??10 0 0 0q?6d   $??16(?6v   $??Center=?6?   ??6&   ?? *Product.Name+6?   5      ?? 5       $ 
Horizontal=?6%   .+?5!      ?? $??16(?6(   $??Категория:??66   6J   ?? 5"      -   5         ??Name$ 
cbCategory??5"   3   $	??200??6'   $??10 0 0 0q?6G   $??16(?6Y   6?   5#      ?? 5$      $ 
Horizontal=?6%   .+?5%      ?? $??16(?6(   $??	Цена:??66   $??0 0 35 0q?6C   6W   ?? 5&      -   5         ??Name$ tbProductCost??5&   m   $	??200??6&   $??Right=?6Q   $??10 0 0 0q?6?   $??16(?6?   ??62   ?? *Product.Price+6?   5'      ?? 5(      $ 
Horizontal=?6%   .+?5)      ?? $??16(?6(   $??Cкидка:??66   $??0 0 10 0q?6E   6Y   ?? 5*      -   5        $ 
tbDiscount??5*   ?   $??50??6&   $??Right=?6S   $??10 0 0 0q?6o   $??16(?6?   ??61   ?? *Product.Discount+6?   5+      ?? 5,      $ 
Horizontal=?6%   .+?5-      ?? $??16(?6(   $??Макс. скидка:??66   $??0 0 10 0q?6K   6_   ?? 5.      -   5        $ tbMaxDiscount??5.   ?   $??50??6&   $??Right=?6Z   $??10 0 0 0q?6v   $??16(?6?   ??61   ?? *Product.MaximumDiscount+6?   5/      51      52      ?? 53      $ Vertical=?6   $??1??64   .+?54      ?? $3??-Характеристики продукта??6    $??16(?6?   $??10 0 0 0q?6M   6a   &   System.Windows.Controls.DataGrid  55      -   5        	  Name$	 DataGridCharacteristics??55       
   AutoGenerateColumns$
 false??6A   $??0 10 0 0q?6]      Columns 57      0  *System.Windows.Controls.DataGridTextColumn  58      ,  &System.Windows.Controls.DataGridColumn   Header$ Id??61      Width5  /System.Windows.Controls.DataGridLengthConverter$ 0 59   !   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5:   !   ?? *Id+  5=   "   $" Характеристика??65   $
 Auto 5>   !      
IsReadOnly$
 True??5?   >    6!   ?? *
CharName+6>     5B      $ Значение??61   $	 200 5C   !    5D   !   ?? *	CharValue+4  .System.Windows.Controls.DataGridTemplateColumn  5F      $ Ед. измерения??65   $	 100 6L      CellTemplate 5G   "   ?? 5H   &   .R?5I   *   ?? ??62   ?? *Unit+5J   '   5L      5R      5V      5W      5Z      ?? 5\   
   -	   5        $??1??5\      $??20q?6!   $	??Top=?6F   .??6^   Сохранить6i   ?? 5]   
   -
   5        $??1??5]      $??20q?6!   $??Bottom=?6I   .??6d   
Назад6k   5`      5a      