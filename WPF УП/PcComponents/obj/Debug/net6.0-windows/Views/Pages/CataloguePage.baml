   M S B A M L   `   `   `  ????G  CPcComponents, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:PcComponents.Views.PagesPcComponents.Views.Pages  5      ,    &PcComponents.Views.Pages.CataloguePage   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.7.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      2local&clr-namespace:PcComponents.Views.Pages  5      -   5          N? Title$  CataloguePage??5
      .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??0.8* ?6   6.   ?? 5      $
??0.3* ?6   6.   .+?5   
   ?? -   5         ??Name$ productList??5      $??0??6(   ??5      ?? 5      .R?5      ? $
??Auto??6   $??10q?6(    5      ?? 5      $
??0.2* ?6/   ?? 5      $
??0.6* ?6/   ?? 5      $
??0.2* ?6/   .+?5      ?? $??0??6    $??10q?6R   $??Uniform=?6^   $	??100??6p   $	??100??6}   $??Center=?6?   $??Center=?6?   ??60   ?? *ProductPicture+6?   ?? 5       ?? Orientation$ Vertical=?6%   $??1??6<   $??10 0 0 0q?6L   .+?5      ?? $ Vertical=?6)   $	??400??6@   .+?5   "   ?? $
??Wrap=?6-   $??20(?6`   $??DemiBold"?6n   ??6B   ?? *Product.Name+6?   5       ?? 5!       ??Name$ tbProductid??6C   $y?	Collapsed=?6X   
 ? Tag 6(   ?? *
Product.Id+6q   ?? 5"      $??16(?6B   ??6(   ?? *
Category+6S   ?? 5#      $??16(?6b   ??6(   ??  ?? Path$ Price? ?? StringFormat$ Цена: {0} руб??6r   ?? 5$      $??16(?6m   ??6(   ?? $ Product.Discount?$ Скидка: {0} %??6~   ?? 5%      $??16(?6y   ??6(   ?? $ CostWithDiscount?$/ )Цена со скидкой: {0} руб.??6?   5&      ?? 5'      $ 
Horizontal=?6&   $??2??6?   $??Center=?6O   $??Center=?6l   .+?5(      ?? -   5        $??5q?5(   %   $	??110??60   $??30??6<    6`   ?? *
Position+.??5)   "   ?? В корзину67   5*      5+      5,      5-      5/      ?? 52   
   $ Vertical=?6   $??1??6,   .+?54      ?? -   5        $ tbProductsCount??54   ?   $)??#Найдено N продуктов??6   $??20(?63   $??DemiBold"?6A   $??0 20 0 0q?6W   $??Center=?6i   $??Center=?6?   6?   ?? 56      $??Фильтр??6   $??20(?6&   $??DemiBold"?64   $??10q?6J   $??Center=?6V   $??Center=?6s   6?   ?? 57      -   5         ??Name$ textBlockProductName??57   4   $??0 10 0 5q?6   $	??200??6(   $??14(?6R   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$#	 Название товара??58      $??2q?6G      MaterialDesignDivider#???   59       ! MaterialDesignOutlinedTextBox#??[ 5:      ?? 5<      $??Категории:??6   $??14(?6*   $??
10 10 10 5q?69   6O   ?? 5=      -   5        
 ??Name$
 cbCategories??5=   /   $	??190??6   $??10q?6#   6x   ?? 5>      $!??Фильтр по цене:??6   $??14(?6/   $??
10 10 10 5q?6>   6T   	? 5?      -   5         	?Name$ 	rbCostAsc??5?       	? 	GroupName$ CostSort??6-   $!??По возрастанию??6B    d? 	IsChecked$
 TrueY?6[   $??	10 0 0 10q?6m   6?   	? 5@      -   5        $ 
rbCostDesc??5@      $ CostSort??6.   $??По убыванию??6C   $??	10 0 0 10q?6Z   6m   ?? 5A      $%??Фильтр по скидке:??6   $??14(?61   $??
10 10 10 5q?6@   6V   ?? 5B      -	   5        $
 cbDiscounts??5B   /   $	??200??6   $??10q?6#   6v   5D      5G      5H      